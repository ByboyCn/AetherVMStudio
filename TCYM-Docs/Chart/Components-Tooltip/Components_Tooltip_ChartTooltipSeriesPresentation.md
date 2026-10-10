# ChartTooltipSeriesPresentation

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

保存 future series 发布给 Tooltip 的不可变系列身份、视觉和维度 presentation。运行时身份仅在
当前进程用于合并，公开消费者不需要也不能伪造该值。

## 构造函数

### `ChartTooltipSeriesPresentation(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,TCYM.UI.Chart.Rendering.ChartBrush,TCYM.UI.Chart.Rendering.ChartBrush,Collections.Generic.IEnumerable{String},Collections.Generic.IEnumerable{Collections.Generic.KeyValuePair{String,Collections.Generic.IEnumerable{String}}})`

创建已经从系列 option 捕获身份的 presentation。

| 参数 | 说明 |
| --- | --- |
| `series` | 提供 canonical runtime identity 的系列节点。 |
| `seriesIndex` | 当前 effective option 中的系列索引。 |
| `color` | 系列主 marker 画刷。 |
| `borderColor` | 系列 marker 边框画刷。 |
| `dimensionNames` | 系列参与 Tooltip 的稳定维度名称。 |
| `encode` | 系列 encode channel 映射。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `BorderColor` | 获取已快照的系列 marker 边框画刷。 |
| `Color` | 获取已快照的系列主 marker 画刷。 |
| `DimensionNames` | 获取参与 Tooltip 的稳定维度名称。 |
| `Encode` | 获取 encode channel 到维度名集合的不可变映射。 |
| `SeriesId` | 获取系列公开 ID。 |
| `SeriesIndex` | 获取当前系列索引。 |
| `SeriesName` | 获取系列显示名称。 |
| `SeriesType` | 获取系列类型。 |
