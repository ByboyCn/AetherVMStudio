# UIApp

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

UI 应用对象。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `enableMultiThreadedRendering` | `UIApp(bool` | 为本应用后续创建的窗口指定 CPU/GPU 线程策略，不修改其他应用或全局默认。 |
| `enableMultiThreadedRendering` | `UIApp(UIRenderBackendPreference renderBackend, bool` | 在应用初始化时指定后端偏好，CPU/GPU 多线程仍默认开启。 |
| `RenderBackend` | `UIRenderBackendPreference` | 本应用后续窗口的后端偏好，不改变已经创建的窗口。 |
| `Windows` | `IReadOnlyCollection<UIWindow>` | 当前已创建且仍注册在应用中的窗口集合。 |

## 方法

### this()

```csharp
UIApp() : this( true)
```

默认开启 CPU/GPU 工作线程策略；保留原无参构造的 CLR 签名。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `true` | `` |  |

### SetMultiThreadedRendering(bool)

```csharp
void SetMultiThreadedRendering(bool enabled)
```

在 UI 线程同时切换本应用现有窗口和后续窗口；不会修改其他 UIApp。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `enabled` | `bool` | true 为优先工作线程，false 为 UI 线程。 |

### Post(Action)

```csharp
void Post(Action action)
```

投递一个动作到 UI 线程执行。 <para> 该方法是线程安全的：可从任意线程调用，并会通过 SDL 用户事件唤醒主事件循环。 </para>

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `action` | `Action` | 需要在 UI 线程执行的动作。 |

### InvokeAsync(Action)

```csharp
Task InvokeAsync(Action action)
```

在 UI 线程执行指定动作，并返回一个可等待的任务。 <para> 用于确保“创建窗口 / 修改 UI / 显示对话框”等操作在 UI 线程完成，避免 SDL 事件泵线程不一致导致的卡死。 </para>

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `action` | `Action` | 要在 UI 线程执行的动作。 |

**返回：** 动作执行完成后结束的任务。

### InvokeAsync(Func<Task>)

```csharp
Task InvokeAsync(Func<Task> action)
```

在 UI 线程开始并完整等待异步动作。 <para> 异步 lambda 会绑定到此重载，而不是转换成无法观察完成状态和异常的 <c>async void</c>。 </para>

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `action` | `Func<Task>` | 要在 UI 线程开始执行的异步动作。 |

**返回：** 异步动作执行完成后结束的任务。

### CreateWindow(string, int, int, bool, int, bool, bool)

```csharp
UIWindow CreateWindow(string title, int width, int height, bool enableGpu, int targetFps, bool autoShow, bool resizable)
```

保留旧 CLR 签名；省略参数的源码调用由新的可选参数入口承接。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` |  |
| `width` | `int` |  |
| `height` | `int` |  |
| `enableGpu` | `bool` |  |
| `targetFps` | `int` |  |
| `autoShow` | `bool` |  |
| `resizable` | `bool` |  |

### CreateWindow(string, int, int, bool, int, bool, bool, bool?)

```csharp
UIWindow CreateWindow(string title = "TCYM.UI", int width = 800, int height = 600, bool enableGpu = true, int targetFps = SDLPlatform.DefaultTargetFps, bool autoShow = true, bool resizable = false, bool? enableMultiThreadedRendering = null)
```

创建一个原生窗口。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` | 窗口标题。 |
| `width` | `int` | 窗口逻辑宽度（DIP）；Windows 会按显示缩放转换为物理窗口像素。 |
| `height` | `int` | 窗口逻辑高度（DIP）；Windows 会按显示缩放转换为物理窗口像素。 |
| `enableGpu` | `bool` | 是否启用 GPU 渲染。 |
| `targetFps` | `int` | 目标帧率（渲染节流参考）。 |
| `autoShow` | `bool` | 是否自动显示窗口。 |
| `resizable` | `bool` | 是否允许用户自由调整窗口大小（类似 Electron 的 resizable）。 |
| `enableMultiThreadedRendering` | `bool?` | 本窗口 CPU/GPU 线程策略；null 继承应用配置（应用出厂默认 true）。 |

**返回：** 创建出的 <see cref="UIWindow"/>。

### CreateWindowWithBackend(UIRenderBackendPreference, string, int, int, bool, int, bool, bool, bool?)

```csharp
UIWindow CreateWindowWithBackend(UIRenderBackendPreference renderBackend, string title = "TCYM.UI", int width = 800, int height = 600, bool enableGpu = true, int targetFps = SDLPlatform.DefaultTargetFps, bool autoShow = true, bool resizable = false, bool? enableMultiThreadedRendering = null)
```

为单个窗口指定后端偏好，不临时改写应用或全局默认。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `renderBackend` | `UIRenderBackendPreference` |  |
| `title` | `string` |  |
| `width` | `int` |  |
| `height` | `int` |  |
| `enableGpu` | `bool` |  |
| `targetFps` | `int` |  |
| `autoShow` | `bool` |  |
| `resizable` | `bool` |  |
| `enableMultiThreadedRendering` | `bool?` |  |

### CreateWindow(UIWindowCornerPreference, string, int, int, bool, int, bool, bool)

```csharp
UIWindow CreateWindow(UIWindowCornerPreference cornerPreference, string title, int width, int height, bool enableGpu, int targetFps, bool autoShow, bool resizable)
```

保留带圆角偏好的旧 CLR 签名。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `cornerPreference` | `UIWindowCornerPreference` |  |
| `title` | `string` |  |
| `width` | `int` |  |
| `height` | `int` |  |
| `enableGpu` | `bool` |  |
| `targetFps` | `int` |  |
| `autoShow` | `bool` |  |
| `resizable` | `bool` |  |

### CreateWindow(UIWindowCornerPreference, string, int, int, bool, int, bool, bool, bool?)

```csharp
UIWindow CreateWindow(UIWindowCornerPreference cornerPreference, string title = "TCYM.UI", int width = 800, int height = 600, bool enableGpu = true, int targetFps = SDLPlatform.DefaultTargetFps, bool autoShow = true, bool resizable = false, bool? enableMultiThreadedRendering = null)
```

使用指定原生圆角偏好创建窗口。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `cornerPreference` | `UIWindowCornerPreference` | 窗口圆角偏好；不支持的平台保留系统默认外观。 |
| `title` | `string` | 窗口标题。 |
| `width` | `int` | 窗口逻辑宽度（DIP）；Windows 会按显示缩放转换为物理窗口像素。 |
| `height` | `int` | 窗口逻辑高度（DIP）；Windows 会按显示缩放转换为物理窗口像素。 |
| `enableGpu` | `bool` | 是否启用 GPU 渲染。 |
| `targetFps` | `int` | 目标帧率（渲染节流参考）。 |
| `autoShow` | `bool` | 是否自动显示窗口。 |
| `resizable` | `bool` | 是否允许用户自由调整窗口大小。 |
| `enableMultiThreadedRendering` | `bool?` | 本窗口 CPU/GPU 线程策略；null 继承应用配置（应用出厂默认 true）。 |

**返回：** 创建出的 <see cref="UIWindow"/>。

### CreateWindowWithAppearance(UIWindowCornerPreference, UIWindowShadowPreference, string, int, int, bool, int, bool, bool)

```csharp
UIWindow CreateWindowWithAppearance(UIWindowCornerPreference cornerPreference, UIWindowShadowPreference shadowPreference, string title, int width, int height, bool enableGpu, int targetFps, bool autoShow, bool resizable)
```

保留带独立圆角/阴影偏好的旧 CLR 签名。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `cornerPreference` | `UIWindowCornerPreference` |  |
| `shadowPreference` | `UIWindowShadowPreference` |  |
| `title` | `string` |  |
| `width` | `int` |  |
| `height` | `int` |  |
| `enableGpu` | `bool` |  |
| `targetFps` | `int` |  |
| `autoShow` | `bool` |  |
| `resizable` | `bool` |  |

### CreateWindowWithAppearance(UIWindowCornerPreference, UIWindowShadowPreference, string, int, int, bool, int, bool, bool, bool?)

```csharp
UIWindow CreateWindowWithAppearance(UIWindowCornerPreference cornerPreference, UIWindowShadowPreference shadowPreference, string title = "TCYM.UI", int width = 800, int height = 600, bool enableGpu = true, int targetFps = SDLPlatform.DefaultTargetFps, bool autoShow = true, bool resizable = false, bool? enableMultiThreadedRendering = null)
```

使用彼此独立的原生圆角与外阴影偏好创建窗口。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `cornerPreference` | `UIWindowCornerPreference` | 窗口圆角偏好。 |
| `shadowPreference` | `UIWindowShadowPreference` | 窗口外阴影偏好。 |
| `title` | `string` | 窗口标题。 |
| `width` | `int` | 窗口逻辑宽度（DIP）。 |
| `height` | `int` | 窗口逻辑高度（DIP）。 |
| `enableGpu` | `bool` | 是否启用 GPU 渲染。 |
| `targetFps` | `int` | 目标帧率。 |
| `autoShow` | `bool` | 是否自动显示窗口。 |
| `resizable` | `bool` | 是否允许用户自由调整窗口大小。 |
| `enableMultiThreadedRendering` | `bool?` | 本窗口 CPU/GPU 线程策略；null 继承应用配置（应用出厂默认 true）。 |

**返回：** 创建出的 <see cref="UIWindow"/>。

### MoveElement(string, string, int)

```csharp
bool MoveElement(string childId, string newParentId, int index = -1)
```

将一个元素移动到另一个元素的子级下（在本应用的所有窗口中按 Id 查找）。 <para> 例如：组件 A 的子级中有组件 C，调用 <c>app.MoveElement("C", "B")</c> 可将 C 从 A 中移出并追加到组件 B 的子级末尾。支持跨窗口移动（child 与 newParent 可分属不同窗口）。 </para>

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `childId` | `string` | 要移动的元素 Id。 |
| `newParentId` | `string` | 目标父元素 Id。 |
| `index` | `int` | 在目标父级中的插入位置；小于 0 或超出范围时追加到末尾。 |

**返回：** 移动成功返回 true；任一元素未在任何窗口中找到或移动非法返回 false。

### MoveElement(UIWindow, string, string, int)

```csharp
bool MoveElement(UIWindow window, string childId, string newParentId, int index = -1)
```

将一个元素移动到另一个元素的子级下（在指定窗口内按 Id 查找）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `window` | `UIWindow` | 在其中查找元素的窗口。 |
| `childId` | `string` | 要移动的元素 Id。 |
| `newParentId` | `string` | 目标父元素 Id。 |
| `index` | `int` | 在目标父级中的插入位置；小于 0 或超出范围时追加到末尾。 |

**返回：** 移动成功返回 true；任一元素不存在或移动非法返回 false。

### MoveElement(UIElement, UIElement, int)

```csharp
bool MoveElement(UIElement child, UIElement newParent, int index = -1)
```

将一个元素移动到另一个元素的子级下（直接引用，支持跨窗口）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `child` | `UIElement` | 要移动的元素。 |
| `newParent` | `UIElement` | 目标父元素。 |
| `index` | `int` | 在目标父级中的插入位置；小于 0 或超出范围时追加到末尾。 |

**返回：** 移动成功返回 true；参数为空或移动非法返回 false。

### Run()

```csharp
void Run()
```

启动全局事件循环（阻塞调用）。 <para> 该方法会： <list type="bullet"> <item><description>泵 SDL 事件。</description></item> <item><description>按需 Tick/Render 窗口（空闲时会阻塞等待事件，降低 CPU 占用）。</description></item> <item><description>处理模态窗口输入门控。</description></item> </list> </para> 循环会一直运行直到所有窗口关闭，且最后一批异步关闭生命周期通知完成。

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


---

# UIApp

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 方法

### Run(Action<UIApp>)

```csharp
void Run(Action<UIApp> initialize)
```

在专用逻辑线程初始化并运行多窗口；构造参数false仍使用原调用线程。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `initialize` | `Action<UIApp>` |  |

### Run(, Task>)

```csharp
void Run( Func<UIApp, Task> initialize)
```

支持异步初始化；等待期间继续泵送原生窗口及已创建窗口，不接受async void初始化。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Func<UIApp` | `` |  |
| `initialize` | `Task>` |  |
