# UICheckbox

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIElement, IDisposable`

## 概述

UICheckbox 复选框组件（中文注释） 功能： - 支持分组（`GroupName`），便于实现全选/半选联动； - 支持禁用（`Disabled`），禁用时不可交互且样式置灰； - 支持半选（`Indeterminate`），用于“部分选中”的视觉表现； - 勾选动画：勾选时有淡入/缩放的简易动画； - 文本标签可配置（`Label`、`LabelColor`、`LabelFont`、`LabelFontSize`）。 渲染：左侧方框（带圆角、边框/填充），右侧文本；点击切换选中状态。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `GroupName` | `string` | 所属分组名（用于全选/半选联动）。为空则不参与分组。 |
| `IsChecked` | `bool` |  |
| `Indeterminate` | `bool` |  |
| `DefaultChecked` | `bool` | 是否默认选中（复选框允许同组多个默认选中）。 |
| `Disabled` | `bool` | 是否禁用（禁用后不可交互并置灰）。 |
| `CheckedChanged` | `event Action<bool, bool>?` | 选中状态变化事件（参数：是否选中、是否半选）。 |
| `CheckedChangedAsync` | `event Func<bool, bool, Task>?` | 选中或不确定状态变化时触发的异步回调。 |
| `OnCheckedChanged` | `Action<bool, bool>?` | 便捷订阅属性：初始化器中设置即可订阅 <see cref="CheckedChanged"/>。 |
| `OnCheckedChangedAsync` | `Func<bool, bool, Task>?` | 选中或不确定状态变化时触发的异步回调。 |
| `Label` | `string?` | 右侧文本标签内容。 |
| `LabelColor` | `SKColor` | 标签颜色（默认与样式的 `Color` 保持一致）。 |
| `LabelFont` | `SKTypeface` | 标签字体。 |
| `LabelFontSize` | `float` | 标签字号（像素，默认与样式 `FontSize` 保持一致）。 |
| `Size` | `float` | 方框尺寸（边长，像素）。 |
| `BorderStroke` | `float` | 边框线宽（像素）。 |
| `CornerRadius` | `float` | 方框圆角半径（像素）。 |
| `BorderColorUnchecked` | `SKColor` | 未选中时的边框颜色。 |
| `BorderColorChecked` | `SKColor` | 选中/半选时的边框颜色。 |
| `BoxColor` | `SKColor` | 方框填充颜色。
方框填充颜色（统一设置，若未设置每态颜色时作为回退）。 |
| `BoxColorUnchecked` | `SKColor` | 未选中时方框填充颜色（默认透明）。 |
| `BoxColorChecked` | `SKColor` | 选中/半选时方框填充颜色（默认透明）。 |
| `CheckColor` | `SKColor` | 勾选或半选条的颜色。 |

## 方法

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

测量

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` | 可用宽度 |
| `availableHeight` | `float` | 可用高度 |

### Update(float)

```csharp
void Update(float deltaSeconds)
```

更新（处理勾选动画）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` | 距离上次更新的时间增量（秒）。 |

### OnMouseEvent(UIMouseEvent)

```csharp
void OnMouseEvent(UIMouseEvent e)
```

鼠标事件：在 Up 时命中则设置为选中。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIMouseEvent` |  |

### Toggle()

```csharp
void Toggle()
```

切换选中状态（在选中/未选中之间切换）。

### SetChecked(bool, bool)

```csharp
void SetChecked(bool value, bool indeterminate = false)
```

设置选中/半选状态。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `bool` | 是否选中。 |
| `indeterminate` | `bool` | 是否半选。 |

### Dispose()

```csharp
void Dispose()
```

释放静态分组登记和控件级事件，避免唯一 GroupName 元数据长期残留。
