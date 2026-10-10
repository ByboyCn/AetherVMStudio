# ChartSeriesSelectionAction

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 风格的系列选择 action。系列查询条件按交集匹配，数据查询条件至多指定一种；
选择状态最终以 `ChartSeriesDataTarget` 的源目标持久化。当前 Line 选择底座要求
action 显式提供 dataKey、dataIndex、dataIndexInside 或 dataName 中的一种数据 selector；
只有系列 selector 而没有数据 selector 的 action 不改变状态，但仍按 ECharts 6.1 运行行为
发布包含当前完整选择快照的 `selectchanged` 事件。

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataIndex` | 获取目标项在线性根数据中的原始索引。 |
| `DataIndexInside` | 获取目标项在系列当前公开 presentation 中的内部索引。 |
| `DataKey` | 获取目标源数据项的强类型稳定键。 |
| `DataName` | 获取目标项名称。 |
| `DataType` | 获取或在初始化器中设置目标系列内部数据集合；默认使用主数据。 |
| `InsideIndex` | 获取 `DataIndexInside` 的语义明确兼容别名。 |
| `IsFromClick` | 获取 action 是否由图表点击控制器产生。 |
| `RawIndex` | 获取 `DataIndex` 的兼容别名。 |
| `SeriesId` | 获取目标系列显式 ID。 |
| `SeriesIndex` | 获取目标系列在有效配置中的索引。 |
| `SeriesName` | 获取目标系列显式名称。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `SelectionChangedEventType` | 选择 action 完成后发布的 ECharts 兼容语义事件类型。 |
