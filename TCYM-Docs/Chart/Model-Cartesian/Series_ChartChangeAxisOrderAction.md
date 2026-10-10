# ChartChangeAxisOrderAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

Changes the authoritative category order of one Cartesian axis.

## 构造函数

### `ChartChangeAxisOrderAction(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisDimension,Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},String,Nullable{Int32})`

Creates a complete category-axis order action using ECharts-style axis selectors.

| 参数 | 说明 |
| --- | --- |
| `dimension` | The target Cartesian axis dimension. |
| `categoryOrder` | The complete, non-empty and duplicate-free category order. |
| `axisId` | An optional axis ID; when present it takes priority over `axisIndex`. |
| `axisIndex` | An optional same-dimension axis index; omitted selectors target index zero. |

### `ChartChangeAxisOrderAction(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue})`

Creates a complete category-axis order action.

| 参数 | 说明 |
| --- | --- |
| `axis` | The target X or Y category axis. |
| `categoryOrder` | The complete, duplicate-free category order. |

### `ChartChangeAxisOrderAction(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,Collections.Generic.IReadOnlyList{TCYM.UI.Chart.Data.ChartValue},Boolean)`

Creates an already-snapshotted internal restore action without public validation.

## 属性

| 名称 | 说明 |
| --- | --- |
| `Axis` | Gets the immutable axis selector represented as an identity value. |
| `AxisId` | Gets the optional axis ID selector, which takes priority over the index. |
| `AxisIndex` | Gets the optional same-dimension axis index selector. |
| `CategoryOrder` | Gets the complete immutable category order. |
| `Dimension` | Gets the target Cartesian axis dimension. |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | The ECharts-compatible action name. |
| `EventType` | The semantic event published after a successful order change. |
