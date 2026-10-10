# UIInput

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIElement, IKeyboardFocusable, IInputSourceAwareKeyboardFocusable`

## 概述

基本的输入框控件，支持 type、数据绑定、光标闪烁

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `MinLength` | `int` | 最小允许长度（仅用于校验，不强制编辑过程保持长度）。默认0。 |
| `MaxLength` | `int` | 最大允许长度。超过时会被截断或阻止继续输入。默认 Int32.MaxValue。 |
| `IsMinLengthValid` | `bool` | 当前是否通过最小长度校验（Text.Length >= MinLength）。 |
| `ValidationErrorBorderColor` | `SKColor` | 最小长度校验失败时的边框颜色（失焦后显示）。 |
| `OnMinLengthInvalid` | `event Action<int, int>?` | 当最小长度校验失败时触发 (当前长度,需要的最小长度)。 仅在最终校验（如失焦）触发，实时输入时不触发。 |
| `OnMinLengthInvalidAsync` | `event Func<int, int, Task>?` | 输入长度小于最小长度时触发的异步事件。 |
| `Count` | `CountConfig?` | 字符计数配置。设置后可显示字符计数，支持自定义计数策略和超出限制处理。 类似 Ant Design 的 CountConfig。 |
| `CountTextColor` | `SKColor` | 字符计数文本的颜色。 |
| `CountExceedColor` | `SKColor` | 字符计数超出限制时的文本颜色。 |
| `Text` | `string` |  |
| `ReadOnly` | `bool` | 是否为只读。只读时允许获取焦点、移动光标、选择与复制，但不允许修改文本（输入、删除、粘贴、剪切等）。 默认值为 false。 |
| `Disabled` | `bool` | 是否禁用（禁用时不可交互，不可获取焦点）。 |
| `Type` | `UIInputType` | 获取或设置输入框的类型（如文本、数字、密码）。 |
| `PasswordVisible` | `bool` | 密码是否处于明文可见状态（仅 Type=Password 时有效）。 |
| `PasswordVisibilityToggle` | `bool` | 是否显示密码可见性切换图标（仅 Type=Password 时有效）。默认 true。 |
| `PasswordIconColor` | `SKColor` | 密码切换图标的颜色。 |
| `IconFontSize` | `float?` | 输入框字体图标（清除、密码显示/隐藏以及 Prefix/Suffix 中未单独设置字号的 UIIcon）的逻辑字体大小。 显式值会按当前窗口的布局 DPI 缩放；仅提高设备像素比、布局缩放仍为 1 的平台不会重复放大。 未设置或小于等于 0 时动态跟随 <see cref="UIElement.FontSize"/>；Prefix/Suffix 自己的字号优先。 |
| `OnPasswordVisibleChange` | `event Action<bool>?` | 密码可见状态变化时触发。参数为当前是否可见。 |
| `OnPasswordVisibleChangeAsync` | `event Func<bool, Task>?` | 密码可见状态变化时触发的异步事件。 |
| `Prefix` | `UIElement?` | 输入框前缀元素（显示在文本区域左侧内部）。类似 Ant Design 的 prefix。 注意：Prefix 不进入 <see cref="UIElement.Children"/>，但会通过 <c>AttachVirtualParent</c> 维护 <see cref="UIElement.Parent"/> 引用， 以便样式继承、绝对坐标计算与 HitTestGlobal 沿父链工作。 |
| `Suffix` | `UIElement?` | 输入框后缀元素（显示在文本区域右侧内部）。类似 Ant Design 的 suffix。 注意：Suffix 不进入 <see cref="UIElement.Children"/>，但会通过 <c>AttachVirtualParent</c> 维护 <see cref="UIElement.Parent"/> 引用， 以便样式继承、绝对坐标计算与 HitTestGlobal 沿父链工作。 |
| `AllowClear` | `bool` | 是否允许清除输入内容。启用后，当输入框有内容时会显示清除图标。类似 Ant Design 的 allowClear。 |
| `ClearIconColor` | `SKColor` | 清除图标的颜色。 |
| `AbsolutePositionProvider` | `Func<(int x, int y)>?` | 自定义绝对坐标提供器（用于未挂载父子树但需要正确 IME 定位的场景）。 |
| `Placeholder` | `string` | 获取或设置输入框为空时显示的占位文本。 |
| `PlaceholderColor` | `SKColor` | 获取或设置占位文本的颜色。 |
| `SelectionBackgroundColor` | `SKColor` | 获取或设置选中文本的背景颜色。 |
| `ShowCompositionCandidatePopup` | `bool` | 获取或设置是否显示输入法候选词弹窗。 |
| `CompositionPopupBackground` | `SKColor` | 获取或设置输入法候选词弹窗的背景颜色。 |
| `CompositionPopupTextColor` | `SKColor` | 获取或设置输入法候选词弹窗的文本颜色。 |
| `CompositionPopupBorderColor` | `SKColor` | 获取或设置输入法候选词弹窗的边框颜色。 |
| `InputBackground` | `SKColor` | 获取或设置输入框的背景颜色。 |
| `InputTextColor` | `SKColor` |  |
| `InputBorderColor` | `SKColor` | 获取或设置输入框的边框颜色。 |
| `InputBorderTop` | `bool?` | 是否绘制上边框（null 表示沿用 Style/元素当前 BorderTop）。 |
| `InputBorderRight` | `bool?` | 是否绘制右边框（null 表示沿用 Style/元素当前 BorderRight）。 |
| `InputBorderBottom` | `bool?` | 是否绘制下边框（null 表示沿用 Style/元素当前 BorderBottom）。 |
| `InputBorderLeft` | `bool?` | 是否绘制左边框（null 表示沿用 Style/元素当前 BorderLeft）。 |
| `InputBorderTopColor` | `SKColor?` | 上边框颜色（不透明时覆盖当前边框颜色）。 |
| `InputBorderRightColor` | `SKColor?` | 右边框颜色（不透明时覆盖当前边框颜色）。 |
| `InputBorderBottomColor` | `SKColor?` | 下边框颜色（不透明时覆盖当前边框颜色）。 |
| `InputBorderLeftColor` | `SKColor?` | 左边框颜色（不透明时覆盖当前边框颜色）。 |
| `InputFocusBorderColor` | `SKColor` |  |
| `EnableTabletViewportAvoidance` | `bool` | 是否启用平板软键盘视口避让。 启用后，在平板或触摸设备通过真实触摸轻点或编程式聚焦输入框时， 会尝试将输入框滚动到软键盘安全区上方；物理鼠标点击不会移动页面。 |
| `TabletViewportAvoidanceRatio` | `float` | 软键盘预留的视口底部比例。 例如 0.38 表示假定底部约 38% 的高度可能被软键盘遮挡。 |
| `TabletViewportAvoidancePadding` | `float` | 输入框与软键盘安全区之间额外保留的像素间距。 |
| `TabletViewportAvoidanceDuration` | `float` | 聚焦后持续执行视口避让的时长（秒）。 用于覆盖软键盘弹出动画的延迟阶段。 |
| `CursorColor` | `SKColor` | 获取或设置光标的颜色。 |
| `OnFocus` | `event Action?` | 当输入框获得焦点时触发的事件。 |
| `OnFocusAsync` | `event Func<Task>?` | 输入框获得焦点时触发的异步事件。 |
| `OnBlur` | `event Action?` | 当输入框失去焦点时触发的事件。 |
| `OnBlurAsync` | `event Func<Task>?` | 输入框失去焦点时触发的异步事件。 |
| `OnValuesChange` | `event Action<string>?` | 当输入框的值发生变化时触发（包括用户输入与代码设置 Text）。 参数：最新 Text 值。 |
| `OnValuesChangeAsync` | `event Func<string, Task>?` | 输入值变化时触发的异步事件。 |
| `DefaultClassName` | `string` | UIInput 内置默认样式所使用的类名。会自动加入到 <see cref="UIElement.ClassName"/> 列表中， 优先级低于用户显式 <see cref="Style"/> 与其它用户自定义类，从而支持 ClassName / Style 合并覆盖。 |
| `Style` | `UIStyle?` | 元素样式。设置时会与 <see cref="UIElement.ClassName"/> 中匹配的类样式合并， 显式 Style 的同名属性优先于类样式（含内置默认 <see cref="DefaultClassName"/>）。 |

## 方法

### ValidateMinLength(bool)

```csharp
void ValidateMinLength(bool realTime = true)
```

执行最小长度校验。realTime=true 表示在输入过程中，仅更新状态不触发事件； realTime=false 表示在最终校验（如失焦）时，触发事件。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `realTime` | `bool` |  |

### Update(float)

```csharp
void Update(float deltaSeconds)
```

每帧更新输入框的状态，例如光标闪烁。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` |  |

### Render(SKCanvas)

```csharp
void Render(SKCanvas canvas)
```

渲染输入框，包括背景、边框、文本、选区和光标。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `canvas` | `SKCanvas` |  |

### OnPointerDown(float, float)

```csharp
void OnPointerDown(float x, float y)
```

处理鼠标按下事件，用于设置焦点和开始文本选择。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnPointerUp(float, float)

```csharp
void OnPointerUp(float x, float y)
```

处理鼠标松开事件，用于结束文本选择。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnTouchEvent(UITouchEvent)

```csharp
void OnTouchEvent(UITouchEvent e)
```

处理平板触摸事件。在禁用 SDL 触摸转鼠标时，仍然桥接到输入框现有的聚焦、光标和选区逻辑。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UITouchEvent` |  |

### OnMouseEvent(UIMouseEvent)

```csharp
void OnMouseEvent(UIMouseEvent e)
```

处理鼠标事件，主要用于拖动选择和处理鼠标进入/离开。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIMouseEvent` |  |

### Focus()

```csharp
void Focus()
```

使输入框获得焦点。

### Blur()

```csharp
void Blur()
```

使输入框失去焦点。

### ClearCompositionCandidates()

```csharp
void ClearCompositionCandidates()
```

清理输入法候选项列表。

## 相关类型

### CountConfig

> **类型**：类

字符计数配置，类似 Ant Design 的 CountConfig。 example: new CountConfig { Show = true, Max = 100, Strategy = text => text.Length + text.Count(c => char.IsEmoji(c)), // 将 emoji 长度视为 2 ExceedFormatter = (text, max) => text.Substring(0, max) // 超出时截断 }

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Max` | `int?` | 最大字符数。不同于 MaxLength，超出后标红但不会截断（除非设置了 ExceedFormatter）。 |
| `Strategy` | `Func<string, int>?` | 自定义字符计数策略。例如，将 emoji 长度视为 1。 默认使用 string.Length。 |
| `Show` | `bool` | 是否显示字符计数。默认 true。 |
| `ExceedFormatter` | `Func<string, int, string>?` | 当字符数超出 Max 时的自定义裁剪逻辑。不配置时不进行裁剪。 参数：(当前文本, 最大字符数) => 裁剪后的文本。 |

### UIInputType

> **类型**：枚举

Input 的类型

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Text` | - | 普通文本 |
| `Password` | - | 密码隐藏 |
| `Number` | - | 数字输入 |
| `Email` | - | 邮箱 |
| `Search` | - | 搜索框（可扩展） |


---

# UIInput

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`


---

# UIInput

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`


---

# UIInput

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`
