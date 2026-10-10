# ChartTooltipFormatterParameters

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

保存与 ECharts CallbackDataParams 对齐的不可变 formatter 参数。构造时复制维度、encode、axis、
template variables，并快照画刷与原始领域数据。

## 构造函数

### `ChartTooltipFormatterParameters(String,String,Int32,String,String,Int32,String,String,String,Int32,Int32,String,TCYM.UI.Chart.Components.Tooltip.ChartTooltipValue,TCYM.UI.Chart.Rendering.ChartBrush,TCYM.UI.Chart.Rendering.ChartBrush,Collections.Generic.IEnumerable{String},Collections.Generic.IEnumerable{Collections.Generic.KeyValuePair{String,Collections.Generic.IEnumerable{String}}},Nullable{Double},Collections.Generic.IEnumerable{String},Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Tooltip.ChartTooltipAxisBinding},Object)`

创建完整 formatter 参数快照。

| 参数 | 说明 |
| --- | --- |
| `componentType` | 组件主类型。 |
| `componentSubType` | 组件子类型。 |
| `componentIndex` | 组件索引；未知时为 -1。 |
| `componentId` | 组件 ID。 |
| `seriesType` | 系列类型。 |
| `seriesIndex` | 系列索引；未知时为 -1。 |
| `seriesId` | 系列 ID。 |
| `seriesName` | 系列名称。 |
| `name` | 数据项或组件目标名称。 |
| `dataIndex` | 原始数据索引；未知时为 -1。 |
| `dataIndexInside` | 系列公开 presentation 索引；未知时为 -1。 |
| `dataType` | main、node、edge 等数据类型。 |
| `value` | 单值或多维值。 |
| `color` | 可选 marker 主画刷。 |
| `borderColor` | 可选 marker 边框画刷。 |
| `dimensionNames` | 稳定维度名称。 |
| `encode` | encode channel 到维度名的映射。 |
| `percent` | 饼图、漏斗图等使用的可选百分比。 |
| `templateVariables` | 按 a、b、c、d、e 顺序映射的属性名。 |
| `axisBindings` | axis trigger 附加信息。 |
| `rawData` | 满足图表数据隔离契约的原始领域对象。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AxisBindings` | 获取 axis trigger 附加信息。 |
| `BorderColor` | 获取已快照的 marker 边框画刷。 |
| `Color` | 获取已快照的 marker 主画刷。 |
| `ComponentId` | 获取组件 ID。 |
| `ComponentIndex` | 获取组件索引。 |
| `ComponentSubType` | 获取组件子类型。 |
| `ComponentType` | 获取组件主类型。 |
| `DataIndex` | 获取原始数据索引。 |
| `DataIndexInside` | 获取系列公开 presentation 索引。 |
| `DataType` | 获取 main、node 或 edge 等数据类型。 |
| `DimensionNames` | 获取稳定维度名称。 |
| `Encode` | 获取 encode channel 到维度名集合的只读映射。 |
| `Name` | 获取数据项或组件目标名称。 |
| `Percent` | 获取可选百分比值。 |
| `RawData` | 获取已通过数据隔离门禁捕获的原始领域对象。 |
| `SeriesId` | 获取系列 ID。 |
| `SeriesIndex` | 获取系列索引。 |
| `SeriesName` | 获取系列名称。 |
| `SeriesType` | 获取系列类型。 |
| `TemplateVariables` | 获取 a、b、c、d、e 对应的属性名顺序。 |
| `Value` | 获取不可变单值或多维值。 |
