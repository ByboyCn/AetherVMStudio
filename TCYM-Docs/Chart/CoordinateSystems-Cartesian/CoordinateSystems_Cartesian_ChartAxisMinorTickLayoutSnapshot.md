# ChartAxisMinorTickLayoutSnapshot

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

表示一个已经完成布局的次刻度及其线段几何。

## 构造函数

### `ChartAxisMinorTickLayoutSnapshot(Int32,Int32,Double,SkiaSharp.SKPoint,SkiaSharp.SKPoint)`

创建一个有限且具有稳定父子索引的次刻度布局快照。

| 参数 | 说明 |
| --- | --- |
| `majorTickIndex` | 所属主刻度的稳定索引。 |
| `minorTickIndex` | 同一主刻度区间内的稳定零基次刻度索引。 |
| `coordinate` | 次刻度沿坐标轴维度的有限 double 坐标；Cartesian 表示像素，Polar Angle 表示角度。 |
| `tickStart` | 次刻度线起点。 |
| `tickEnd` | 次刻度线终点。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Coordinate` | 获取次刻度沿坐标轴维度的有限 double 坐标。 |
| `MajorTickIndex` | 获取所属主刻度的稳定索引。 |
| `MinorTickIndex` | 获取同一主刻度区间内的稳定零基次刻度索引。 |
| `TickEnd` | 获取次刻度线终点。 |
| `TickStart` | 获取次刻度线起点。 |
