# ChartAxisQueryResult

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

表示一根匹配坐标轴的投影值、可选最近主刻度和最终指示值。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Axis` | 获取匹配坐标轴的只读身份。 |
| `AxisDistance` | 获取查询点到有限轴线线段的欧氏距离。 |
| `AxisPoint` | 获取最终坐标投影到轴线后的像素点。 |
| `Coordinate` | 获取根据吸附设置选出的最终像素坐标。 |
| `GridBounds` | 获取所属网格内容区边界。 |
| `GridId` | 获取所属网格布局标识。 |
| `HasNearestTick` | 获取是否存在可供吸附和距离判断的最近主刻度。 |
| `IsInsideGrid` | 获取查询点是否位于网格的闭区间边界内。 |
| `IsSnapped` | 获取最终值是否实际取自最近主刻度。 |
| `NearestTick` | 获取按坐标二分解析出的最近主刻度；不存在时为默认快照。 |
| `Position` | 获取坐标轴所在位置。 |
| `ProjectedCoordinate` | 获取投影值经比例尺回映后的有效像素坐标。 |
| `ProjectedValue` | 获取比例尺对原始轴向坐标执行反变换得到的值。 |
| `QueryPoint` | 获取调用方提供的原始查询点。 |
| `StableOrder` | 获取查询索引为坐标轴分配的稳定零基顺序。 |
| `TickDistance` | 获取查询点轴向分量到最近主刻度坐标的绝对距离。 |
| `Value` | 获取根据吸附设置选出的最终轴值。 |
