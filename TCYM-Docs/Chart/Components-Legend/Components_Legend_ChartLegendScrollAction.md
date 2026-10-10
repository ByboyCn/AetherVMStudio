# ChartLegendScrollAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Legend`　**Chart 版本**：`0.1.1.25`

## 概述

修改滚动 Legend 的分页起始数据索引。

## 构造函数

### `ChartLegendScrollAction(Int32,String,String,Nullable{Int32})`

创建一个滚动分页 action。

| 参数 | 说明 |
| --- | --- |
| `scrollDataIndex` | 目标分页起始数据索引。 |
| `legendId` | 目标 Legend 的显式 Id。 |
| `legendName` | 目标 Legend 的显式 Name。 |
| `legendIndex` | 目标 Legend 的同类索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `ScrollDataIndex` | 获取目标分页起始数据索引。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | ECharts 兼容的 action 类型。 |
| `EventType` | action 成功后发布的 ECharts 兼容事件类型。 |
