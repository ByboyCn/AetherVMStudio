# ChartLegendVisualStyle

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Visual`　**Chart 版本**：`0.1.1.25`

## 概述

保存 Legend 图标或线段使用的不可变视觉。画刷按公共画刷契约快照，虚线数组也与调用方集合隔离。

## 构造函数

### `ChartLegendVisualStyle(TCYM.UI.Chart.Rendering.ChartBrush,TCYM.UI.Chart.Rendering.ChartBrush,Single,Single,Collections.Generic.IEnumerable{Single})`

创建不可变 Legend 视觉。

| 参数 | 说明 |
| --- | --- |
| `fill` | 可选填充画刷。 |
| `stroke` | 可选描边画刷。 |
| `width` | 有限非负描边宽度。 |
| `opacity` | 零到一之间的有限透明度。 |
| `lineDash` | 可选有限正数虚线长度序列。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Empty` | 获取没有画刷、线宽、虚线且完全不透明的共享空视觉。 |
| `Fill` | 获取已经快照隔离的填充画刷。 |
| `LineDash` | 获取只读虚线长度快照；实线时为 `null`。 |
| `Opacity` | 获取零到一之间的透明度。 |
| `Stroke` | 获取已经快照隔离的描边画刷。 |
| `Width` | 获取有限非负描边宽度。 |
