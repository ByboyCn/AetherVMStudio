# UITextArea

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIElement, IKeyboardFocusable`

## 概述

多行文本输入框控件，支持自动换行、垂直滚动、字符计数。 类似 Ant Design 的 TextArea。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Text` | `string` |  |
| `MinLength` | `int` | 最小允许长度（仅用于校验）。默认 0。 |
| `MaxLength` | `int` | 最大允许长度。默认 Int32.MaxValue。 |
| `IsMinLengthValid` | `bool` | 当前是否通过最小长度校验。 |
| `ValidationErrorBorderColor` | `SKColor` | 最小长度校验失败时的边框颜色。 |
| `OnMinLengthInvalid` | `event Action<int, int>?` | 当最小长度校验失败时触发 (当前长度, 需要的最小长度)。 |
| `OnMinLengthInvalidAsync` | `event Func<int, int, Task>?` | 文本长度小于最小长度时触发的异步事件。 |
| `Count` | `CountConfig?` | 字符计数配置。 |
| `CountTextColor` | `SKColor` | 字符计数文本的颜色。 |
| `CountExceedColor` | `SKColor` | 字符计数超出限制时的文本颜色。 |
| `ReadOnly` | `bool` | 是否为只读。 |
| `Disabled` | `bool` | 是否禁用。 |
| `AllowClear` | `bool` | 是否允许清除输入内容。 |
| `ClearIconColor` | `SKColor` | 清除图标的颜色。 |
| `AbsolutePositionProvider` | `Func<(int x, int y)>?` | 自定义绝对坐标提供器。 |
| `Placeholder` | `string` | 占位符文本。 |
| `PlaceholderColor` | `SKColor` | 占位符文本颜色。 |
| `SelectionBackgroundColor` | `SKColor` | 选择背景颜色。 |
| `InputBackground` | `SKColor` |  |
| `InputTextColor` | `SKColor` | 输入框文本颜色。 |
| `InputBorderColor` | `SKColor` | 输入框边框颜色。 |
| `InputFocusBorderColor` | `SKColor` | 输入框聚焦时的边框颜色。 |
| `CursorColor` | `SKColor` | 光标颜色。 |
| `OnFocus` | `event Action?` | 输入内容变化时触发，参数为当前文本内容。 |
| `OnFocusAsync` | `event Func<Task>?` | 文本域获得焦点时触发的异步事件。 |
| `OnBlur` | `event Action?` | 输入内容变化时触发，参数为当前文本内容。 |
| `OnBlurAsync` | `event Func<Task>?` | 文本域失去焦点时触发的异步事件。 |
| `OnValuesChange` | `event Action<string>?` | 输入内容变化时触发，参数为当前文本内容。 |
| `OnValuesChangeAsync` | `event Func<string, Task>?` | 文本值变化时触发的异步事件。 |
| `Rows` | `int` | 可见行数（用于计算默认高度）。默认 4。 |
| `AutoSize` | `bool` | 自动调整高度。设置后高度随内容增长（但不小于 Rows 行高度）。 |
| `Style` | `UIStyle?` | 重写 Style 属性，确保默认样式被正确克隆和应用。更新时合并默认样式和用户设置的样式。 |

## 方法

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

测量阶段处理 AutoSize，避免在 Render 中修改 Height 导致布局抖动。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` |  |
| `availableHeight` | `float` |  |

### ValidateMinLength(bool)

```csharp
void ValidateMinLength(bool realTime = true)
```

验证最小长度是否满足。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `realTime` | `bool` | 是否实时验证。 |

### Update(float)

```csharp
void Update(float deltaSeconds)
```

更新光标闪烁状态。失去焦点时确保光标隐藏并重置 闪烁计时器。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` |  |

### Render(SKCanvas)

```csharp
void Render(SKCanvas canvas)
```

渲染文本区域。包括背景、边框、文本内容、占位符、光标、选择区域和字符计数。根据焦点和校验状态调整样式。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `canvas` | `SKCanvas` |  |

### OnPointerDown(float, float)

```csharp
void OnPointerDown(float x, float y)
```

处理指针按下事件，包括光标定位和清除图标点击。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` | 指针的 X 坐标。 |
| `y` | `float` | 指针的 Y 坐标。 |

### OnPointerUp(float, float)

```csharp
void OnPointerUp(float x, float y)
```

处理指针抬起事件，结束文本选择。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` | 指针的 X 坐标。 |
| `y` | `float` | 指针的 Y 坐标。 |

### OnMouseEvent(UIMouseEvent)

```csharp
void OnMouseEvent(UIMouseEvent e)
```

处理鼠标事件，包括光标移动和清除图标光标变化。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIMouseEvent` | 鼠标事件参数。 |

### HandleScroll(float)

```csharp
void HandleScroll(float deltaY)
```

处理鼠标滚轮事件，用于垂直滚动文本内容。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaY` | `float` |  |

### Focus()

```csharp
void Focus()
```

### Blur()

```csharp
void Blur()
```

取消文本区域的焦点状态，隐藏光标并停止文本输入。

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
