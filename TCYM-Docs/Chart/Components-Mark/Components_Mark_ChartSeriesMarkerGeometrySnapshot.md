# ChartSeriesMarkerGeometrySnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存具体系列最终布局对公共二维 Marker 几何的附加语义。系列布局处理器可以发布该中性
制品，让 markPoint 与二维 markLine 使用最终系列中心，让 Cartesian markArea 使用系列定义的
category tick/band 边界；没有制品时公共 Mark 管线继续执行标准轴投影和旧宿主扩展回退。

## 构造函数

### `ChartSeriesMarkerGeometrySnapshot(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartCartesianSeriesBinding,SkiaSharp.SKPoint,Boolean,Boolean)`

创建一份绑定最终 Cartesian 轴对的不可变系列 Marker 几何。

| 参数 | 说明 |
| --- | --- |
| `series` | 制品所属的当前有效系列。 |
| `seriesIndex` | 系列在当前有效 option 中的索引。 |
| `binding` | 系列本轮最终 Cartesian 绑定。 |
| `pointOffset` | 普通数据坐标投影后、屏幕 x/y 覆盖前应用的有限像素偏移；未被屏幕覆盖的维度才会消费对应分量。 |
| `useXAxisCategoryBoundary` | markArea 的 X category 数据边界是否从中心投影切换为非 alignWithLabel 的 tick/band 边界。 |
| `useYAxisCategoryBoundary` | markArea 的 Y category 数据边界是否从中心投影切换为非 alignWithLabel 的 tick/band 边界。 |

### `ChartSeriesMarkerGeometrySnapshot(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,TCYM.UI.Chart.CoordinateSystems.Polar.ChartPolarSeriesBinding,Double,Double)`

创建一份绑定最终 Polar 轴对的不可变系列 Marker 几何。

| 参数 | 说明 |
| --- | --- |
| `series` | 制品所属的当前有效系列。 |
| `seriesIndex` | 系列在当前有效 option 中的索引。 |
| `binding` | 系列本轮最终 Polar 绑定。 |
| `radiusCoordinateOffset` | Radius 比例尺转换后、Polar PointAt 前应用的有限坐标偏移；单位为像素。 |
| `angleCoordinateOffset` | Angle 比例尺转换后、Polar PointAt 前应用的有限坐标偏移；单位为度。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AngleAxisIdentity` | 获取最终 Angle 轴身份；Cartesian 制品返回空。 |
| `AngleCoordinateOffset` | 获取 Angle 比例尺转换后、PointAt 前应用的角度坐标偏移。 |
| `CoordinateSystemType` | 获取最终二维坐标系规范类型。 |
| `IsPolar` | 获取当前制品是否属于 Polar 坐标系。 |
| `PointOffset` | 获取数据投影后、屏幕覆盖前应用的系列级像素偏移。 |
| `RadiusAxisIdentity` | 获取最终 Radius 轴身份；Cartesian 制品返回空。 |
| `RadiusCoordinateOffset` | 获取 Radius 比例尺转换后、PointAt 前应用的像素坐标偏移。 |
| `SeriesIndex` | 获取制品发布时系列在有效 option 中的索引。 |
| `UseXAxisCategoryBoundary` | 获取 markArea 的 X category 数据维是否从对应 tick/band 边界开始。 |
| `UseYAxisCategoryBoundary` | 获取 markArea 的 Y category 数据维是否从对应 tick/band 边界开始。 |
| `XAxisIdentity` | 获取制品绑定的最终 X 轴身份。 |
| `YAxisIdentity` | 获取制品绑定的最终 Y 轴身份。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartCartesianSeriesBinding)`

判断制品是否仍属于当前系列索引和最终 Cartesian 轴对。

| 参数 | 说明 |
| --- | --- |
| `series` | 待核对的当前有效系列。 |
| `seriesIndex` | 系列在当前有效 option 中的索引。 |
| `binding` | 系列本轮最终 Cartesian 绑定。 |

**返回：** 规范身份、索引与两根轴均完全相同时返回真。

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,TCYM.UI.Chart.CoordinateSystems.Polar.ChartPolarSeriesBinding)`

判断制品是否仍属于当前系列索引和最终 Polar 轴对。

| 参数 | 说明 |
| --- | --- |
| `series` | 待核对的当前有效系列。 |
| `seriesIndex` | 系列在当前有效 option 中的索引。 |
| `binding` | 系列本轮最终 Polar 绑定。 |

**返回：** 规范身份、索引与 Radius/Angle 两根轴均完全相同时返回真。

### `UsesCategoryBoundary(Int32)`

读取指定 Cartesian 维的 markArea category 边界扩展开关。

| 参数 | 说明 |
| --- | --- |
| `coordinateDimensionIndex` | 零表示 X，一表示 Y。 |

**返回：** 该维需要 category tick/band 边界语义时为真。
