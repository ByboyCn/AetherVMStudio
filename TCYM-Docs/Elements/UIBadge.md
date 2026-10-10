# UIBadge

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

Badge 徽标组件，支持数字徽标、红点、状态点、封顶数、偏移和独立使用。 设计参考 Ant Design Badge 的核心交互，并提供 Ribbon 缎带子组件。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Count` | `int?` | 数字计数值。 |
| `CountText` | `string?` | 自定义计数字符串，适合展示如 NEW、HOT 等文本。 |
| `Dot` | `bool` | 是否显示纯圆点模式。 |
| `ShowZero` | `bool` | 当 Count 为 0 时是否仍显示徽标。 |
| `OverflowCount` | `int` | 数字显示的封顶值，超出后显示为“{OverflowCount}+”。 |
| `Size` | `BadgeSize` | 数字徽标尺寸。 |
| `Status` | `BadgeStatus` | 状态点模式。 |
| `StatusText` | `string` | 状态点右侧文本。 |
| `BadgeColor` | `SKColor?` | 徽标颜色；未设置时使用默认红色或状态色。 |
| `OffsetX` | `float` | 水平方向偏移量（逻辑像素）。 |
| `OffsetY` | `float` | 垂直方向偏移量（逻辑像素）。 |
| `ShowOutline` | `bool` | 是否显示徽标描边。 |
| `OutlineColor` | `SKColor` | 徽标描边颜色。 |
| `OutlineWidth` | `float` | 徽标描边宽度（逻辑像素）。 |

## 方法

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

测量 Badge 尺寸。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` | 可用宽度。 |
| `availableHeight` | `float` | 可用高度。 |

## 相关类型

### BadgeSize

> **类型**：枚举

Badge 指示器尺寸。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Default` | - | 默认尺寸。 |
| `Small` | - | 小号尺寸。 |

### BadgeStatus

> **类型**：枚举

Badge 状态点类型。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `None` | - | 无状态模式。 |
| `Success` | - | 成功状态。 |
| `Processing` | - | 处理中状态。 |
| `Default` | - | 默认状态。 |
| `Error` | - | 错误状态。 |
| `Warning` | - | 警告状态。 |


---

# UIBadge

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `IDisposable` | `class Ribbon : UIView,` | 包裹内容并在其顶部绘制缎带徽标，使用方式类似 Ant Design Badge.Ribbon。 |
