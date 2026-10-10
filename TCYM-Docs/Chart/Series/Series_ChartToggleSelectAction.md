# ChartToggleSelectAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

切换匹配系列中目标数据项的选择状态。

## 构造函数

### `ChartToggleSelectAction(Nullable{Int32},String,String,Nullable{TCYM.UI.Chart.Data.ChartDataKey},Nullable{Int32},Nullable{Int32},Nullable{Int32},String,Boolean)`

创建一个切换选择 action。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | 目标系列索引。 |
| `seriesId` | 目标系列显式 ID。 |
| `seriesName` | 目标系列显式名称。 |
| `dataKey` | 目标源数据稳定键。 |
| `dataIndex` | 目标原始数据索引。 |
| `dataIndexInside` | 目标公开 presentation 内部索引。 |
| `rawIndex` | `dataIndex` 的兼容别名。 |
| `dataName` | 目标数据项名称。 |
| `isFromClick` | 是否由点击控制器产生。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | ECharts 兼容的 action 类型。 |
