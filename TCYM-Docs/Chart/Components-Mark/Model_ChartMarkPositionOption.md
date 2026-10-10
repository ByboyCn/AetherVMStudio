# ChartMarkPositionOption

> **类型**：class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 6.1 公共 MarkerPositionOption。运行时按 `x/y > coord > axis/type`
解析；只提供 X 或 Y 时仅覆盖对应屏幕维度。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AngleAxis` | 获取或设置 Polar Angle 轴数据简写值。 |
| `Coordinate` | 获取或设置严格二维的 Cartesian X/Y 或 Polar Radius/Angle 坐标。 |
| `RadiusAxis` | 获取或设置 Polar Radius 轴数据简写值。 |
| `RelativeTo` | 获取或设置 markPoint 百分比相对于容器或坐标区域解析。 |
| `Statistic` | 获取或设置没有显式 coord 时使用的统计请求。 |
| `Value` | 获取或设置 Label/Tooltip 使用的显示值覆盖。 |
| `ValueDimension` | 获取或设置统计目标维名称。 |
| `ValueIndex` | 获取或设置统计目标维索引；同时提供 `ValueDimension` 时该字段优先。 |
| `X` | 获取或设置水平像素或百分比位置。 |
| `XAxis` | 获取或设置 Cartesian X 轴数据简写值。 |
| `Y` | 获取或设置垂直像素或百分比位置。 |
| `YAxis` | 获取或设置 Cartesian Y 轴数据简写值。 |

## 方法

### `Clone`

创建全部坐标值和自定义载荷均隔离的副本。

**返回：** 与当前位置语义相同的新实例。
