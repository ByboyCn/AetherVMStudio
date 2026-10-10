cmake_minimum_required(VERSION 3.20)
project(aevm_bridge CXX)

set(CMAKE_CXX_STANDARD 20)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

# AETHERVM_ROOT 指向 icpp 预编译包解包目录(内含 include/aevm 头文件与 AetherVM 动态库):
#   cmake -S native -B build -DAETHERVM_ROOT=/path/to/icpp-v0.4.0-<platform>
if(NOT DEFINED AETHERVM_ROOT)
    message(FATAL_ERROR "请通过 -DAETHERVM_ROOT=<icpp 包解包目录> 指定 AetherVM 根目录")
endif()
message(STATUS "AETHERVM_ROOT = ${AETHERVM_ROOT}")

add_library(aevm_bridge SHARED AetherVMBridge.cpp)

target_include_directories(aevm_bridge PRIVATE ${AETHERVM_ROOT}/include)

if(WIN32)
    # icpp 包内的 AetherVM.dll 无导入库;从导出表现场生成 AetherVM.lib
    find_file(AETHERVM_DLL AetherVM.dll PATHS ${AETHERVM_ROOT}/bin REQUIRED)

    # 复用 MSVC 工具链的 link.exe / lib.exe
    get_filename_component(_bindir "${CMAKE_LINKER}" DIRECTORY)
    find_program(LINKER_TOOL link HINTS "${_bindir}" REQUIRED)
    find_program(ARCHIVER_TOOL lib HINTS "${_bindir}" REQUIRED)

    set(AETHERVM_IMPLIB "${CMAKE_CURRENT_BINARY_DIR}/AetherVM.lib")
    add_custom_command(
        OUTPUT "${AETHERVM_IMPLIB}"
        COMMAND "${CMAKE_COMMAND}"
                -D DLL="${AETHERVM_DLL}"
                -D LINKER="${LINKER_TOOL}"
                -D ARCHIVER="${ARCHIVER_TOOL}"
                -D OUT="${AETHERVM_IMPLIB}"
                -P "${CMAKE_CURRENT_SOURCE_DIR}/genwinlib.cmake"
        DEPENDS "${AETHERVM_DLL}"
        COMMENT "从 AetherVM.dll 生成导入库"
        VERBATIM
    )
    add_custom_target(aethervm_implib DEPENDS "${AETHERVM_IMPLIB}")
    add_dependencies(aevm_bridge aethervm_implib)
    target_link_libraries(aevm_bridge PRIVATE "${AETHERVM_IMPLIB}")
else()
    find_library(AETHERVM_RUNTIME
        NAMES AetherVM
        PATHS ${AETHERVM_ROOT}/lib ${AETHERVM_ROOT}/bin
        REQUIRED
    )
    target_link_libraries(aevm_bridge PRIVATE ${AETHERVM_RUNTIME})
endif()
message(STATUS "AetherVM runtime: ${AETHERVM_RUNTIME}")
