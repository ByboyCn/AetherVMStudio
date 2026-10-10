# ChartLabelLayoutParameters

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Components.Label`　**Chart 版本**：`0.1.1.25`

## 概述

传递给受控 labelLayout callback 的不可变标签几何快照。

## 构造函数

### `ChartLabelLayoutParameters(String,String,String,Int32,Int32,Int32,SkiaSharp.SKRect,SkiaSharp.SKPoint,Single)`

传递给受控 labelLayout callback 的不可变标签几何快照。

| 参数 | 说明 |
| --- | --- |
| `Id` | 标签在所属 view 内的稳定标识。 |
| `ComponentType` | 可选组件主类型。 |
| `SeriesType` | 可选系列子类型。 |
| `SeriesIndex` | 系列索引；非系列标签为 -1。 |
| `DataIndex` | 原始数据索引；非数据标签为 -1。 |
| `DataIndexInside` | 系列公开 presentation 索引；非数据标签为 -1。 |
| `TextBounds` | 执行 callback 前、已经包含旋转的图表坐标轴对齐边界。 |
| `AnchorPoint` | 锚点解析出的标签原点。 |
| `Rotation` | 执行 callback 前的顺时针旋转角度。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AnchorPoint` | 锚点解析出的标签原点。 |
| `ComponentType` | 可选组件主类型。 |
| `DataIndex` | 原始数据索引；非数据标签为 -1。 |
| `DataIndexInside` | 系列公开 presentation 索引；非数据标签为 -1。 |
| `Id` | 标签在所属 view 内的稳定标识。 |
| `Rotation` | 执行 callback 前的顺时针旋转角度。 |
| `SeriesIndex` | 系列索引；非系列标签为 -1。 |
| `SeriesType` | 可选系列子类型。 |
| `TextBounds` | 执行 callback 前、已经包含旋转的图表坐标轴对齐边界。 |
