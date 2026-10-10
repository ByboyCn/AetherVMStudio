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
    # MSVC 链接器支持直接对 DLL 链接(自动生成导入库)
    find_file(AETHERVM_RUNTIME AetherVM.dll PATHS ${AETHERVM_ROOT}/bin REQUIRED)
    target_link_libraries(aevm_bridge PRIVATE ${AETHERVM_RUNTIME})
else()
    find_library(AETHERVM_RUNTIME
        NAMES AetherVM
        PATHS ${AETHERVM_ROOT}/lib ${AETHERVM_ROOT}/bin
        REQUIRED
    )
    target_link_libraries(aevm_bridge PRIVATE ${AETHERVM_RUNTIME})
endif()
message(STATUS "AetherVM runtime: ${AETHERVM_RUNTIME}")
