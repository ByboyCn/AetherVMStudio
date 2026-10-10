# ChartMarkAreaLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个宿主系列当前代全部可渲染 markArea 的不可变 Cartesian 布局。

## 构造函数

### `ChartMarkAreaLayoutSnapshot(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,Boolean,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartCartesianSeriesBinding,Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Mark.ChartMarkAreaLayoutItemSnapshot})`

创建一个宿主系列的完整 markArea 布局快照。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效宿主系列。 |
| `seriesIndex` | 宿主系列在有效 option 中的索引。 |
| `visible` | 宿主系列与 markArea 当前是否可见。 |
| `binding` | 宿主系列最终 Cartesian 绑定。 |
| `items` | 已经成功投影并通过区域过滤的布局项。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `GridBounds` | 获取宿主 Cartesian Grid 的最终有限边界。 |
| `GridComponentIndex` | 获取宿主 Grid 在有效组件序列中的索引。 |
| `GridId` | 获取宿主 Grid 的稳定布局 ID。 |
| `Items` | 获取保持原 Mark 相对顺序的可渲染布局项。 |
| `SeriesIndex` | 获取宿主系列在有效 option 中的索引。 |
| `Visible` | 获取宿主系列与 markArea 当前是否可见。 |
| `XAxisIdentity` | 获取最终 X 轴完整组件身份。 |
| `XAxisTypeName` | 获取最终 X 轴协议名称。 |
| `YAxisIdentity` | 获取最终 Y 轴完整组件身份。 |
| `YAxisTypeName` | 获取最终 Y 轴协议名称。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断布局是否属于给定规范宿主系列。

| 参数 | 说明 |
| --- | --- |
| `series` | 待匹配系列。 |

**返回：** 规范运行时身份相同时返回 `true`。
