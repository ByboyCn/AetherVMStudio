# ChartAxisBandBoundaryLayoutSnapshot

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

表示 category `boundaryGap=true` 时位于 band 边界上的一条轴刻度线。
它与分类中心的语义主刻度分离，避免 synthetic 末端边界进入 nearest-axis 查询。

## 构造函数

### `ChartAxisBandBoundaryLayoutSnapshot(Int32,Double,SkiaSharp.SKPoint,SkiaSharp.SKPoint)`

创建一条具有稳定边界索引和有限几何的 category band 边界。

| 参数 | 说明 |
| --- | --- |
| `boundaryIndex` | 从比例尺起点开始的零基边界索引。 |
| `coordinate` | 沿轴维度的有限 double 坐标；Cartesian 表示像素，Polar Angle 表示角度。 |
| `tickStart` | 轴线上的刻度起点。 |
| `tickEnd` | 按 axisTick 方向和长度计算的刻度终点。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `BoundaryIndex` | 获取从比例尺起点开始的零基边界索引。 |
| `Coordinate` | 获取沿轴维度的有限 double 坐标。 |
| `TickEnd` | 获取按 axisTick 方向和长度计算的刻度终点。 |
| `TickStart` | 获取轴线上的刻度起点。 |
