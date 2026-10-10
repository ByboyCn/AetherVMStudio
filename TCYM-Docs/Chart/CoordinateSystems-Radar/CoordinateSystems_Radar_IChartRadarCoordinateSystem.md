# IChartRadarCoordinateSystem

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Radar`　**Chart 版本**：`0.1.1.25`

## 概述

提供独立指标轴的强类型 Radar 转换；通用坐标 X 为指标索引、Y 为数值。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Center` | 获取中心 DIP 坐标。 |
| `IndicatorCount` | 获取指标数量。 |
| `Indicators` | 获取独立指标轴快照。 |
| `InnerRadius` | 获取内半径 DIP。 |
| `OuterRadius` | 获取外半径 DIP。 |
| `Shape` | 获取网格形状。 |

## 方法

### `DataToPoint(TCYM.UI.Chart.Data.ChartValue,Int32)`

投影指定指标的值；不会把显式范围外的数值夹紧到外圈。

### `TryDataToPoint(TCYM.UI.Chart.CoordinateSystems.ChartCoordinateValue,SkiaSharp.SKPoint@)`

尝试转换 X=指标索引、Y=值的通用坐标。

### `TryDataToPoint(TCYM.UI.Chart.Data.ChartValue,Int32,SkiaSharp.SKPoint@)`

尝试投影指定指标的有限值；缺失值或无效索引返回假。

### `TryPointToData(SkiaSharp.SKPoint,TCYM.UI.Chart.CoordinateSystems.ChartCoordinateValue@)`

尝试按最近指标方向反算数值；中心点使用指标零。
