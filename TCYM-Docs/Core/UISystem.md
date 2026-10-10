# UISystem

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

应用级 UI 系统入口（全局管理类）。 提供： - 初始化底层平台（SDL + 可选 OpenGL/Skia GPU）。 - 初始化 UI 管理器（布局、事件、渲染）。 - 驱动主循环与关闭释放。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `ResourceAssemblyResolver` | `Func<string, System.Reflection.Assembly?>?` | 设计时资源解析钩子，允许调用方为特定程序集名称返回当前应使用的已加载程序集实例。 |
| `RuntimeHandle` | `class` | 用于链式调用的运行时句柄。 |
| `Manager` | `UIManager?` | UI 管理器（元素树、布局与渲染）。 |
| `DefaultFontPath` | `string` | 默认字体路径，支持 res:// 与文件系统路径。 默认值为嵌入资源 res://TCYM.UI/TCYM.UI.ttf。 可在调用 Initialize 前修改以使用自定义字体。 |
| `DefaultIconFontPath` | `string` | 默认图标字体路径，支持 res:// 与文件系统路径。 默认值为嵌入资源 res://TCYM.UI/TCYM.UI.Icon.ttf。 可在调用 Initialize 前修改以使用自定义图标字体。 |
| `DefaultWindowIconPath` | `string?` | 默认窗口图标路径，支持 res:// 与文件系统路径。 例如："Assets/Images/ico.png" 或 "res://TCYM.UI/Assets.Images.ico.png"。 可在调用 Initialize 前修改。 |
| `DefaultWindowAlwaysOnTop` | `bool` | 默认窗口是否始终置顶。 可在调用 Initialize 前修改。 |
| `DefaultWindowResizable` | `bool` | 默认窗口是否允许用户自由调整大小（类似 Electron 的 resizable）。 默认为 false（保持固定大小）。可在调用 <see cref="Initialize(string,int,int,int,string,bool?,bool?,bool?)"/> 前修改， 或在初始化后通过 <see cref="SetWindowResizable"/> 动态切换。 |
| `DefaultCpuRenderMode` | `UICpuRenderMode` | 新管理器的 CPU 窗口模式默认值；默认 WorkerThread，保留兼容回退，不改变已创建窗口。 |
| `DefaultGpuRenderMode` | `UIGpuRenderMode` | 新管理器的 GPU 默认线程策略；与 CPU 设置独立，实际执行及回退见 LastGpuRenderStatus。 |
| `DefaultCpuBackdropQuality` | `UICpuBackdropQuality` | 新 UIManager 的 CPU 背景特效默认档位；不改变已有窗口，默认保留完整效果。 初始化后通过对应 UIManager.CpuBackdropQuality 修改单个窗口。 |
| `DefaultWindowCornerPreference` | `UIWindowCornerPreference` | 新窗口默认使用的原生圆角偏好。 默认为 <see cref="UIWindowCornerPreference.Default"/>，保持既有平台行为； Windows 10 及更高版本可设为 <see cref="UIWindowCornerPreference.Round"/> 或 <see cref="UIWindowCornerPreference.RoundSmall"/>；Windows 11 使用 DWM， Windows 10 使用 Alpha/Region 圆角，并单独请求 DWM 系统阴影。 |
| `DefaultWindowShadowPreference` | `UIWindowShadowPreference` | 新窗口默认使用的外阴影偏好。 <see cref="UIWindowShadowPreference.Default"/> 保留兼容行为； Windows 10 可显式设为 Enabled 或 Disabled，Windows 11/macOS/Linux 的系统阴影 仍由窗口管理器控制。 |
| `EnableWindowCornerAntialiasing` | `bool` | 是否为 Windows 10 GPU 窗口启用逐像素 Alpha 圆角抗锯齿。默认为 true。 应在 <see cref="Initialize(string,int,int,int,string,bool?,bool?,bool?)"/> 或创建 <see cref="UIWindow"/> 前设置； 遇到不兼容的混合显卡驱动时可设为 false，回退到 HRGN 硬边圆角。 |
| `EnableTouchMouseEvents` | `bool` | 是否允许 SDL 将触摸输入转换为鼠标事件。 关闭后，来自触摸的伪鼠标事件会被平台层忽略。 建议在调用 Initialize 前配置。 |
| `EnableFrameTimingLog` | `bool` | 是否启用帧分段性能日志。 开启后会输出 event/update/render/draw/swap 的耗时明细。 |
| `FrameTimingLogThresholdMs` | `int` | 帧分段性能日志的打印阈值（毫秒）。 当总帧耗时超过该阈值时会立即打印。 |
| `FrameTimingLogIntervalFrames` | `int` | 帧分段性能日志的周期输出间隔（帧数）。 即使未超阈值，也会按该间隔输出一次采样。 |
| `EnableRenderTypeProfile` | `bool` | 是否启用按元素类型聚合的渲染耗时统计。 开启后会随帧分段日志一起打印 [RenderProfile] 行，定位是哪些组件最贵。 |
| `RenderTypeProfileMinimumMilliseconds` | `double` | 获取或设置按元素类型输出渲染耗时的最低累计毫秒数。默认 0.5；设为 0 可查看所有已采样类型。 |
| `EnableGpuInitLog` | `bool` | 是否启用 GPU 初始化日志。 开启后会输出窗口创建、GL 上下文创建和 Skia GL 初始化的详细结果。 |
| `GpuMultisampleCount` | `int` | GPU 默认帧缓冲的 MSAA 采样数。默认 0（关闭），可设为 2、4、8 或 16。 MSAA 会明显增加与窗口物理像素数成正比的显存和进程工作集，应在调用 <see cref="Initialize(string,int,int,int,string,bool?,bool?,bool?)"/> 前设置。 |
| `DefaultRenderBackend` | `UIRenderBackendPreference` | 后续窗口的后端偏好；CPU 关闭 GPU，其它后端自动请求 GPU，不改现有窗口。 |
| `Closing` | `event EventHandler<UIWindowClosingEventArgs>?` | 窗口即将关闭时触发（类似 Avalonia 的 <c>Window.Closing</c>）。 <para> 在事件处理器中将 <see cref="UIWindowClosingEventArgs.Cancel"/> 设为 <see langword="true"/> 可阻止关闭。 </para> |
| `ClosingAsync` | `event Func<object?, UIWindowClosingEventArgs, Task>?` | 主窗口关闭前的异步门控事件。所有处理器完成后才读取 <see cref="UIWindowClosingEventArgs.Cancel"/> 并决定是否结束主循环。 任一处理器取消或失败时，本次关闭按失败处理并保持窗口打开。 |
| `Closed` | `event EventHandler?` | 窗口已关闭、主循环结束后触发（类似 Avalonia 的 <c>Window.Closed</c>）。 |
| `ClosedAsync` | `event Func<object?, EventArgs, Task>?` | 窗口和主循环关闭后触发的异步通知。 |
| `UnhandledException` | `event EventHandler<UIUnhandledExceptionEventArgs>?` | 当 TCYM.UI 在分发 UI 工作时捕获到异常后触发。 触发该事件后，UI 主循环仍会继续运行。 |
| `IsWindowCornerPreferenceSupported` | `bool` | 当前平台是否支持显式窗口圆角偏好。 Windows 10 及更高版本支持该能力。 |
| `IsWindowShadowPreferenceSupported` | `bool` | 当前平台是否支持提交窗口阴影策略。 当前为 Windows 10 主 HWND 的 DWM 策略；成功仅表示接受请求，实际效果由系统决定。 |

## 方法

### AttachMainWindow(UIWindow)

```csharp
void AttachMainWindow(UIWindow window)
```

多窗口模式：将某个 <see cref="UIWindow"/> 绑定为当前 UISystem 主窗口。 之后可直接使用 <see cref="Manager"/>、<see cref="SetWindowSize"/> 等操作。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `window` | `UIWindow` |  |

### Initialize(string, int, int, int, string?, bool?, bool?, bool?)

```csharp
void Initialize(string title = "TCYM.UI", int width = 800, int height = 600, int targetFps = SDLPlatform.DefaultTargetFps, string? windowIconPath = null, bool? windowAlwaysOnTop = null, bool? resizable = null, bool? enableMultiThreadedRendering = true)
```

初始化 UISystem，创建平台与 UI 管理器，并设置初始窗口大小。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` | 窗口标题 |
| `width` | `int` | 初始窗口逻辑宽度（DIP）；Windows 会按显示缩放转换为物理窗口像素。 |
| `height` | `int` | 初始窗口逻辑高度（DIP）；Windows 会按显示缩放转换为物理窗口像素。 |
| `targetFps` | `int` | 目标 FPS（默认 60），小于等于 0 使用默认值。 |
| `windowIconPath` | `string?` | 窗口图标路径（可选，支持 res:// 与文件系统路径）。为空时使用 <see cref="DefaultWindowIconPath"/>。 |
| `windowAlwaysOnTop` | `bool?` | 窗口是否始终置顶。为空时使用 <see cref="DefaultWindowAlwaysOnTop"/>。 |
| `resizable` | `bool?` | 窗口是否允许用户自由调整大小（类似 Electron 的 resizable）。为空时使用 <see cref="DefaultWindowResizable"/>。 |
| `enableMultiThreadedRendering` | `bool?` | 默认 true，同时开启本窗口 CPU/GPU 工作线程策略；false 关闭，显式 null 继承独立框架默认值。不修改全局默认值。 |

### Initialize(UIRenderBackendPreference, string, int, int, int, string?, bool?, bool?, bool?)

```csharp
void Initialize(UIRenderBackendPreference renderBackend, string title = "TCYM.UI", int width = 800, int height = 600, int targetFps = SDLPlatform.DefaultTargetFps, string? windowIconPath = null, bool? windowAlwaysOnTop = null, bool? resizable = null, bool? enableMultiThreadedRendering = true)
```

由后端偏好决定CPU/GPU，无需重复的GPU布尔开关；多线程默认true。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `renderBackend` | `UIRenderBackendPreference` |  |
| `title` | `string` |  |
| `width` | `int` |  |
| `height` | `int` |  |
| `targetFps` | `int` |  |
| `windowIconPath` | `string?` |  |
| `windowAlwaysOnTop` | `bool?` |  |
| `resizable` | `bool?` |  |
| `enableMultiThreadedRendering` | `bool?` |  |

### SetMultiThreadedRendering(bool)

```csharp
void SetMultiThreadedRendering(bool enabled)
```

在 UI 线程切换当前主窗口的 CPU/GPU 线程策略；不修改全局默认或其它窗口。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `enabled` | `bool` | true 为优先工作线程，false 为 UI 线程。 |

### Close()

```csharp
void Close()
```

以代码方式请求关闭窗口并结束主循环（类似 Avalonia 的 <c>Window.Close()</c>）。 会触发可取消的 <see cref="Closing"/> 和 <see cref="ClosingAsync"/> 门控； 存在异步门控时关闭会延迟提交，任一门控取消或失败时窗口保持打开。

### CloseAsync()

```csharp
Task<bool> CloseAsync()
```

异步请求关闭主窗口。同步和异步 <see cref="Closing"/> 门控均完成且未取消时， 才结束主事件循环。

**返回：** 关闭已成功提交时为 <see langword="true"/>；未初始化、正在关闭或被门控拒绝时为 <see langword="false"/>。

### Run()

```csharp
void Run()
```

进入主循环，直到窗口关闭或显式退出。 在调用 Run 之前必须先调用 Initialize。

### RequestMemoryCleanup(bool, int)

```csharp
void RequestMemoryCleanup(bool trimProcessWorkingSet = false, int delayMilliseconds = 250)
```

在界面空闲后合并执行一次进程级内存整理。它会压缩托管堆并清理已经完成终结的对象； 当 <paramref name="trimProcessWorkingSet"/> 为 true 时，Windows 下还会请求系统移出当前 未使用的工作集页面，使任务管理器中的驻留内存更快回落。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `trimProcessWorkingSet` | `bool` | 是否同时请求操作系统整理进程工作集。 |
| `delayMilliseconds` | `int` | 等待 UI 拆树、渲染资源清理和事件回调结束的时间。 |

### Shutdown()

```csharp
void Shutdown()
```

释放系统资源，关闭平台并清理管理器。 建议在应用退出路径中调用（如 finally 或 ProcessExit）。

### GetDeviceDpiInfo()

```csharp
(float Dpi, float Hdpi, float Vdpi, float Scale, int Width, int Height) GetDeviceDpiInfo()
```

获取当前设备 DPI、缩放和分辨率信息。

### GetDeviceScale()

```csharp
float GetDeviceScale()
```

获取当前设备缩放系数。

### GetDeviceResolution()

```csharp
(int Width, int Height) GetDeviceResolution()
```

获取当前设备分辨率。

### GetCurrentDisplayInfo()

```csharp
DisplayInfo GetCurrentDisplayInfo()
```

获取当前窗口所在显示器信息。

### GetAllDisplayInfo()

```csharp
List<DisplayInfo> GetAllDisplayInfo()
```

获取所有显示器信息。

### IsTabletDevice()

```csharp
bool IsTabletDevice()
```

判断当前设备是否为平板。

### GetCurrentTabletOrientation()

```csharp
UIDeviceOrientation GetCurrentTabletOrientation()
```

获取当前平板设备方向。 非平板设备返回 <see cref="UIDeviceOrientation.Unknown"/>。

### SetWindowTitle(string)

```csharp
void SetWindowTitle(string title)
```

设置窗口标题。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` | 窗口标题 |

### SetWindowIcon(string)

```csharp
bool SetWindowIcon(string path)
```

设置窗口图标（支持 res:// 与文件系统路径）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` | 图标路径 |

**返回：** 设置是否成功

### SetWindowAlwaysOnTop(bool)

```csharp
void SetWindowAlwaysOnTop(bool alwaysOnTop = true)
```

设置窗口是否始终置顶。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `alwaysOnTop` | `bool` | true 为置顶，false 为取消置顶 |

### SetWindowResizable(bool)

```csharp
void SetWindowResizable(bool resizable = true)
```

设置窗口是否允许用户自由调整大小（类似 Electron 的 resizable）。 启用后可拖动窗口边缘/角调整大小；最大化或全屏状态下自动禁用边缘缩放。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `resizable` | `bool` | true 允许调整大小，false 固定大小。 |

### IsWindowResizable()

```csharp
bool IsWindowResizable()
```

当前窗口是否允许用户自由调整大小。

### SetWindowCornerPreference(UIWindowCornerPreference)

```csharp
bool SetWindowCornerPreference(UIWindowCornerPreference preference)
```

设置当前窗口的原生圆角偏好。 最大化或全屏期间框架会临时使用直角，恢复后重新应用该偏好。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `preference` | `UIWindowCornerPreference` | 要提交给原生窗口管理器的圆角偏好。 |

**返回：** 当前平台已接受原生请求时为 true；不支持时为 false。

### SetWindowShadowPreference(UIWindowShadowPreference)

```csharp
bool SetWindowShadowPreference(UIWindowShadowPreference preference)
```

设置当前窗口的外阴影偏好。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `preference` | `UIWindowShadowPreference` | 外阴影偏好。 |

**返回：** 当前平台接受原生阴影请求时为 true；实际可见效果由系统决定。

### MinimizeWindow()

```csharp
void MinimizeWindow()
```

最小化窗口。

### ToggleMaximizeWindow()

```csharp
void ToggleMaximizeWindow()
```

切换窗口最大化/还原。

### IsWindowFullscreen()

```csharp
bool IsWindowFullscreen()
```

当前窗口是否处于全屏状态。

### SetWindowFullscreen(bool)

```csharp
void SetWindowFullscreen(bool fullscreen = true)
```

设置窗口全屏状态。 使用桌面级全屏，行为类似 Electron 的 fullscreen。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `fullscreen` | `bool` |  |

### ToggleFullscreenWindow()

```csharp
void ToggleFullscreenWindow()
```

切换窗口全屏/退出全屏。

### CloseWindow()

```csharp
void CloseWindow()
```

关闭窗口。

### OpenFilePickerAsync(FilePickerOpenOptions?)

```csharp
Task<IReadOnlyList<string>> OpenFilePickerAsync(FilePickerOpenOptions? options = null)
```

打开文件选择器，返回所选文件完整路径列表。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `options` | `FilePickerOpenOptions?` |  |

### OpenFolderPickerAsync(FolderPickerOpenOptions?)

```csharp
Task<IReadOnlyList<string>> OpenFolderPickerAsync(FolderPickerOpenOptions? options = null)
```

打开文件夹选择器，返回所选文件夹完整路径列表。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `options` | `FolderPickerOpenOptions?` |  |

### OpenFilePickerSdlAsync(FilePickerOpenOptions?)

```csharp
Task<IReadOnlyList<string>> OpenFilePickerSdlAsync(FilePickerOpenOptions? options = null)
```

使用 SDL3 原生文件对话框打开文件选择器（SDL3 新增能力，SDL2 无原生对话框）。 与 <see cref="OpenFilePickerAsync"/> 的区别在于后端由 SDL3 统一提供，无需各平台自有实现。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `options` | `FilePickerOpenOptions?` | 文件选择参数。 |

**返回：** 所选文件完整路径列表；取消或出错返回空列表。

### OpenFolderPickerSdlAsync(FolderPickerOpenOptions?)

```csharp
Task<IReadOnlyList<string>> OpenFolderPickerSdlAsync(FolderPickerOpenOptions? options = null)
```

使用 SDL3 原生文件对话框打开文件夹选择器（SDL3 新增能力）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `options` | `FolderPickerOpenOptions?` | 文件夹选择参数。 |

**返回：** 所选文件夹完整路径列表；取消或出错返回空列表。

### SaveFilePickerSdlAsync(string?, IReadOnlyList<FilePickerFileType>?)

```csharp
Task<string?> SaveFilePickerSdlAsync(string? suggestedStartLocation = null, IReadOnlyList<FilePickerFileType>? filters = null)
```

使用 SDL3 原生对话框打开保存文件对话框（SDL3 新增能力）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `suggestedStartLocation` | `string?` | 建议起始目录或文件名。 |
| `filters` | `IReadOnlyList<FilePickerFileType>?` | 文件类型过滤列表。 |

**返回：** 保存目标路径；取消或出错返回 null。

### OpenFolder(string)

```csharp
bool OpenFolder(string path)
```

在系统资源管理器（Windows: Explorer / macOS: Finder / Linux: xdg-open）中打开指定文件夹。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` | 要打开的文件夹路径，可为相对路径。 |

**返回：** 成功启动外部进程返回 true；路径为空、不存在或启动失败返回 false。

### SetWindowSize(int, int)

```csharp
void SetWindowSize(int width, int height)
```

以当前窗口中心为锚点设置窗口大小，并同步渲染尺寸。 放大或缩小时窗口会向四周同时变化，而不是固定左上角。 Windows 会按窗口当前所在显示器的缩放率换算；macOS/Linux 使用 SDL 逻辑窗口尺寸。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `width` | `int` | 目标逻辑宽度（DIP）。 |
| `height` | `int` | 目标逻辑高度（DIP）。 |

### MoveElement(string, string, int)

```csharp
bool MoveElement(string childId, string newParentId, int index = -1)
```

将一个元素移动到另一个元素的子级下（通过 Id 查找）。 <para> 例如：组件 A 的子级中有组件 C，调用 <c>UISystem.MoveElement("C", "B")</c> 可将 C 从 A 中移出并追加到组件 B 的子级末尾。自动维护父子关系、Id 索引、样式与重绘。 </para>

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `childId` | `string` | 要移动的元素 Id。 |
| `newParentId` | `string` | 目标父元素 Id。 |
| `index` | `int` | 在目标父级中的插入位置；小于 0 或超出范围时追加到末尾。 |

**返回：** 移动成功返回 true；任一元素不存在或移动非法返回 false。

### MoveElement(UIElement, UIElement, int)

```csharp
bool MoveElement(UIElement child, UIElement newParent, int index = -1)
```

将一个元素移动到另一个元素的子级下（直接引用）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `child` | `UIElement` | 要移动的元素。 |
| `newParent` | `UIElement` | 目标父元素。 |
| `index` | `int` | 在目标父级中的插入位置；小于 0 或超出范围时追加到末尾。 |

**返回：** 移动成功返回 true；参数为空或移动非法返回 false。

### ParseCssGlobal(string)

```csharp
void ParseCssGlobal(string css)
```

解析并注册全局 CSS（包含关键帧与全局样式）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `css` | `string` | 完整的 CSS 字符串 |

### RegisterClassStylesFromCss(string)

```csharp
void RegisterClassStylesFromCss(string css)
```

注册 CSS class 样式（包含关键帧）；无 sourceKey 时 @import 仅接受绝对文件或 res:// 地址。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `css` | `string` | CSS 字符串 |

### RegisterClassStylesFromCss(string, string?)

```csharp
void RegisterClassStylesFromCss(string css, string? sourceKey)
```

注册 CSS class 样式（包含关键帧），并允许按样式源替换旧规则。 当 sourceKey 是文件路径或 res:// 地址时，可作为相对 @import 的解析基址。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `css` | `string` | CSS 字符串 |
| `sourceKey` | `string?` | 样式源标识；相同 sourceKey 的后续注册会替换旧规则。 |

### RegisterGlobalDefaultsCss(string, string?)

```csharp
void RegisterGlobalDefaultsCss(string css, string? sourceName = null)
```

注册程序级全局默认 CSS。 适用于 Program.cs 中的 * / :root 默认样式，内部会为内联样式生成稳定的样式源标识， 以便后续样式重建时能够替换旧值而不是被清空。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `css` | `string` | CSS 字符串。 |
| `sourceName` | `string?` | 可选的内联样式源名称；不传时会基于入口程序集名生成。 |


---

# UISystem

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 方法

### Run(Action<UIManager>, UIRenderBackendPreference?, string, int, int, int, bool)

```csharp
void Run(Action<UIManager> initialize, UIRenderBackendPreference? renderBackend = null, string title = "TCYM.UI", int width = 800, int height = 600, int targetFps = 60, bool enableMultiThreadedRendering = true)
```

创建并运行主窗口；initialize中的UI对象从创建起属于专用逻辑线程。 原生窗口始终由调用Run的线程拥有。旧Initialize/Run用法保持不变。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `initialize` | `Action<UIManager>` | 初始化页面及事件；不要在此回调内再次调用Initialize或Run。 |
| `renderBackend` | `UIRenderBackendPreference?` | 后端偏好，空值沿用DefaultRenderBackend。 |
| `title` | `string` | 窗口标题。 |
| `width` | `int` | 窗口逻辑宽度。 |
| `height` | `int` | 窗口逻辑高度。 |
| `targetFps` | `int` | 目标帧率，1至240。 |
| `enableMultiThreadedRendering` | `bool` | 默认true使用分离宿主；false沿用原单线程入口。运行期间不迁移线程归属。 |
