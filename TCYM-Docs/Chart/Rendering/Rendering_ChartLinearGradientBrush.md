# ChartLinearGradientBrush

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

使用线性渐变绘制的不可变画刷。

## 构造函数

### `ChartLinearGradientBrush(SkiaSharp.SKPoint,SkiaSharp.SKPoint,Collections.Generic.IEnumerable{SkiaSharp.SKColor},Collections.Generic.IEnumerable{Single},Boolean)`

创建线性渐变画刷；颜色和位置序列会在构造时复制。

| 参数 | 说明 |
| --- | --- |
| `start` | 渐变起点。 |
| `end` | 渐变终点。 |
| `colors` | 至少两个渐变颜色。 |
| `offsets` | 可选的颜色位置，数量必须与颜色一致。 |
| `global` | 是否把起止点解释为画布绝对坐标。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `End` | 获取渐变终点。 |
| `Global` | 获取是否使用画布绝对坐标；否则起止点按 0..1 相对于当前图形包围盒解释。 |
| `Start` | 获取渐变起点。 |
