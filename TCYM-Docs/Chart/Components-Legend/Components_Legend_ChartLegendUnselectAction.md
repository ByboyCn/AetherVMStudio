# ChartLegendUnselectAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Legend`　**Chart 版本**：`0.1.1.25`

## 概述

显式取消选中一个 Legend 名称。

## 构造函数

### `ChartLegendUnselectAction(String,String,String,Nullable{Int32})`

创建一个显式取消选中 action。

| 参数 | 说明 |
| --- | --- |
| `name` | 区分大小写的 Legend 项名称。 |
| `legendId` | 目标 Legend 的显式 Id。 |
| `legendName` | 目标 Legend 的显式 Name。 |
| `legendIndex` | 目标 Legend 的同类索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Name` | 获取要取消选中的 Legend 项名称。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | ECharts 兼容的 action 类型。 |
| `EventType` | action 成功后发布的 ECharts 兼容事件类型。 |
