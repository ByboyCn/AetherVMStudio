# ChartDownplayAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

移除匹配系列目标数据类型或数据项上由指定来源拥有的 emphasis 状态。

## 构造函数

### `ChartDownplayAction(Nullable{Int32},String,String,Nullable{TCYM.UI.Chart.Data.ChartDataKey},Nullable{Int32},Nullable{Int32},Nullable{Int32},String,String)`

创建一个系列或数据项取消强调 action。

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
| `sourceKey` | 仅移除此来源拥有的强调状态。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | ECharts 兼容的 action 类型。 |

## 方法

### `ForDataType(TCYM.UI.Chart.Series.ChartSeriesDataType,Nullable{Int32},String,String,Nullable{TCYM.UI.Chart.Data.ChartDataKey},Nullable{Int32},Nullable{Int32},Nullable{Int32},String,String)`

创建一个显式指定系列数据集合的取消强调 action，同时保持旧构造函数二进制与源兼容。

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
| `sourceKey` | 仅移除此来源拥有的强调状态。 |

**返回：** 数据类型已经冻结到初始化器中的新 action。
