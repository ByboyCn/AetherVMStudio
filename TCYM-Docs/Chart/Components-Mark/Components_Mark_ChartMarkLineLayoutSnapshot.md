# ChartMarkLineLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个宿主系列当前代全部可渲染 markLine 的不可变二维坐标布局。

## 构造函数

### `ChartMarkLineLayoutSnapshot(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,Boolean,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartCartesianSeriesBinding,Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Mark.ChartMarkLineLayoutItemSnapshot})`

创建一个宿主系列的完整 markLine 布局快照。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效宿主系列。 |
| `seriesIndex` | 宿主系列在有效 option 中的索引。 |
| `visible` | 宿主系列与 markLine 当前是否可见。 |
| `binding` | 宿主系列的最终 Cartesian grid、轴和坐标系绑定。 |
| `items` | 已经成功投影且通过逐端点数据域过滤的布局项。 |

### `ChartMarkLineLayoutSnapshot(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,Boolean,TCYM.UI.Chart.CoordinateSystems.Polar.ChartPolarSeriesBinding,Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Mark.ChartMarkLineLayoutItemSnapshot})`

创建一个宿主系列的完整 Polar 二端点 markLine 布局快照。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效宿主系列。 |
| `seriesIndex` | 宿主系列在有效 option 中的索引。 |
| `visible` | 宿主系列与 markLine 当前是否可见。 |
| `binding` | 宿主系列最终 Polar、Radius/Angle 轴和坐标系绑定。 |
| `items` | 已经成功投影且通过逐端点数据域过滤的布局项。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AngleAxisIdentity` | 获取最终 Angle 轴身份；Cartesian 快照返回 `null`。 |
| `AngleAxisTypeName` | 获取最终 Angle 轴协议名称；Cartesian 快照返回 `null`。 |
| `CoordinateBounds` | 获取最终 Grid 内容区或 Polar 外圆的有限粗包围盒。 |
| `CoordinateSystemBounds` | 获取最终坐标系粗包围盒；是 `CoordinateBounds` 的完整名称别名。 |
| `CoordinateSystemId` | 获取最终坐标系工厂快照的稳定 ID。 |
| `CoordinateSystemIndex` | 获取最终 Grid 或 Polar 在同主类型组件序列中的索引。 |
| `CoordinateSystemType` | 获取最终二维坐标系规范类型。 |
| `GridBounds` | 获取宿主坐标系的最终粗边界；Polar 下为外圆包围盒，该兼容字段不表示线段裁剪区域。 |
| `GridComponentIndex` | 获取宿主 Grid 组件索引；Polar 布局返回 -1。 |
| `GridId` | 获取宿主 Grid 稳定布局 ID；Polar 布局返回空字符串。 |
| `IsPolar` | 获取当前布局是否属于 Polar 坐标系。 |
| `Items` | 获取按 Mark insideIndex 保持相对顺序的可渲染布局项。 |
| `PolarLayout` | 获取最终 Polar 布局；Cartesian 快照返回 `null`。 |
| `RadiusAxisIdentity` | 获取最终 Radius 轴身份；Cartesian 快照返回 `null`。 |
| `RadiusAxisTypeName` | 获取最终 Radius 轴协议名称；Cartesian 快照返回 `null`。 |
| `SeriesIndex` | 获取宿主系列在有效 option 中的索引。 |
| `Visible` | 获取宿主系列与 markLine 当前是否可见。 |
| `XAxisIdentity` | 获取最终 X 轴身份；Polar 布局返回默认身份。 |
| `XAxisTypeName` | 获取最终 X 轴协议名称；Polar 布局返回空字符串。 |
| `YAxisIdentity` | 获取最终 Y 轴身份；Polar 布局返回默认身份。 |
| `YAxisTypeName` | 获取最终 Y 轴协议名称；Polar 布局返回空字符串。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断布局是否属于给定规范宿主系列。

| 参数 | 说明 |
| --- | --- |
| `series` | 待匹配系列。 |

**返回：** 规范运行时身份相同时返回 `true`。
