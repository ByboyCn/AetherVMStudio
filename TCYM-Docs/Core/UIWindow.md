# UIWindow

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

原生窗口封装。 <para> <see cref="UIWindow"/> 负责： <list type="bullet"> <item><description>持有平台窗口（SDL）与渲染平台（<see cref="SDLPlatform"/>）。</description></item> <item><description>持有窗口级 UI 树管理器（<see cref="UIManager"/>）。</description></item> <item><description>处理 SDL 事件并转换为 UI 事件（鼠标/键盘/触摸）。</description></item> <item><description>驱动每帧更新与渲染（<see cref="Tick"/>）。</description></item> <item><description>提供模态对话框（<see cref="ShowDialogAsync{T}"/>）能力。</description></item> </list> </para>

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Manager` | `UIManager` | 窗口的 UI 管理器（根元素、布局、命中测试、事件派发、脏标记等）。 |
| `IsClosed` | `bool` | 窗口是否已关闭。 |
| `Closing` | `event EventHandler<UIWindowClosingEventArgs>?` | 窗口即将关闭时触发（类似 Avalonia 的 <c>Window.Closing</c>）。 将 <see cref="UIWindowClosingEventArgs.Cancel"/> 设为 <see langword="true"/> 可阻止关闭。 |
| `ClosingAsync` | `event Func<object?, UIWindowClosingEventArgs, Task>?` | 窗口关闭前的异步门控事件。处理器可以在等待完成后设置 <see cref="UIWindowClosingEventArgs.Cancel"/>，框架会在所有订阅者完成后再决定是否关闭。 任一处理器取消或失败时，本次关闭按失败处理并保持窗口打开。 |
| `Closed` | `event EventHandler?` | 窗口已关闭后触发（类似 Avalonia 的 <c>Window.Closed</c>）。 |
| `ClosedAsync` | `event Func<object?, EventArgs, Task>?` | 窗口已关闭后触发的异步通知。关闭最后一个 <see cref="UIApp"/> 窗口时， 应用事件循环会继续泵送 UI 调度器，直到该通知完成。 |
| `InputEnabled` | `bool` | 是否启用输入。 <para> 当存在模态窗口时，其它窗口会被 <see cref="UIApp"/> 设置为 <c>false</c>，以达到“模态阻塞”的效果。 </para> |
| `Resizable` | `bool` | 是否允许用户自由调整窗口大小（类似 Electron 的 resizable）。 <para> 启用后可拖动窗口边缘/角调整大小；最大化或全屏状态下自动禁用边缘缩放。 可在运行时随时切换。 </para> |
| `IsCornerPreferenceSupported` | `bool` | 当前平台是否支持显式窗口圆角偏好。 Windows 10 及更高版本返回 true；其它平台保留各自的默认窗口外观。 |
| `CornerPreference` | `UIWindowCornerPreference` | 获取或设置该窗口的圆角偏好。 最大化或全屏期间框架会临时使用直角，恢复后自动重新应用此值。 |
| `IsShadowPreferenceSupported` | `bool` | 当前平台是否支持提交窗口阴影策略。 Windows 10 返回 true；接受请求不等于保证阴影可见。 |
| `ShadowPreference` | `UIWindowShadowPreference` | 获取或设置该窗口的外阴影偏好。Enabled/Disabled 与 <see cref="CornerPreference"/> 相互独立；Default 在圆角窗口上自动请求系统阴影。 |

## 方法

### Show()

```csharp
void Show()
```

显示原生窗口。 <para> 窗口内容构建完成后调用；分离模式先提交完整当前帧，再显示原生窗口。 </para>

### SetMultiThreadedRendering(bool)

```csharp
void SetMultiThreadedRendering(bool enabled)
```

在所属 UI 线程同时切换本窗口的 CPU/GPU 线程策略，下一帧按安全交接规则应用。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `enabled` | `bool` | true 为优先工作线程，false 为 UI 线程；不影响其他窗口。 |

### Close()

```csharp
void Close()
```

关闭窗口并释放平台资源。 <para> 若该窗口正在以对话框方式显示（<see cref="ShowDialogAsync{T}"/>），会尝试取消该对话框任务。 </para>

### CloseAsync()

```csharp
Task<bool> CloseAsync()
```

异步请求关闭窗口。同步和异步 <see cref="Closing"/> 门控均完成且未取消时才提交关闭。

**返回：** 实际关闭返回 <see langword="true"/>；已关闭、正在关闭或被取消返回 <see langword="false"/>。

### ShowDialogAsync()

```csharp
Task<T?> ShowDialogAsync()
```

以模态对话框方式显示该窗口，并异步等待结果。 <para> 进入模态后，<see cref="UIApp"/> 会禁用其它窗口输入，仅允许该窗口接收输入事件。 通过 <see cref="CompleteDialog{T}"/> 结束对话框并返回结果。 </para>

**返回：** 对话框完成时返回的结果。

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

### CompleteDialog(T?)

```csharp
void CompleteDialog(T? result)
```

完成对话框并返回结果，然后自动退出模态并关闭窗口。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `result` | `T?` | 返回结果。 |


---

# UIWindow

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 方法

### SetWindowTitle(string)

```csharp
void SetWindowTitle(string title)
```

在窗口所属原生线程设置标题。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `title` | `string` |  |

### SetWindowSize(int, int)

```csharp
void SetWindowSize(int width, int height)
```

以当前中心调整本窗口DIP尺寸，分离模式返回前同步UI度量。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `width` | `int` |  |
| `height` | `int` |  |

### MinimizeWindow()

```csharp
void MinimizeWindow()
```

最小化此窗口，不依赖全局主窗口绑定。

### ToggleMaximizeWindow()

```csharp
void ToggleMaximizeWindow()
```

切换此窗口的最大化状态。

### SetWindowFullscreen(bool)

```csharp
void SetWindowFullscreen(bool fullscreen)
```

设置此窗口全屏状态。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `fullscreen` | `bool` |  |
