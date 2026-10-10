# AetherVM Studio — C# / TCYM.UI 跨平台版

用 **C# + [TCYM.UI](https://tcym.top:8035/tcym/UI/Doc/index.html)**(SDL + SkiaSharp 自绘框架)重写的 AetherVM 仿真调试界面,
一套代码跑 **Windows / macOS / Linux**(TCYM.UI 自带各平台原生依赖)。

## 功能(与 Swift 版对齐)

- 双架构:ARM64 / x86_64 guest
- 三种代码输入:粘贴 hex、输入 `.bin` 路径加载、内置示例
- 初始寄存器配置(`x0 = 0x1` 每行一条)
- 运行 / 单步 / 重置
- 实时寄存器面板、十六进制内存查看器、执行 Trace、控制台
- EventConfig 插桩开关(lift / memory / insn / block / syscall / trap / bridge …)
- 引擎抽象层 `IEmulationEngine`:
  - `DemoEngine` — 纯 C# 演示解释器,开箱即用
  - `AetherVMBridge` — AetherVM(C++)P/Invoke 接入点,编译好桥接库即可切换

## 构建

```sh
cd AetherVMStudio.CS
dotnet build -c Release
dotnet run
```

> **包引用**:`AetherVMStudio.csproj` 里按 NuGet 包名 `TCYM.UI` / `TCYM.UI.Chart` 引用。
> 如果你的 TCYM.UI 不是走公共 NuGet(本地 nupkg / 私有源),改成:
> ```xml
> <PackageReference Include="TCYM.UI" Version="0.1.1.24" />
> ```
> 版本对应文档站所示 `0.1.1.24`(Chart `0.1.1.25`),或换成本地路径 `<ProjectReference>` / `Path` 形式。

## 发布到 GitHub(私有仓库 + Actions 自动打包)

本仓库自带 [.github/workflows/release.yml](../.github/workflows/release.yml),
推送 tag `v*` 时会自动构建 **6 个平台包**并上传到 GitHub Release:

| RID | 平台 | 包格式 |
|---|---|---|
| win-x64 / win-arm64 | Windows | .zip |
| osx-x64 / osx-arm64 | macOS (Intel / Apple Silicon) | .zip |
| linux-x64 / linux-arm64 | Linux | .tar.gz |

首次发布步骤(本机已装 gh CLI):

```sh
# 1. 登录 GitHub(只需一次)
gh auth login

# 2. 创建私有仓库并推送(在仓库根目录执行)
gh repo create AetherVMStudio --private --source . --push

# 3. 发版:打 tag 即触发六平台构建 + Release 上传
git tag v0.1.0
git push origin main --tags
```

也可以在 GitHub 网页 Actions 页手动触发(workflow_dispatch),包会出现在 Actions Artifacts。

### 本地手动打单文件包

```sh
# macOS (Apple Silicon)
dotnet publish -c Release -r osx-arm64 --self-contained -p:PublishSingleFile=true
# Windows x64
dotnet publish -c Release -r win-x64 --self-contained -p:PublishSingleFile=true
# Linux x64
dotnet publish -c Release -r linux-x64 --self-contained -p:PublishSingleFile=true
```

## 目录结构

```
AetherVMStudio.CS/
├── AetherVMStudio.csproj       # net8.0,TCYM.UI + SkiaSharp
├── Program.cs                  # UIApp.Run 入口
├── Core/
│   ├── EmulationCore.cs        # 架构/事件/Trace/内存模型 + IEmulationEngine 协议
│   ├── DemoEngine.cs           # 内置演示引擎(ARM64: mov/movz/add/nop/ret;x86: mov r32/nop/ret)
│   ├── AetherVMBridge.cs       # C++ 桥接 P/Invoke 骨架(TODO 注释齐备)
│   └── EmulationViewModel.cs   # 视图模型(hex 解析、执行控制、格式化)
└── UI/
    └── MainWindow.cs           # TCYM.UI 组件树(CSS flex 布局)
```

## 接入真正的 AetherVM

1. 在目标平台用 ICPP 编译 AetherVM,并把引擎封装成 **C ABI 动态库**(每个平台一个二进制);
2. 按 `Core/AetherVMBridge.cs` 顶部注释实现 C++ 导出函数;
3. 取消 P/Invoke 注释、`IsAvailable = true`;
4. UI 自动切换到真实引擎,业务代码零改动。

## 参考

- 完整 TCYM.UI / Chart API 文档已提取到 `../TCYM-Docs/`(1057 篇,含 UIApp、UIWindow、各组件、图表)
- AetherVM 学习笔记:`../AetherVM-notes.md`(default-workspace)
- Swift/SwiftUI 版本:`../AetherVMStudio/`
