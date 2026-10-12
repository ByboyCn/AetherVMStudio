# 第三方组件声明 / THIRD-PARTY NOTICES

本仓库(自有代码,MIT 许可)在构建与运行时引用了以下第三方组件。
各组件版权归其各自作者所有,并遵循其原始许可证。

---

## 1. AetherVM

- **项目**:https://github.com/AetherVM/AetherVM
- **许可证**:Apache License 2.0
- **版权**:Copyright (c) AetherVM 作者
- **用途**:多指令集(AArch64 / x86_64)二进制仿真核心引擎;运行时以动态库形式随包分发
- **完整许可文本**:https://www.apache.org/licenses/LICENSE-2.0

## 2. AetherBinary

- **项目**:https://github.com/AetherVM/AetherBinary
- **许可证**:Apache License 2.0
- **用途**:MachO/ELF/PE 二进制分析支持(`Machine` 架构实例由其提供)
- **完整许可文本**:https://www.apache.org/licenses/LICENSE-2.0

## 3. ICPP

- **项目**:https://github.com/vpand/icpp
- **许可证**:Apache License 2.0
- **用途**:AetherVM 官方生态工具链;本项目的 CI 与本地构建使用其预编译包中附带的
  AetherVM / AetherBinary 运行库、语义 bitcode 以及 clang++ 工具链
- **完整许可文本**:https://www.apache.org/licenses/LICENSE-2.0

---

## 4. TCYM.UI(界面框架)

- **项目**:https://tcym.top:8035/tcym/UI/Doc/index.html
- **作者**:TCYM
- **许可证**:**自定义许可**(随 NuGet 包附带 LICENSE.txt)

> 原文要点(English excerpt from the package's LICENSE.txt):
>
> "Copyright (c) 2026 TCYM. All rights reserved.
>  This package is provided by TCYM. You may use this package only under the
>  terms granted by TCYM. Redistribution, modification, sublicensing, or resale is
>  not permitted unless you have written permission from TCYM."

**重要提示**:TCYM.UI 禁止未经书面许可的再分发。本仓库的 Release 产物中包含
TCYM.UI 运行库,仅供仓库所有者在已获授权的前提下分发;任何第三方若要公开分发
包含 TCYM.UI 的构建产物,请自行与 TCYM 作者确认授权。

## 5. SkiaSharp

- **项目**:https://github.com/mono/SkiaSharp
- **许可证**:MIT License
- **版权**:Copyright (c) .NET Foundation and Contributors
- **用途**:2D 图形渲染(TCYM.UI 的绘制后端)

## 6. SDL3

- **项目**:https://github.com/libsdl-org/SDL
- **许可证**:zlib License
- **版权**:Copyright (C) 1997-2026 Sam Lantinga <slouken@libsdl.org>
- **用途**:窗口、输入与平台抽象层(TCYM.UI 的宿主运行时)

---

## 本仓库自有代码

除上述第三方组件外,本仓库的全部代码(包括 `native/AetherVMBridge.cpp`、
`AetherVMStudio.CS/` 下的 C# 代码与 `AetherVMStudio/` 下的 Swift 界面代码)
以 [MIT License](LICENSE) 发布。

Copyright (c) 2026 ByboyCn
