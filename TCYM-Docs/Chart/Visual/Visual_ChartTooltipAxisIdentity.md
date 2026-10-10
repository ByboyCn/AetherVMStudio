# ChartTooltipAxisIdentity

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Visual`　**Chart 版本**：`0.1.1.25`

## 概述

保存坐标系与坐标轴的完整不可变查询身份。

## 构造函数

### `ChartTooltipAxisIdentity(String,Int32,String,TCYM.UI.Chart.Components.Tooltip.ChartTooltipAxisDimension,Int32,String,String)`

创建完整轴身份。

| 参数 | 说明 |
| --- | --- |
| `coordinateSystemType` | 坐标系类型。 |
| `coordinateSystemIndex` | 同类坐标系索引；未知时为 -1。 |
| `coordinateSystemId` | 坐标系 ID。 |
| `dimension` | 轴维度。 |
| `axisIndex` | 同类轴索引；未知时为 -1。 |
| `axisId` | 轴 ID。 |
| `axisType` | category、value、time 或 log。 |

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

## 方法

### `Equals(Object)`

### `Equals(TCYM.UI.Chart.Visual.ChartTooltipAxisIdentity)`

### `FromDataPoint(TCYM.UI.Chart.Components.Tooltip.ChartTooltipAxisDataPoint)`

从已经验证的 axis data point 创建身份。

| 参数 | 说明 |
| --- | --- |
| `point` | 系列发布的不可变轴数据点。 |

**返回：** 不包含 value 与轴投影坐标的轴身份。

### `GetHashCode`
