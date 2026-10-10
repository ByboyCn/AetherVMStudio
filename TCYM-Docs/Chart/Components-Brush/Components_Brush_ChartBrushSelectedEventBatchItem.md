# ChartBrushSelectedEventBatchItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Brush`　**Chart 版本**：`0.1.1.25`

## 概述

保存 brushselected 中一个 Brush 组件的区域和逐系列选择结果。

## 构造函数

### `ChartBrushSelectedEventBatchItem(String,String,Int32,Collections.Generic.IEnumerable{TCYM.UI.Chart.Model.ChartBrushArea},Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Brush.ChartBrushSelectedSeriesEventItem})`

创建并冻结一个 Brush 组件的选择结果。

| 参数 | 说明 |
| --- | --- |
| `brushId` | 组件可选 ID。 |
| `brushName` | 组件可选名称。 |
| `brushIndex` | 组件同主类型索引。 |
| `areas` | 最终区域序列。 |
| `selected` | 按有效系列顺序排列的选择结果。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Areas` | 获取与内部事件状态隔离的区域深副本。 |
| `BrushId` | 获取组件可选 ID。 |
| `BrushIndex` | 获取组件同主类型索引。 |
| `BrushName` | 获取组件可选名称。 |
| `Selected` | 获取按有效系列顺序排列的不可变选择结果。 |
