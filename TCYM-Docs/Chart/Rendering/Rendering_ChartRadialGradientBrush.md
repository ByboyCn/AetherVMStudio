# ChartRadialGradientBrush

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

使用径向渐变绘制的不可变画刷。

## 构造函数

### `ChartRadialGradientBrush(SkiaSharp.SKPoint,Single,Collections.Generic.IEnumerable{SkiaSharp.SKColor},Collections.Generic.IEnumerable{Single},Boolean)`

创建径向渐变画刷；颜色和位置序列会在构造时复制。

| 参数 | 说明 |
| --- | --- |
| `center` | 渐变中心。 |
| `radius` | 渐变半径。 |
| `colors` | 至少两个渐变颜色。 |
| `offsets` | 可选的颜色位置，数量必须与颜色一致。 |
| `global` | 是否把中心和半径解释为画布绝对值。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Center` | 获取渐变中心。 |
| `Global` | 获取是否使用画布绝对坐标和半径。 |
| `Radius` | 获取渐变半径；相对模式下以图形包围盒最大边长为基准，绝对模式下为像素值。 |
