# ChartSeriesInteractionAction

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 风格的系列强调状态 action。系列查询条件按交集匹配；数据查询条件至多指定一种。
未指定系列条件时作用于全部系列，未指定数据条件时作用于匹配系列中的整个目标数据类型。

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataIndex` | 获取目标数据项在线性根数据中的原始索引，匹配 ECharts payload 的 `dataIndex`。 |
| `DataIndexInside` | 获取目标数据项在系列当前公开 presentation 中的索引，匹配 ECharts payload 的 `dataIndexInside`。 |
| `DataKey` | 获取目标数据项的强类型稳定键。 |
| `DataName` | 获取目标数据项名称。 |
| `DataType` | 获取或在 action 初始化器中设置目标系列内部的数据集合类型；默认值为<br />`Main`。 |
| `InsideIndex` | 获取 `DataIndexInside` 的语义明确兼容别名。 |
| `RawIndex` | 获取 `DataIndex` 的语义明确兼容别名。 |
| `SeriesId` | 获取目标系列的显式 ID。 |
| `SeriesIndex` | 获取目标系列在有效配置中的索引。 |
| `SeriesName` | 获取目标系列的显式名称。 |
| `SourceKey` | 获取拥有本次强调状态的来源键。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `DefaultSourceKey` | 由外部显式分派 action 使用的默认状态来源。 |
