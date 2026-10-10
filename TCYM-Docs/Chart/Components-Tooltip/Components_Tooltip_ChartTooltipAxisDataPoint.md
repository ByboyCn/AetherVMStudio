# ChartTooltipAxisDataPoint

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

保存单个系列数据项在一根坐标轴上的不可变 value/pixel 数据点。Tooltip 聚合器可按
CoordinateSystem + Axis + PixelCoordinate 建立 O(logN) nearest 索引。字段名为兼容既有 API
保留；Cartesian/Radius 的投影单位为像素，Angle 的投影单位为度。

## 构造函数

### `ChartTooltipAxisDataPoint(String,Int32,String,TCYM.UI.Chart.Components.Tooltip.ChartTooltipAxisDimension,Int32,String,String,TCYM.UI.Chart.Data.ChartValue,Double,String)`

创建已经完成坐标转换的数据点。

| 参数 | 说明 |
| --- | --- |
| `coordinateSystemType` | 坐标系类型。 |
| `coordinateSystemIndex` | 同类坐标系索引；未知时为 -1。 |
| `coordinateSystemId` | 坐标系 ID。 |
| `dimension` | 轴维度。 |
| `axisIndex` | 同类轴索引；未知时为 -1。 |
| `axisId` | 轴 ID。 |
| `axisType` | category、value、time 或 log。 |
| `value` | 该数据项沿轴维度的原始图表值。 |
| `pixelCoordinate` | 布局后有限轴投影坐标；Angle 为度，其余已支持维度为像素。 |
| `valueLabel` | 可选轴规则格式化文本。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AxisId` | 获取轴 ID。 |
| `AxisIndex` | 获取同类轴索引。 |
| `AxisType` | 获取轴类型。 |
| `CoordinateSystemId` | 获取坐标系 ID。 |
| `CoordinateSystemIndex` | 获取同类坐标系索引。 |
| `CoordinateSystemType` | 获取坐标系类型。 |
| `Dimension` | 获取轴维度。 |
| `PixelCoordinate` | 获取布局后有限轴投影坐标；Angle 为度，其余已支持维度为像素。 |
| `Value` | 获取已隔离的原始轴值。 |
| `ValueLabel` | 获取可选轴值显示文本。 |
