# ChartTooltipAxisQueryRequest

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Visual`　**Chart 版本**：`0.1.1.25`

## 概述

描述一次针对精确轴身份的最近数据项查询。

## 构造函数

### `ChartTooltipAxisQueryRequest(TCYM.UI.Chart.Visual.ChartTooltipAxisIdentity,Double,Nullable{Double},Boolean,Nullable{TCYM.UI.Chart.Data.ChartValue})`

创建最近轴数据项查询。

| 参数 | 说明 |
| --- | --- |
| `axis` | 要查询的完整轴身份。 |
| `pixelCoordinate` | 指针沿轴维度的有限投影坐标；Angle 使用有限 double 度数，其余维度使用可表示为有限 float 的像素。 |
| `maximumDistance` | 可选有限非负最大命中距离。 |
| `dataIncreasesWithPixel` | 数据值是否随轴投影坐标增加；仅在相邻非数值数据精确等距时决定 ECharts 的较小值侧。 |
| `projectedValue` | 可选轴投影值；连续轴提供该值时按规范化数据空间选择 nearest，空值保持公开查询的投影距离 nearest 兼容行为。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Axis` | 获取要查询的完整轴身份。 |
| `DataIncreasesWithPixel` | 获取数据值是否随轴投影坐标增加。 |
| `MaximumDistance` | 获取可选最大命中距离。 |
| `PixelCoordinate` | 获取指针沿轴维度的投影坐标；Angle 为有限 double 度数，其余维度为有限 float 像素。 |
| `ProjectedValue` | 获取连续轴用于数据空间 nearest 的可选投影值。 |
