# ChartRadar2D

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Radar`　**Chart 版本**：`0.1.1.25`

## 概述

独立雷达坐标。通用坐标 X=indicatorIndex、Y=value。反算选最近方向的轴，中心点选择轴零；
Contains 判断网格及内孔，不限制实际超界数据图元的命中。

## 构造函数

### `ChartRadar2D(String,TCYM.UI.Chart.CoordinateSystems.Radar.ChartRadar2D)`

按另一个不可变 Radar 坐标复制几何，并为自定义工厂指定图表内唯一的新 ID。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Bounds` | 获取坐标系在图表内容区中的像素边界。 |
| `Center` | 获取中心 DIP 坐标。 |
| `Id` | 获取当前坐标系实例在一张图表内的唯一标识。 |
| `IndicatorCount` | 获取指标数量。 |
| `Indicators` | 获取独立指标轴快照。 |
| `InnerRadius` | 获取内半径 DIP。 |
| `OuterRadius` | 获取外半径 DIP。 |
| `Shape` | 获取网格形状。 |
| `Type` | 获取坐标系类型，例如 `cartesian2d`、`polar` 或 `radar`。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `CoordinateSystemType` | 获取注册坐标类型。 |

## 方法

### `Contains(SkiaSharp.SKPoint)`

判断给定像素点是否位于当前坐标系的有效区域内。

| 参数 | 说明 |
| --- | --- |
| `point` | 相对于图表内容区左上角的像素坐标。 |

**返回：** 位于有效区域内时为 `true`。

### `CreateSnapshot`

为后续管线候选阶段创建独立快照。返回实例不得与当前已发布坐标系共享可变状态，
否则失败候选中的查询或布局操作可能污染上一份可用结果。

**返回：** 标识和类型保持一致、但可变状态完全隔离的新实例。

### `DataToPoint(TCYM.UI.Chart.CoordinateSystems.ChartCoordinateValue)`

投影指定指标的值；不会把显式范围外的数值夹紧到外圈。

### `DataToPoint(TCYM.UI.Chart.Data.ChartValue,Int32)`

投影指定指标的值；不会把显式范围外的数值夹紧到外圈。

### `PointToData(SkiaSharp.SKPoint)`

将图表内容区中的像素坐标反向转换为数据坐标。

| 参数 | 说明 |
| --- | --- |
| `point` | 相对于图表内容区左上角的像素坐标。 |

**返回：** 转换后的数据坐标。

### `TryDataToPoint(TCYM.UI.Chart.CoordinateSystems.ChartCoordinateValue,SkiaSharp.SKPoint@)`

尝试转换 X=指标整数索引、Y=原始数值的通用坐标。

### `TryDataToPoint(TCYM.UI.Chart.Data.ChartValue,Int32,SkiaSharp.SKPoint@)`

尝试投影指定指标的有限值；缺失值或无效索引返回假。

### `TryPointToData(SkiaSharp.SKPoint,TCYM.UI.Chart.CoordinateSystems.ChartCoordinateValue@)`

按循环角差选择最近指标并反算半径；中心点确定性选择指标零。
