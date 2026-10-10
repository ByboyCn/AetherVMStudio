# ChartCategoryAxisOrder

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

Contains the effective runtime order and realtimeSort authority for one category axis.

## 属性

| 名称 | 说明 |
| --- | --- |
| `Axis` | Gets the governed category axis. |
| `CategoryOrder` | Gets the complete effective category order. |
| `DriverSeriesId` | Gets the public ID of the canonical visible Bar driver. |
| `DriverSeriesIndex` | Gets the canonical visible Bar driver index, or null when the declaration order is active. |
| `IsInitialSort` | Gets whether the first visible scene uses a pre-layout raw-value sort. |
| `IsOrderActionBuild` | Gets whether this layout consumes an already committed order action. |
| `RequiresCommit` | Gets whether the successful Bar presentation must enqueue this order as an action. |
