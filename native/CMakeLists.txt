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

target_include_directories(aevm_bridge PRIVATE
    ${AETHERVM_ROOT}/include
    ${AETHERVM_ROOT}/include/aebi
)

if(WIN32)
    # Windows:icpp 包内 AetherVM.dll / AetherBinary.dll 均无导入库。
    # CI 侧会用 dumpbin+lib 生成 *.lib 并通过 -DAETHERVM_IMPLIB(分号分隔)传入;
    # 本地开发可手动执行 native/genwinlib.ps1。
    if(DEFINED AETHERVM_IMPLIB AND EXISTS "${AETHERVM_IMPLIB}")
        foreach(imp IN LISTS AETHERVM_IMPLIB)
            if(EXISTS "${imp}")
                message(STATUS "使用导入库: ${imp}")
                target_link_libraries(aevm_bridge PRIVATE "${imp}")
            endif()
        endforeach()
    else()
        message(WARNING "未提供 AETHERVM_IMPLIB,尝试直接链接 DLL(MSVC link 可能拒绝)")
        find_file(AETHERVM_DLL AetherVM.dll PATHS ${AETHERVM_ROOT}/bin REQUIRED)
        target_link_libraries(aevm_bridge PRIVATE "${AETHERVM_DLL}")
    endif()
else()
    find_library(AETHERVM_RUNTIME
        NAMES AetherVM
        PATHS ${AETHERVM_ROOT}/lib ${AETHERVM_ROOT}/bin
        REQUIRED
    )
    find_library(AETHERBINARY_RUNTIME
        NAMES AetherBinary
        PATHS ${AETHERVM_ROOT}/lib ${AETHERVM_ROOT}/bin
        REQUIRED
    )
    target_link_libraries(aevm_bridge PRIVATE ${AETHERVM_RUNTIME} ${AETHERBINARY_RUNTIME})
    message(STATUS "AetherVM runtime: ${AETHERVM_RUNTIME}")
    message(STATUS "AetherBinary runtime: ${AETHERBINARY_RUNTIME}")
endif()
