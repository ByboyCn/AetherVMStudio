# ChartCategoryAxisOrderSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

Contains the authoritative runtime category orders for the current Layout candidate.

## 构造函数

### `ChartCategoryAxisOrderSnapshot(Collections.Generic.IEnumerable{TCYM.UI.Chart.Series.ChartCategoryAxisOrder})`

Creates an immutable axis-order snapshot.

| 参数 | 说明 |
| --- | --- |
| `axes` | The unique governed category axes. |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Axes` | Gets all governed axes in stable component order. |
| `Count` | Gets the number of governed category axes. |

## 方法

### `TryGet(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,TCYM.UI.Chart.Series.ChartCategoryAxisOrder@)`

Tries to read the effective order for an axis.

| 参数 | 说明 |
| --- | --- |
| `axis` | The target axis. |
| `order` | The effective order when found. |

**返回：** True when the axis is governed by the snapshot.
