# ChartBrushSelectedSeriesEventItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Brush`　**Chart 版本**：`0.1.1.25`

## 概述

保存 brushselected 中一个系列的稳定身份和原始数据索引。

## 构造函数

### `ChartBrushSelectedSeriesEventItem(String,String,Int32,Collections.Generic.IEnumerable{Int32})`

创建并冻结一个系列选择结果。

| 参数 | 说明 |
| --- | --- |
| `seriesId` | 系列可选 ID。 |
| `seriesName` | 系列可选名称。 |
| `seriesIndex` | 系列有效索引。 |
| `dataIndices` | 按当前数据顺序排列的唯一非负 RawIndex。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataIndices` | 获取选中项的原始数据索引，而不是过滤后的 InsideIndex。 |
| `SeriesId` | 获取系列可选 ID。 |
| `SeriesIndex` | 获取系列当前有效索引。 |
| `SeriesName` | 获取系列可选名称。 |
