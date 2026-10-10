# ChartShowTipAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

以坐标、稳定 item 身份、series/data 查询或显式内容显示 Tooltip。

## 构造函数

### `ChartShowTipAction(Nullable{Single},Nullable{Single},TCYM.UI.Chart.Interaction.ChartTooltipTargetIdentity,Nullable{Int32},String,String,Nullable{TCYM.UI.Chart.Data.ChartDataKey},Nullable{Int32},Nullable{Int32},String,String,TCYM.UI.Chart.Components.Tooltip.ChartTooltipContent,TCYM.UI.Chart.Model.ChartTooltipPosition,String,String,Nullable{Int32})`

创建手动显示请求。全部已提供的 series/data 条件使用 AND 语义；显式 Content 优先于查询。

| 参数 | 说明 |
| --- | --- |
| `x` | 可选图表局部 X 坐标；必须与 y 同时提供。 |
| `y` | 可选图表局部 Y 坐标；必须与 x 同时提供。 |
| `target` | 可选稳定 item 身份。 |
| `seriesIndex` | 可选系列索引。 |
| `seriesId` | 可选系列显式 Id。 |
| `seriesName` | 可选系列名称。 |
| `dataKey` | 可选稳定数据键。 |
| `dataIndex` | 可选 lineage 根 raw 索引。 |
| `dataIndexInside` | 可选系列公开 presentation inside 索引。 |
| `dataName` | 可选数据项名称。 |
| `descriptorKey` | 可选 descriptor owner 内稳定键。 |
| `content` | 可选显式原生内容；存在时不查询 series。 |
| `position` | 可选本次位置覆盖。 |
| `tooltipId` | 目标 Tooltip 显式 Id。 |
| `tooltipName` | 目标 Tooltip 显式 Name。 |
| `tooltipIndex` | 目标 Tooltip 同类索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Content` | 获取绕过 series 查询的可选显式原生内容。 |
| `DataIndex` | 获取可选 lineage 根 raw 索引。 |
| `DataIndexInside` | 获取可选系列公开 presentation inside 索引。 |
| `DataKey` | 获取可选稳定数据键。 |
| `DataName` | 获取可选数据项名称。 |
| `DataType` | 获取可选数据类型过滤条件，例如node或edge；空值保留普通查询行为。 |
| `DescriptorKey` | 获取可选 descriptor owner 内稳定键。 |
| `Position` | 获取本次显示使用的位置覆盖。 |
| `SeriesId` | 获取可选系列显式 Id。 |
| `SeriesIndex` | 获取可选系列索引。 |
| `SeriesName` | 获取可选系列名称。 |
| `Target` | 获取可选稳定 item 身份。 |
| `X` | 获取可选图表局部 X 坐标。 |
| `Y` | 获取可选图表局部 Y 坐标。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | ECharts 兼容的 action 与事件类型。 |
