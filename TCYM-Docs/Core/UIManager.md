# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `CpuRenderMode` | `UICpuRenderMode` | 仅影响窗口 CPU 路径；默认优先工作线程，保留安全回退。必须在所属 UI 线程修改。 |
| `LastCpuRenderStatus` | `UICpuRenderStatus?` | CPU 窗口的排队/呈现/回退诊断，不把排队伪装成绘制成功。 |


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

**继承 / 实现**：`IDisposable`

## 概述

UI 管理器： - 维护根元素与元素注册表（通过 Id 定位元素） - 负责输入事件（鼠标/触摸/键盘）的命中测试与派发 - 管理悬停/捕获/键盘焦点等交互状态 - 调度每帧的测量/布局与渲染（通过脏标记优化重绘） - 统一管理系统光标（SDL 系统光标缓存）

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `LastRenderFrame` | `UIRenderFrameInfo?` | 最近一次成功绘制/提交帧，含离屏 CPU 导出；不是当前窗口呈现状态或 GPU 完成证明。 |
| `CpuBackdropQuality` | `UICpuBackdropQuality` | 当前窗口及其离屏 CPU 帧的背景特效档位；GPU 帧始终使用 Full。 请在 UI 线程设置。只请求重绘，不改 CSS、布局、前景滤镜或阴影。 |
| `Root` | `UIElement` | 根元素（UI 树的根节点）。 |
| `DpiScale` | `float` | DPI 缩放系数（供像素到设备独立单位的换算使用）。 |
| `DevicePixelRatio` | `float` | 当前窗口物理像素与逻辑像素的比例。 |
| `devicePixelRatio` | `UIManager(float dpiScale, float?` | 构造管理器，创建默认根视图并记录 DPI 缩放。 |
| `LastMouseX` | `float` | 获取当前鼠标在窗口坐标系中的位置 X |
| `LastMouseY` | `float` | 记录当前鼠标在窗口坐标系中的位置 Y |
| `HoveredElement` | `UIElement?` | 获取当前悬停的元素（只读）。 供外部组件查询当前悬停状态。 |
| `OnAnyKeyboardEvent` | `event Action<UIKeyboardEvent>?` | 全局键盘事件：在按焦点/根路由前触发，便于全局监听。 |
| `OnAnyKeyboardEventAsync` | `event Func<UIKeyboardEvent, Task>?` | 全局键盘异步事件：在向焦点元素或根元素路由前触发。 |
| `OnAnyJoystickEvent` | `event Action<UIJoystickEvent>?` | 全局摇杆 / 手柄事件。SDL 标准手柄默认同时保留 Joystick 原始流与 Gamepad 标准映射流；可通过 <see cref="SuppressMappedGamepadRawEvents"/> 过滤前者。 |
| `SuppressMappedGamepadRawEvents` | `bool` | 是否过滤 SDL 为标准 Gamepad 同时生成的底层 Joystick 重复事件。 默认为 false，以保留既有的原始与标准双事件流；只需要标准映射时可设为 true。 |
| `ConnectedJoystickDevices` | `IReadOnlyList<UIJoystickDeviceInfo>` | 当前已连接的摇杆 / 手柄设备快照。 标准 Gamepad 与其底层 Joystick 共用实例 ID 时优先返回 Gamepad。 |
| `OnAnyJoystickEventAsync` | `event Func<UIJoystickEvent, Task>?` | 全局摇杆 / 手柄异步事件：在向目标元素分发前触发。 |

## 方法

### RequestRedraw()

```csharp
void RequestRedraw()
```

从外部线程请求 UI 重绘。 这个方法是线程安全的，可以从任何线程调用。

### RequestRedraw(SKRect)

```csharp
void RequestRedraw(SKRect dirtyRect)
```

从外部线程请求局部区域重绘。 仅在没有全量脏标记时保留该矩形；否则自动退回整窗重绘。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `dirtyRect` | `SKRect` |  |

### GetElementById(string)

```csharp
UIElement? GetElementById(string id)
```

通过 Id 获取已注册的元素。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `id` | `string` |  |

### GetElementById(string)

```csharp
T? GetElementById(string id)
```

通过 Id 获取已注册的元素并转换为指定类型。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `id` | `string` |  |

### MoveElement(string, string, int)

```csharp
bool MoveElement(string childId, string newParentId, int index = -1)
```

将一个元素移动到另一个元素的子级下（通过 Id 查找）。 <para> 例如：组件 A 的子级中有组件 C，调用 <c>MoveElement("C", "B")</c> 可将 C 从 A 中移出， 并追加到组件 B 的子级末尾。移动过程中会自动维护父子关系、Manager 注册（含 Id 索引）、 样式重算并触发重新布局与重绘。 </para>

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `childId` | `string` | 要移动的元素 Id。 |
| `newParentId` | `string` | 目标父元素 Id。 |
| `index` | `int` | 在目标父级中的插入位置；小于 0 或超出范围时追加到末尾。 |

**返回：** 移动成功返回 true；任一元素不存在或移动非法（如成环、移动根元素）返回 false。

### MoveElement(UIElement, UIElement, int)

```csharp
bool MoveElement(UIElement child, UIElement newParent, int index = -1)
```

将一个元素移动到另一个元素的子级下（直接引用）。 <para> 目标集合会先校验成环与重复 Id，再以受控移动语义从原父级移除并添加/插入到新父级， 随后重新绑定 Manager、注册 Id、重算后代选择器样式并触发布局与重绘。 </para>

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `child` | `UIElement` | 要移动的元素。 |
| `newParent` | `UIElement` | 目标父元素。 |
| `index` | `int` | 在目标父级中的插入位置；小于 0 或超出范围时追加到末尾。 |

**返回：** 移动成功返回 true；参数为空或移动非法（如自身、成环、移动根元素）返回 false。

### ResetForPreviewTreeRebuild(UIElement?)

```csharp
void ResetForPreviewTreeRebuild(UIElement? preservedRoot = null)
```

为预览宿主重建 UI 树前清理元素注册表和悬挂的交互状态。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `preservedRoot` | `UIElement?` |  |

### ClearPreviewRegistrationsForTree(UIElement?)

```csharp
void ClearPreviewRegistrationsForTree(UIElement? element)
```

为预览宿主的局部热替换清理即将挂载子树使用的 Id 注册。 仅按 Id 删除，不要求现有注册实例与传入子树是同一对象。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `element` | `UIElement?` |  |

### NotifyElementStyleChanged(UIElement)

```csharp
void NotifyElementStyleChanged(UIElement element)
```

通知管理器某个元素的样式已被外部修改。 如果该元素是当前悬停元素，则需要重新同步悬停状态。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `element` | `UIElement` | 样式被修改的元素 |

### ClearHoverForElement(UIElement?)

```csharp
void ClearHoverForElement(UIElement? element)
```

强制清除指定元素的悬停状态。 当元素被移除、隐藏或需要重置状态时调用。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `element` | `UIElement?` | 要清除悬停状态的元素 |

### RefreshHoverState()

```csharp
void RefreshHoverState()
```

刷新当前悬停元素的状态。 当悬停元素的样式被外部修改后，调用此方法重新应用悬停样式。

### SetActiveOverlay(UIElement?, , , bool>, Action)

```csharp
void SetActiveOverlay(UIElement? overlay,  Func<float,  float, bool> isInside, Action onOutsideClick)
```

Register an active overlay element. When pointer down happens outside overlay content, <paramref name="onOutsideClick"/> will be invoked.

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `overlay` | `UIElement?` |  |
| `Func<float` | `` |  |
| `float` | `` |  |
| `isInside` | `bool>` |  |
| `onOutsideClick` | `Action` |  |

### ClearActiveOverlay(UIElement?)

```csharp
void ClearActiveOverlay(UIElement? overlay)
```

Clear active overlay registration.

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `overlay` | `UIElement?` |  |

### DispatchMouseEvent(UIMouseEvent)

```csharp
void DispatchMouseEvent(UIMouseEvent e)
```

将鼠标事件（SDL 转换后）派发给命中的顶层元素。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIMouseEvent` |  |

### DispatchJoystickEvent(Events.UIJoystickEvent)

```csharp
void DispatchJoystickEvent(Events.UIJoystickEvent e)
```

笔（触控笔）事件派发：命中测试定位目标元素，并沿父链冒泡直到被处理（SDL3 新增能力）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `Events.UIJoystickEvent` | 笔事件。 |

### DispatchPenEvent(Events.UIPenEvent)

```csharp
void DispatchPenEvent(Events.UIPenEvent e)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `Events.UIPenEvent` |  |

### DispatchFileDrop(Events.UIFileDropEvent)

```csharp
void DispatchFileDrop(Events.UIFileDropEvent e)
```

文件 / 文本拖放事件派发：命中测试定位落点元素，并沿父链冒泡直到被处理（SDL3 增强）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `Events.UIFileDropEvent` | 拖放事件。 |

### DispatchKeyboardEvent(Events.UIKeyboardEvent)

```csharp
void DispatchKeyboardEvent(Events.UIKeyboardEvent e)
```

按键事件路由：优先发送给当前键盘焦点元素，否则发送给根元素。 同时会在路由前触发全局键盘事件回调。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `Events.UIKeyboardEvent` |  |

### DispatchTouchEvent(UITouchEvent)

```csharp
void DispatchTouchEvent(UITouchEvent e)
```

触摸事件派发：支持多点触控，按触点 Id 维护捕获并分组派发到目标元素。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UITouchEvent` |  |

### Initialize()

```csharp
void Initialize()
```

初始化渲染器与默认光标。

### SetRenderSize(int, int)

```csharp
void SetRenderSize(int width, int height)
```

设置渲染尺寸，并标记需要重绘。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `width` | `int` |  |
| `height` | `int` |  |

### SetRoot(UIElement)

```csharp
void SetRoot(UIElement root)
```

替换根元素并建立管理器引用。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `root` | `UIElement` |  |

### Update(float)

```csharp
void Update(float deltaTime)
```

每帧更新： - 执行测量与布局 - 更新悬停去抖逻辑（按延迟提交 Enter/Leave） - 如果有动画在进行，则保持脏标记以持续重绘

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaTime` | `float` |  |

### RenderImage()

```csharp
SKImage? RenderImage()
```

渲染到 SKImage（CPU 路径）。

### HitTest(float, float, bool)

```csharp
UIElement? HitTest(float x, float y, bool includeObscured = false)
```

命中测试：返回位于 (x,y) 处的最上层元素（考虑 ZIndex 和渲染遮挡）。 遮挡只考虑按下，抬起，移动、移动端 OnTouchStart、OnTouchMove、OnTouchEnd 事件的命中测试。 OnMouseEnter、OnMouseLeave 事件不考虑遮挡。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` | x |
| `y` | `float` | y |
| `includeObscured` | `bool` | 是否包含被遮挡的元素 |

### PointerDown(float, float)

```csharp
void PointerDown(float x, float y)
```

指针按下：命中元素后建立捕获、更新键盘焦点并派发对应事件。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### PointerUp(float, float)

```csharp
void PointerUp(float x, float y)
```

指针弹起：向捕获或命中元素派发 Up，并维护键盘焦点与光标。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### PointerDown(float, float, UIMouseButton)

```csharp
void PointerDown(float x, float y, UIMouseButton button)
```

指针按下：命中元素、设置捕获、更新键盘焦点并分发带按钮信息的 MouseDown。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |
| `button` | `UIMouseButton` |  |

### PointerDown(float, float, UIMouseButton, UIKeyModifiers)

```csharp
void PointerDown(float x, float y, UIMouseButton button, UIKeyModifiers modifiers)
```

指针按下：命中元素、设置捕获、更新键盘焦点，并保留平台采样到的修饰键状态。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` | 窗口坐标系横坐标。 |
| `y` | `float` | 窗口坐标系纵坐标。 |
| `button` | `UIMouseButton` | 触发按下的鼠标按键。 |
| `modifiers` | `UIKeyModifiers` | 事件发生时的键盘修饰键。 |

### PointerUp(float, float, UIMouseButton)

```csharp
void PointerUp(float x, float y, UIMouseButton button)
```

指针抬起：按捕获目标或命中目标分发带按钮信息的 MouseUp。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |
| `button` | `UIMouseButton` |  |

### PointerUp(float, float, UIMouseButton, UIKeyModifiers)

```csharp
void PointerUp(float x, float y, UIMouseButton button, UIKeyModifiers modifiers)
```

指针抬起：按捕获或命中目标分发 MouseUp，并保留平台采样到的修饰键状态。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` | 窗口坐标系横坐标。 |
| `y` | `float` | 窗口坐标系纵坐标。 |
| `button` | `UIMouseButton` | 触发抬起的鼠标按键。 |
| `modifiers` | `UIKeyModifiers` | 事件发生时的键盘修饰键。 |

### PointerMove(float, float)

```csharp
void PointerMove(float x, float y)
```

指针移动：无捕获时处理 hover逻辑和 Enter/Leave，捕获时将 Move 路由给捕获元素。 有捕获时，Move 路由给捕获元素且保持其光标。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### PointerMove(float, float, UIKeyModifiers)

```csharp
void PointerMove(float x, float y, UIKeyModifiers modifiers)
```

指针移动：在既有捕获与 hover 路由规则下保留平台采样到的修饰键状态。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` | 窗口坐标系横坐标。 |
| `y` | `float` | 窗口坐标系纵坐标。 |
| `modifiers` | `UIKeyModifiers` | 事件发生时的键盘修饰键。 |

### NeedsRedraw()

```csharp
bool NeedsRedraw()
```

是否需要重绘（供渲染器查询）。

### MarkDirty()

```csharp
void MarkDirty()
```

标记需要重绘。

### MarkDirty(SKRect)

```csharp
void MarkDirty(SKRect dirtyRect)
```

标记一个局部区域需要重绘。 若当前帧已经被升级为整窗脏标记，则忽略该局部矩形。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `dirtyRect` | `SKRect` |  |

### ClearDirty()

```csharp
void ClearDirty()
```

清除重绘标记。

### ClearKeyboardFocus()

```csharp
void ClearKeyboardFocus()
```

清除当前键盘焦点（若为输入框则触发 Blur）。

### ResetInteractionForFocusLost()

```csharp
void ResetInteractionForFocusLost()
```

窗口失去焦点时重置交互状态： - 释放指针捕获 - 清除悬停与键盘焦点 - 向触摸捕获目标发送取消并清空捕获 - 重置第一帧移动标记

### Dispose()

```csharp
void Dispose()
```

释放元素树、渲染器及管理器持有的索引和脏区状态。任一资源释放失败时仍会继续清理 其余资源，并在管理器状态完成收口后把全部异常聚合返回给调用方。

### SetKeyboardFocusAt(int, int)

```csharp
void SetKeyboardFocusAt(int x, int y)
```

根据窗口坐标设置键盘焦点到命中元素（若有）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `int` |  |
| `y` | `int` |  |

### SetKeyboardFocus(UIElement?)

```csharp
void SetKeyboardFocus(UIElement? el)
```

直接设置键盘焦点到指定元素。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `el` | `UIElement?` |  |

### PointerLeave()

```csharp
void PointerLeave()
```

鼠标指针离开窗口：立即清除 pending 与已应用的悬停状态并重置光标。


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `GpuRenderMode` | `UIGpuRenderMode` | GPU 默认优先工作线程；不支持的平台/资源会明确回退，设置仅允许在所属 UI 线程进行。 |
| `LastGpuRenderStatus` | `UIGpuRenderStatus?` | 区分真实工作线程绘制与同步回退，不以请求模式代替执行结果。 |
| `RenderBackendStatus` | `UIRenderBackendStatus?` | 窗口的实际后端选择，不以请求值或线程开关代替执行结果。 |


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 方法

### SetMultiThreadedRendering(bool)

```csharp
void SetMultiThreadedRendering(bool enabled)
```

同时请求启用/关闭 CPU 与 GPU 工作线程；下一帧按原有兼容和资源交接规则应用。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `enabled` | `bool` | true 为优先工作线程，false 为 UI 线程；不改变是否启用 GPU。 |


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `SelectedText` | `string` | 按元素文本流顺序读取当前窗口选中文字，标签之间以换行分隔；拖动期间不主动拼接字符串。 |


---

# UIManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`
