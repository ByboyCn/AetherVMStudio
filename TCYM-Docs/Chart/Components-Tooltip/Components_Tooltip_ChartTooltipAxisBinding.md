# ChartTooltipAxisBinding

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

保存 axis trigger 附加到 formatter 参数的不可变坐标轴身份和值。

## 构造函数

### `ChartTooltipAxisBinding(String,Int32,String,TCYM.UI.Chart.Components.Tooltip.ChartTooltipAxisDimension,Int32,String,String,TCYM.UI.Chart.Data.ChartValue,String,Boolean)`

创建坐标轴绑定。

| 参数 | 说明 |
| --- | --- |
| `coordinateSystemType` | 坐标系类型，例如 cartesian2d 或 polar。 |
| `coordinateSystemIndex` | 同类坐标系索引；未知时为 -1。 |
| `coordinateSystemId` | 坐标系 ID。 |
| `dimension` | 轴维度。 |
| `axisIndex` | 同类轴索引。 |
| `axisId` | 轴 ID。 |
| `axisType` | category、value、time 或 log。 |
| `value` | 最终 axisPointer 值。 |
| `valueLabel` | 已经按轴规则格式化的显示文本。 |
| `isSnapped` | 该值是否由 nearest/snap 解析。 |

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
| `IsSnapped` | 获取值是否来自 nearest/snap。 |
| `Value` | 获取已隔离的 axisPointer 值。 |
| `ValueLabel` | 获取轴值显示文本。 |
