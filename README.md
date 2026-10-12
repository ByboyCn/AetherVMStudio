<div align="center">

# ⚡ AetherVM Studio

**基于 [AetherVM](https://github.com/AetherVM/AetherVM) 的跨平台二进制仿真分析工作台**

Windows · macOS · Linux —— 一套代码,开箱即用

</div>

---

## 这是什么

AetherVM Studio 把 [AetherVM](https://github.com/AetherVM/AetherVM)(Lift. Instrument. Emulate. Recover.)封装成友好的桌面图形界面:

- 粘贴 hex / 加载 `.bin`,选好架构(ARM64 / x86_64),设置初始寄存器,一键仿真
- 实时查看**寄存器、执行 Trace、内存十六进制转储**
- 可配置 EventConfig 插桩(lift / memory / insn / block / syscall / trap / bridge …)
- 通过 C ABI 桥接层直接驱动真实 AetherVM 引擎;引擎缺失时自动回退内置演示解释器

典型用途:逆向 iOS/Mac App 中的签名、加密算法——抠出目标函数单独仿真,无需跑起整个 App。

## 下载

到 [Releases](../../releases) 页面下载对应平台的压缩包,解压即用,**无需安装 .NET**:

| 平台 | 文件 | 使用方式 |
|---|---|---|
| Windows x64 / ARM64 | `*-win-*.zip` | 解压后双击 `AetherVMStudio.exe` |
| macOS Apple Silicon / Intel | `*-osx-*.zip` | 解压得到 `.app`,双击运行;若提示无法验证开发者,执行 `xattr -cr AetherVMStudio.app` |
| Linux x64 / ARM64 | `*-linux-*.tar.gz` | 解压后 `./start.sh`;缺 SDL 运行库时 `sudo apt install libsdl3-0` |

## 从源码构建

```sh
git clone --recursive https://github.com/ByboyCn/AetherVMStudio.git
cd AetherVMStudio
dotnet publish AetherVMStudio.CS -c Release -r <你的 RID> --self-contained
# 例:win-x64 / osx-arm64 / linux-x64
```

或直接推送 `v*` tag,CI 会自动构建六平台并发布。

## 架构

```
┌─────────────────────────────────────────────┐
│  TCYM.UI 界面(SkiaSharp / SDL3 自绘)       │
├─────────────────────────────────────────────┤
│  IEmulationEngine(引擎抽象层)              │
│   ├── AetherVMBridge ──► aevm_bridge(C++)  │
│   │                       └─► AetherVM 引擎 │
│   └── DemoEngine(内置演示解释器)           │
└─────────────────────────────────────────────┘
```

详细说明见 [`AetherVMStudio.CS/README.md`](AetherVMStudio.CS/README.md)。

## 鸣谢

本项目站在以下优秀项目的肩膀上,感谢所有作者与贡献者:

| 项目 | 许可证 | 用途 |
|---|---|---|
| [AetherVM](https://github.com/AetherVM/AetherVM) | Apache-2.0 | 核心:多指令集仿真引擎(Lift → LLVM IR → Handler 链式执行) |
| [AetherBinary](https://github.com/AetherVM/AetherBinary) | Apache-2.0 | MachO/ELF/PE 分析支持 |
| [ICPP](https://github.com/vpand/icpp) | Apache-2.0 | AetherVM 生态;其发行包提供引擎运行库与 clang 工具链 |
| [TCYM.UI](https://tcym.top:8035/tcym/UI/Doc/index.html) | 自定义许可(见下方说明) | 跨平台 UI 框架(SDL + SkiaSharp 自绘,CSS flex 布局) |
| [SkiaSharp](https://github.com/mono/SkiaSharp) | MIT | 2D 图形渲染 |
| [SDL3](https://github.com/libsdl-org/SDL) | zlib | 窗口 / 输入 / 平台抽象层 |

同时感谢 [Remill](https://github.com/lifting-bits/remill) 与 [Unicorn](https://github.com/unicorn-engine/unicorn) —— AetherVM 的灵感来源与对照标杆。

### 关于 TCYM.UI 的许可

TCYM.UI 采用自定义许可:允许在 TCYM 授予的条款下使用,但**再分发、修改、转授权需事先获得 TCYM 书面许可**。本仓库以私有形式分发包含 TCYM.UI 运行库的构建产物;若你计划公开分发,请先与 TCYM 作者确认授权,或将 `AetherVMStudio.csproj` 中的 `TCYM.UI` 引用替换为你有权再分发的 UI 框架。

## 许可证

本仓库自有代码(AetherVMBridge.cpp / DemoEngine / 全部 C# 与 Swift 界面代码)以 [MIT License](LICENSE) 发布。

第三方组件遵循其各自许可证,详见 [THIRD-PARTY-NOTICES.md](THIRD-PARTY-NOTICES.md)。
