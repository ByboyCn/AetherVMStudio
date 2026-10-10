# ChartTreeExpandAndCollapseAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

按稳定身份展开、折叠或切换树分支；叶节点不改变状态。

## 构造函数

### `ChartTreeExpandAndCollapseAction(Nullable{Int32},String,String,Nullable{TCYM.UI.Chart.Data.ChartDataKey},Nullable{Int32},Nullable{Int32},String,Nullable{Boolean})`

创建树分支查询；数据选择器必须且只能指定一种，系列查询按交集匹配。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | 系列索引。 |
| `seriesId` | 系列 ID。 |
| `seriesName` | 系列名称。 |
| `dataKey` | 稳定数据键。 |
| `dataIndex` | 原始数据索引。 |
| `dataIndexInside` | 当前可见布局索引。 |
| `dataName` | 节点名称，同名分支全部匹配。 |
| `collapsed` | true 折叠，false 展开，null 切换。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Collapsed` | 期望折叠状态；null 表示切换。 |
| `DataIndex` | 目标原始索引。 |
| `DataIndexInside` | 目标可见索引。 |
| `DataKey` | 目标稳定键。 |
| `DataName` | 目标节点名称。 |
| `SeriesId` | 目标系列 ID。 |
| `SeriesIndex` | 目标系列索引。 |
| `SeriesName` | 目标系列名称。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | 公开 action 类型。 |
