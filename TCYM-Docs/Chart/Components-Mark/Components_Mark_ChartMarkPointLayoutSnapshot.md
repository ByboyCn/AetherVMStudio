# ChartMarkPointLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个宿主系列当前代全部可渲染 markPoint 的不可变二维坐标布局。

## 构造函数

### `ChartMarkPointLayoutSnapshot(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,Boolean,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartCartesianSeriesBinding,Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Mark.ChartMarkPointLayoutItemSnapshot})`

创建一个宿主系列的完整 markPoint 布局快照。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效宿主系列。 |
| `seriesIndex` | 宿主系列索引。 |
| `visible` | 宿主系列与 markPoint 当前是否可见。 |
| `binding` | 宿主系列的最终 Cartesian grid、轴和坐标系绑定。 |
| `items` | 已经成功投影并通过数据域准入的布局项。 |

### `ChartMarkPointLayoutSnapshot(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,Boolean,TCYM.UI.Chart.CoordinateSystems.Polar.ChartPolarSeriesBinding,Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Mark.ChartMarkPointLayoutItemSnapshot})`

创建一个绑定到最终 Polar、Radius 轴和 Angle 轴的 markPoint 布局快照。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效宿主系列。 |
| `seriesIndex` | 宿主系列索引。 |
| `visible` | 宿主系列与 markPoint 当前是否可见。 |
| `binding` | 宿主系列的最终 Polar、两根轴和坐标系绑定。 |
| `items` | 已经成功投影并通过数据域准入的布局项。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AngleAxisIdentity` | 获取最终 Angle 轴完整组件身份；Cartesian 布局返回空。 |
| `AngleAxisTypeName` | 获取最终 Angle 轴的 value/category/time/log 协议名称。 |
| `ClipBounds` | 获取宿主二维坐标系粗包围盒；保留旧名称以兼容现有调用方。 |
| `CoordinateBounds` | 获取最终 grid 内容区或 Polar 外圆的粗包围盒。 |
| `CoordinateSystemBounds` | 获取最终坐标系粗包围盒；是 `CoordinateBounds` 的完整名称别名。 |
| `CoordinateSystemId` | 获取最终坐标系工厂快照的稳定 ID。 |
| `CoordinateSystemIndex` | 获取最终 grid 或 polar 在同主类型组件序列中的索引。 |
| `CoordinateSystemType` | 获取最终二维坐标系规范类型。 |
| `GridComponentIndex` | 获取宿主 grid 索引；Polar 布局返回 -1。 |
| `GridId` | 获取宿主 grid 的稳定布局 ID；Polar 布局返回空字符串。 |
| `IsPolar` | 获取当前布局是否属于 Polar 坐标系。 |
| `Items` | 获取按 Mark insideIndex 排列的可渲染布局项。 |
| `PolarLayout` | 获取最终 Polar 布局；Cartesian 布局返回空。 |
| `RadiusAxisIdentity` | 获取最终 Radius 轴完整组件身份；Cartesian 布局返回空。 |
| `RadiusAxisTypeName` | 获取最终 Radius 轴的 value/category/time/log 协议名称。 |
| `SeriesIndex` | 获取宿主系列在有效 option 中的索引。 |
| `Visible` | 获取宿主系列与 markPoint 当前是否可见。 |
| `XAxisIdentity` | 获取最终 X 轴完整组件身份；仅 Cartesian 布局有意义。 |
| `XAxisTypeName` | 获取最终 X 轴类型名；Polar 布局返回空字符串。 |
| `YAxisIdentity` | 获取最终 Y 轴完整组件身份；仅 Cartesian 布局有意义。 |
| `YAxisTypeName` | 获取最终 Y 轴类型名；Polar 布局返回空字符串。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断布局是否属于给定规范宿主系列。

| 参数 | 说明 |
| --- | --- |
| `series` | 待匹配系列。 |

**返回：** 规范运行时身份相同时返回 `true`。
