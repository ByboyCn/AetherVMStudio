# ChartChangeAxisOrderEventPayload

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

Describes a committed category-axis order change.

## 构造函数

### `ChartChangeAxisOrderEventPayload(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue})`

Creates an immutable event payload.

| 参数 | 说明 |
| --- | --- |
| `axis` | The changed category axis. |
| `categoryOrder` | The complete committed order. |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Axis` | Gets the changed category axis. |
| `AxisId` | Gets the changed axis ID. |
| `AxisIndex` | Gets the changed same-dimension axis index. |
| `CategoryOrder` | Gets the complete immutable committed order. |
| `Dimension` | Gets the changed axis dimension. |
| `DriverSeriesId` | Gets the public ID of the canonical realtimeSort driver, when applicable. |
| `DriverSeriesIndex` | Gets the effective-option index of the canonical realtimeSort driver. |
| `IsInitialSort` | Gets whether this event committed the initial raw-value sort. |
| `IsRestore` | Gets whether this event restored declaration order and released the driver. |
