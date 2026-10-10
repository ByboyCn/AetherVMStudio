# UITimePicker

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView, IKeyboardFocusable, IDisposable, IUIElementDisposalPreflight`

## 概述

Ant Design 风格的时间选择框。支持 24/12 小时制、格式化、时分秒步长、 禁用选项、确认模式、清空、此刻、尺寸、变体和受控打开状态。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `RootClassName` | `string` | 根元素建议使用的语义 CSS 类名。 |
| `TriggerClassName` | `string` | 触发器正文的语义 CSS 类名。 |
| `PopupClassName` | `string` | 弹出面板的语义 CSS 类名。 |
| `ColumnsClassName` | `string` | 时间列容器的语义 CSS 类名。 |
| `ColumnClassName` | `string` | 单个时间列的语义 CSS 类名。 |
| `OptionClassName` | `string` | 时间选项的语义 CSS 类名。 |
| `SelectedOptionClassName` | `string` | 选中时间选项的语义 CSS 类名。 |
| `DisabledOptionClassName` | `string` | 禁用时间选项的语义 CSS 类名。 |
| `FooterClassName` | `string` | 面板底部区域的语义 CSS 类名。 |
| `ConfirmClassName` | `string` | 确认按钮的语义 CSS 类名。 |
| `Style` | `UIStyle?` | 元素样式。赋值 <see cref="UpdateUIStyle"/> 时在当前 TimePicker 默认/状态样式上增量合并， 避免只设置宽度等单个字段时丢失触发器的基础布局。 |
| `Value` | `TimeSpan?` |  |
| `DefaultValue` | `TimeSpan?` | 调用方未显式设置 <see cref="Value"/> 时使用的初始时间。 |
| `FormattedValue` | `string` | 当前值按 <see cref="Format"/> 格式化后的文本；没有值时为空字符串。 |
| `Format` | `string` | .NET 时间格式字符串。24 小时制默认 HH:mm:ss，12 小时制默认 hh:mm:ss tt。 |
| `Use12Hours` | `bool` | 是否使用 12 小时制并显示 AM/PM 列。 |
| `HourStep` | `int` | 小时选项间隔，范围 1 到 23。 |
| `MinuteStep` | `int` | 分钟选项间隔，范围 1 到 59。 |
| `SecondStep` | `int` | 秒选项间隔，范围 1 到 59。 |
| `DisabledHour` | `Func<int, bool>?` | 返回 true 时禁用对应小时（0 到 23）。 |
| `DisabledMinute` | `Func<int, int, bool>?` | 返回 true 时禁用指定小时下的分钟。 |
| `DisabledSecond` | `Func<int, int, int, bool>?` | 返回 true 时禁用指定小时、分钟下的秒。 |
| `DisabledTime` | `Func<TimeSpan, bool>?` | 返回 true 时禁用完整时间值。 |
| `HideDisabledOptions` | `bool` | 是否从面板中隐藏禁用选项；默认仅置灰。 |
| `AllowClear` | `bool` | 是否允许清空当前时间。 |
| `ShowNow` | `bool` | 是否在面板底部显示“此刻”。 |
| `NeedConfirm` | `bool` | 是否需要点击确定后才提交选择。关闭后，点击任意有效选项即更新 Value。 |
| `Disabled` | `bool` | 是否禁用全部交互。 |
| `Size` | `TimePickerSize` | 触发器尺寸。 |
| `Variant` | `TimePickerVariant` | 触发器视觉变体。 |
| `Status` | `TimePickerStatus` | 触发器校验状态。 |
| `Placement` | `TimePickerPlacement` | 面板弹出位置。 |
| `Placeholder` | `string` | 没有值时显示的占位文本。 |
| `PlaceholderColor` | `SKColor` | 占位文本颜色。 |
| `PrefixText` | `string?` | 触发器前缀文本；为空时隐藏。 |
| `SuffixIcon` | `string` | 触发器后缀图标内容，默认使用 TCYMIconFont 的时间图标。 |
| `AMText` | `string` | 12 小时制的上午文本。 |
| `PMText` | `string` | 12 小时制的下午文本。 |
| `Open` | `bool` |  |
| `DestroyOnHidden` | `bool` | 关闭面板后是否销毁弹层子树。 |
| `PopupStyle` | `UIStyle?` | 面板附加样式。宽高由当前可见列和底部区域自动计算。 |
| `RenderExtraFooter` | `Func<UIElement>?` | 自定义底部附加内容。委托应在每次调用时返回可挂载的元素。 |
| `ExtraFooterHeight` | `float` | 自定义底部附加内容预留高度，默认 36px。 |
| `OnChange` | `Action<TimeSpan?>?` | 用户提交新值或清空时触发。 |
| `OnChangeAsync` | `Func<TimeSpan?, Task>?` | 用户提交新值或清空时触发的异步回调。 |
| `OnSelect` | `Action<TimeSpan?>?` | 面板内的待选值变化时触发；确认模式下早于 OnChange。 |
| `OnSelectAsync` | `Func<TimeSpan?, Task>?` | 面板内待选值变化时触发的异步回调。 |
| `OnOk` | `Action<TimeSpan?>?` | 用户点击确定时触发。 |
| `OnOkAsync` | `Func<TimeSpan?, Task>?` | 用户点击确定时触发的异步回调。 |
| `OnOpenChange` | `Action<bool>?` | 面板打开状态变化时触发。 |
| `OnOpenChangeAsync` | `Func<bool, Task>?` | 面板打开状态变化时触发的异步回调。 |
| `OnClear` | `Action?` | 用户点击清空按钮时触发。 |
| `OnClearAsync` | `Func<Task>?` | 用户点击清空按钮时触发的异步回调。 |
| `OnFocus` | `Action?` | 组件获得焦点时触发。 |
| `OnFocusAsync` | `Func<Task>?` | 组件获得焦点时触发的异步回调。 |
| `OnBlur` | `Action?` | 组件失去焦点时触发。 |
| `OnBlurAsync` | `Func<Task>?` | 组件失去焦点时触发的异步回调。 |

## 方法

### FormatTime(TimeSpan?)

```csharp
string FormatTime(TimeSpan? value)
```

按当前 Format 格式化指定时间。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `TimeSpan?` | 一天内时间；null 返回空字符串。 |

### Focus()

```csharp
void Focus()
```

使时间选择框获得焦点。

### Blur()

```csharp
void Blur()
```

使时间选择框失去焦点并关闭面板。

### Clear()

```csharp
void Clear()
```

清空当前时间。

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` |  |
| `availableHeight` | `float` |  |

### Layout(float, float, float, float)

```csharp
void Layout(float x, float y, float width, float height)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |
| `width` | `float` |  |
| `height` | `float` |  |

### Update(float)

```csharp
void Update(float deltaTime)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaTime` | `float` |  |

### VerifyCanDispose()

```csharp
void VerifyCanDispose()
```

无副作用地验证挂载在 Root 上的时间面板子树允许拥有型释放。

### Dispose()

```csharp
void Dispose()
```

## 相关类型

### TimePickerPlacement

> **类型**：枚举

时间面板相对触发器的弹出位置。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `BottomLeft` | - | 面板位于触发器下方并左对齐。 |
| `BottomRight` | - | 面板位于触发器下方并右对齐。 |
| `TopLeft` | - | 面板位于触发器上方并左对齐。 |
| `TopRight` | - | 面板位于触发器上方并右对齐。 |

### TimePickerSize

> **类型**：枚举

时间选择框尺寸。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Small` | - | 小尺寸，高度 24px。 |
| `Medium` | - | 中等尺寸，高度 32px。 |
| `Large` | - | 大尺寸，高度 40px。 |

### TimePickerStatus

> **类型**：枚举

时间选择框校验状态。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `None` | - | 普通状态。 |
| `Error` | - | 错误状态。 |
| `Warning` | - | 警告状态。 |

### TimePickerVariant

> **类型**：枚举

时间选择框视觉变体。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Outlined` | - | 带完整边框的默认样式。 |
| `Borderless` | - | 无边框样式。 |
| `Filled` | - | 填充背景样式。 |
| `Underlined` | - | 仅显示下边框。 |
