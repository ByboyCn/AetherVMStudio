# genwinlib.cmake — 从 DLL 导出表生成 MSVC 导入库(.lib)
# 用法: cmake -D DLL=... -D LINKER=link.exe -D ARCHIVER=lib.exe -D OUT=... -P genwinlib.cmake

set(TMP_DIR "${CMAKE_CURRENT_BINARY_DIR}/genwinlib")
file(MAKE_DIRECTORY "${TMP_DIR}")
set(DUMP_TXT "${TMP_DIR}/exports.txt")

execute_process(
    COMMAND "${LINKER}" /DUMP /EXPORTS "${DLL}"
    OUTPUT_FILE "${DUMP_TXT}"
    RESULT_VARIABLE rc
)
if(NOT rc EQUAL 0)
    message(FATAL_ERROR "link /DUMP /EXPORTS 失败: ${rc}")
endif()

# 解析导出名:导出表格式为 "    ordinal hint RVA       name"
file(STRINGS "${DUMP_TXT}" LINES)
set(EXPORTS "")
set(IN_SECTION FALSE)
foreach(line IN LINES LINES)
    string(REGEX MATCH "^[ ]*[0-9]+[ ]+[0-9A-Fa-f]+[ ]+[0-9A-Fa-f]+[ ]+([^ ]+)$" m "${line}")
    if(m)
        list(APPEND EXPORTS "${CMAKE_MATCH_1}")
    endif()
endforeach()

list(LENGTH EXPORTS count)
if(count EQUAL 0)
    message(FATAL_ERROR "未能从 ${DLL} 解析出任何导出符号")
endif()
message(STATUS "解析到 ${count} 个导出符号")

set(DEF_FILE "${TMP_DIR}/AetherVM.def")
set(def_content "LIBRARY AetherVM\nEXPORTS\n")
foreach(sym IN LISTS EXPORTS)
    string(APPEND def_content "    ${sym}\n")
endforeach()
file(WRITE "${DEF_FILE}" "${def_content}")

execute_process(
    COMMAND "${ARCHIVER}" /NOLOGO /DEF:"${DEF_FILE}" /MACHINE:X64 /OUT:"${OUT}"
    RESULT_VARIABLE rc
)
if(NOT rc EQUAL 0)
    message(FATAL_ERROR "lib /DEF 失败: ${rc}")
endif()
message(STATUS "已生成导入库: ${OUT}")
