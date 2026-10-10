cmake_minimum_required(VERSION 3.20)
project(aevm_bridge CXX)

set(CMAKE_CXX_STANDARD 20)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

# AetherVM 以子模块位于 native/AetherVM,先用 ICPP 构建:
#   cd native/AetherVM && icpp build.cc
# 产物目录默认: native/AetherVM/build-Release/install
if(NOT DEFINED AETHERVM_ROOT)
    set(AETHERVM_ROOT "${CMAKE_CURRENT_SOURCE_DIR}/AetherVM/build-Release/install")
endif()
message(STATUS "AETHERVM_ROOT = ${AETHERVM_ROOT}")

add_library(aevm_bridge SHARED AetherVMBridge.cpp)

target_include_directories(aevm_bridge PRIVATE
    ${AETHERVM_ROOT}/include
    ${CMAKE_CURRENT_SOURCE_DIR}/AetherVM/include
)

find_library(AETHERVM_LIB
    NAMES AetherVM aether
    PATHS ${AETHERVM_ROOT}/lib ${AETHERVM_ROOT}/lib64 ${AETHERVM_ROOT}
    REQUIRED
)

target_link_libraries(aevm_bridge PRIVATE ${AETHERVM_LIB})
