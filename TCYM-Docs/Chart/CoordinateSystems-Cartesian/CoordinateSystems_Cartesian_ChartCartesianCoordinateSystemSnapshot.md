# ChartCartesianCoordinateSystemSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

隐藏工厂具体实现并拥有独立 `CreateSnapshot` 的
Cartesian 坐标系只读快照。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Bounds` | 获取坐标系在图表内容区中的像素边界。 |
| `Id` | 获取当前坐标系实例在一张图表内的唯一标识。 |
| `Type` | 获取坐标系类型，例如 `cartesian2d`、`polar` 或 `radar`。 |

## 方法

### `Contains(SkiaSharp.SKPoint)`

判断给定像素点是否位于当前坐标系的有效区域内。

| 参数 | 说明 |
| --- | --- |
| `point` | 相对于图表内容区左上角的像素坐标。 |

**返回：** 位于有效区域内时为 `true`。

### `CreateSnapshot`

为后续管线候选阶段创建独立快照。返回实例不得与当前已发布坐标系共享可变状态，
否则失败候选中的查询或布局操作可能污染上一份可用结果。

**返回：** 标识和类型保持一致、但可变状态完全隔离的新实例。

### `DataToPoint(TCYM.UI.Chart.CoordinateSystems.ChartCoordinateValue)`

将数据坐标转换为图表内容区中的像素坐标。

| 参数 | 说明 |
| --- | --- |
| `value` | 待转换的数据坐标。 |

**返回：** 相对于图表内容区左上角的像素坐标。

### `PointToData(SkiaSharp.SKPoint)`

将图表内容区中的像素坐标反向转换为数据坐标。

| 参数 | 说明 |
| --- | --- |
| `point` | 相对于图表内容区左上角的像素坐标。 |

**返回：** 转换后的数据坐标。
