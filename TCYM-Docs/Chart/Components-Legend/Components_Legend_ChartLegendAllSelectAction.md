# ChartLegendAllSelectAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Legend`　**Chart 版本**：`0.1.1.25`

## 概述

选中多个选择模式 Legend 中的全部项目。

## 构造函数

### `ChartLegendAllSelectAction(String,String,Nullable{Int32})`

创建一个全选 action。

| 参数 | 说明 |
| --- | --- |
| `legendId` | 目标 Legend 的显式 Id。 |
| `legendName` | 目标 Legend 的显式 Name。 |
| `legendIndex` | 目标 Legend 的同类索引。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | ECharts 兼容的 action 类型。 |
| `EventType` | action 成功后发布的 ECharts 兼容事件类型。 |
