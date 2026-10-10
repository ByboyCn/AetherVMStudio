# ChartLegendScrollEventPayload

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Legend`　**Chart 版本**：`0.1.1.25`

## 概述

保存 `legendScroll` action 发布的不可变语义事件负载。

## 构造函数

### `ChartLegendScrollEventPayload(Int32,String,Int32)`

创建一份分页事件快照。

| 参数 | 说明 |
| --- | --- |
| `scrollDataIndex` | 成功规范化后的分页起始数据索引。 |
| `legendId` | 目标 Legend 的显式 Id。 |
| `legendIndex` | 目标 Legend 的同类索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `LegendId` | 获取目标 Legend 的显式 Id。 |
| `LegendIndex` | 获取目标 Legend 的同类索引。 |
| `ScrollDataIndex` | 获取成功规范化后的分页起始数据索引。 |
