# ChartAxisTickLayoutSnapshot

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

表示一个已经完成布局的主刻度及其前景绘制锚点。

## 构造函数

### `ChartAxisTickLayoutSnapshot(Int32,TCYM.UI.Chart.Data.ChartValue,Double,SkiaSharp.SKPoint,SkiaSharp.SKPoint,SkiaSharp.SKPoint)`

创建一个有限且具有稳定索引的主刻度布局快照。

| 参数 | 说明 |
| --- | --- |
| `tickIndex` | 主刻度在该轴原始刻度序列中的稳定零基索引。 |
| `value` | 主刻度对应的图表值。 |
| `coordinate` | 主刻度沿坐标轴维度的有限 double 坐标；Cartesian 表示像素，Polar Angle 表示角度。 |
| `tickStart` | 刻度线起点。 |
| `tickEnd` | 刻度线终点。 |
| `labelAnchor` | 普通标签的布局锚点。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Coordinate` | 获取主刻度沿坐标轴维度的有限 double 坐标。 |
| `LabelAnchor` | 获取普通标签的布局锚点。 |
| `TickEnd` | 获取刻度线终点。 |
| `TickIndex` | 获取主刻度在该轴原始刻度序列中的稳定零基索引。 |
| `TickStart` | 获取刻度线起点。 |
| `Value` | 获取主刻度对应的图表值。 |
