# ChartPolarCoordinateSystemSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

隐藏工厂具体实现并拥有独立 `CreateSnapshot` 的 Polar
坐标只读快照。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AngleScale` | 获取把角度数据映射为角度度数的不可变比例尺。 |
| `Bounds` | 获取坐标系在图表内容区中的像素边界。 |
| `Center` | 获取极坐标系的有限像素中心点。 |
| `EffectiveAngleInverse` | 获取 angleAxis.inverse 与 clockwise 合成后的有效反向标志；它不改写显式 angle range。 |
| `Id` | 获取当前坐标系实例在一张图表内的唯一标识。 |
| `InnerRadius` | 获取圆环内边界的非负像素半径。 |
| `IsEmpty` | 获取任一比例尺是否没有有效数据域。 |
| `OuterRadius` | 获取圆环外边界的非负像素半径。 |
| `RadiusScale` | 获取把半径数据映射为像素半径的不可变比例尺。 |
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

### `TryDataToPoint(TCYM.UI.Chart.CoordinateSystems.ChartCoordinateValue,SkiaSharp.SKPoint@)`

尝试把半径、角度数据转换为有限像素点，并规范化比例尺外插出的负像素半径。

| 参数 | 说明 |
| --- | --- |
| `value` | X 为半径数据、Y 为角度数据的通用坐标值。 |
| `point` | 成功时得到有限像素点；失败时两个分量均为 NaN。 |

**返回：** 两个比例尺均能转换且结果可表示为有限像素坐标时返回 `true`。

### `TryPointToData(SkiaSharp.SKPoint,TCYM.UI.Chart.CoordinateSystems.ChartCoordinateValue@)`

尝试把有限像素点反向转换为半径、角度数据。

| 参数 | 说明 |
| --- | --- |
| `point` | 待转换的像素点；允许位于圆环外部。 |
| `value` | 成功时 X 为半径数据、Y 为角度数据；失败时两个维度均为空。 |

**返回：** 两个比例尺均能执行反向转换时返回 `true`。
