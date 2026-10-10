# ChartHighlightAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

为匹配系列的目标数据类型或数据项增加一个来源拥有的 emphasis 状态。

## 构造函数

### `ChartHighlightAction(Nullable{Int32},String,String,Nullable{TCYM.UI.Chart.Data.ChartDataKey},Nullable{Int32},Nullable{Int32},Nullable{Int32},String,String)`

创建一个系列或数据项强调 action。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | 目标系列在有效配置中的索引。 |
| `seriesId` | 目标系列的显式 ID。 |
| `seriesName` | 目标系列的显式名称。 |
| `dataKey` | 目标数据项的强类型稳定键。 |
| `dataIndex` | 目标数据项在线性根数据中的原始索引。 |
| `dataIndexInside` | 目标数据项在系列当前公开 presentation 中的内部索引。 |
| `rawIndex` | `dataIndex` 的兼容别名。 |
| `dataName` | 目标数据项名称。 |
| `sourceKey` | 拥有本次强调状态的来源键。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | ECharts 兼容的 action 类型。 |

## 方法

### `ForDataType(TCYM.UI.Chart.Series.ChartSeriesDataType,Nullable{Int32},String,String,Nullable{TCYM.UI.Chart.Data.ChartDataKey},Nullable{Int32},Nullable{Int32},Nullable{Int32},String,String)`

创建一个显式指定系列数据集合的强调 action，同时避免改变旧构造函数签名或引入
`default` 实参的重载歧义。

| 参数 | 说明 |
| --- | --- |
| `dataType` | 目标系列数据集合类型。 |
| `seriesIndex` | 目标系列在有效配置中的索引。 |
| `seriesId` | 目标系列的显式 ID。 |
| `seriesName` | 目标系列的显式名称。 |
| `dataKey` | 目标数据项的强类型稳定键。 |
| `dataIndex` | 目标数据项在线性根数据中的原始索引。 |
| `dataIndexInside` | 目标数据项在系列当前公开 presentation 中的内部索引。 |
| `rawIndex` | `dataIndex` 的兼容别名。 |
| `dataName` | 目标数据项名称。 |
| `sourceKey` | 拥有本次强调状态的来源键。 |

**返回：** 数据类型已经冻结到初始化器中的新 action。
