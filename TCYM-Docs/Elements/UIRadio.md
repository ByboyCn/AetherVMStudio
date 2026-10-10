# UIRadio

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIElement, IDisposable`

## 概述

UIRadio 单选框组件 - 支持分组互斥选择（GroupName） - 点击切换选中状态（IsChecked） - 提供选中状态变化事件（CheckedChanged/OnCheckedChanged） - 文本标签与样式联动（颜色/字号与 Style 保持一致） - 尺寸由内容撑开（重写 Measure）

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `GroupName` | `string` | 所属分组名（同组互斥）。为空则不参与分组。 |
| `IsChecked` | `bool` |  |
| `Disabled` | `bool` | 是否禁用（禁用时不可交互）。 |
| `DefaultChecked` | `bool` | 是否默认选中（同组仅允许一个默认选中）。 |
| `CheckedChanged` | `event Action<bool>?` | 选中状态变化事件（参数为最新选中状态）。 |
| `CheckedChangedAsync` | `event Func<bool, Task>?` | 单选框选中状态变化时触发的异步回调。 |
| `OnCheckedChanged` | `Action<bool>?` | 便捷属性：在对象初始化器中设置该属性即可订阅 CheckedChanged 事件。 例如： new UIRadio { OnCheckedChanged = b => { ... } } |
| `OnCheckedChangedAsync` | `Func<bool, Task>?` | 单选框选中状态变化时触发的异步回调。 |
| `Label` | `string?` | 文本标签（可选，绘制在圆圈右侧）。 |
| `LabelColor` | `SKColor` | 标签颜色（默认与 Style.Color 保持一致）。 |
| `LabelFont` | `SKTypeface` | 标签字体。 |
| `LabelFontSize` | `float` | 标签字号（像素，默认与 Style.FontSize 保持一致）。 |
| `Radius` | `float` | 圆圈半径。 |
| `CircleStroke` | `float` | 圆圈线宽。 |
| `CircleBorderColor` | `SKColor` | 圆圈边框颜色（未选中）。 |
| `CircleCheckedBorderColor` | `SKColor` | 圆圈边框颜色（选中）。 |
| `CircleCheckedStroke` | `float` | 选中时圆圈线宽。 |
| `RenderCircle` | `bool` | 是否渲染圆圈（为 false 时仅显示文本）。 |
| `DotRadiusFactor` | `float` | 选中点半径系数（相对 Radius）。 |
| `CircleColor` | `SKColor` | 未选中时圆圈颜色。 |
| `CheckedColor` | `SKColor` | 选中颜色（圆圈与内点）。 |
| `CheckedStyle` | `DefaultUIStyle?` | 选中态样式（可选）：选中时覆盖颜色/字号/边框等视觉。 |

## 方法

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

计算控件尺寸：由圆圈和文本内容撑开。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` | 可用宽度 |
| `availableHeight` | `float` | 可用高度 |

### OnMouseEvent(UIMouseEvent)

```csharp
void OnMouseEvent(UIMouseEvent e)
```

鼠标事件：在 Up 时命中则设置为选中。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIMouseEvent` |  |

### SetChecked(bool)

```csharp
void SetChecked(bool value)
```

设置选中状态；若为 true，取消同组其他选中项并触发事件。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `bool` |  |

### Dispose()

```csharp
void Dispose()
```

释放静态分组登记和控件级事件，避免唯一 GroupName 元数据长期残留。

### Render(SKCanvas)

```csharp
void Render(SKCanvas canvas)
```

渲染控件：绘制圆圈/内点以及右侧标签文本。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `canvas` | `SKCanvas` |  |
