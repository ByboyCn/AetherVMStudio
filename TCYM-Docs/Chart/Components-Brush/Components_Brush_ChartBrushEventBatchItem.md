# ChartBrushEventBatchItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Brush`　**Chart 版本**：`0.1.1.25`

## 概述

保存 brush 或 brushEnd 事件中一个 Brush 组件的最终区域快照。

## 构造函数

### `ChartBrushEventBatchItem(String,String,Int32,Collections.Generic.IEnumerable{TCYM.UI.Chart.Model.ChartBrushArea})`

创建并深冻结一个组件事件项。

| 参数 | 说明 |
| --- | --- |
| `brushId` | 组件可选 ID。 |
| `brushName` | 组件可选名称。 |
| `brushIndex` | 组件同主类型索引。 |
| `areas` | 最终区域序列。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Areas` | 获取与内部事件状态隔离的区域深副本。 |
| `BrushId` | 获取组件可选 ID。 |
| `BrushIndex` | 获取组件同主类型索引。 |
| `BrushName` | 获取组件可选名称。 |
