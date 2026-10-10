# ChartCartesian2D

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

表示由两个不可变比例尺组成的二维直角坐标系。坐标系本身不依赖任何系列，
只负责在 `ChartCoordinateValue` 与图表内容区像素坐标之间执行双向转换。

## 说明

X、Y 比例尺的输出范围必须分别完整覆盖 `Bounds` 的水平和垂直边界，
但范围方向可以反转。转换失败时，非 Try API 分别返回 `InvalidPoint` 或
`InvalidData`；比例尺是否允许外插或将结果限制到边界由其自身的 Clamp 契约决定。

## 构造函数

### `ChartCartesian2D(String,SkiaSharp.SKRect,TCYM.UI.Chart.CoordinateSystems.Scales.IChartScale,TCYM.UI.Chart.CoordinateSystems.Scales.IChartScale)`

创建绑定到有限矩形边界和两个不可变比例尺的直角坐标系。

| 参数 | 说明 |
| --- | --- |
| `id` | 同一张图表内唯一且非空白的坐标系标识。 |
| `bounds` | 规范化的有限像素边界；允许宽度或高度为零。 |
| `xScale` | 水平比例尺，其范围端点必须以任意方向对应 `bounds` 的 Left 和 Right。 |
| `yScale` | 垂直比例尺，其范围端点必须以任意方向对应 `bounds` 的 Top 和 Bottom。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Bounds` | 获取坐标系在图表内容区中的像素边界。 |
| `Id` | 获取当前坐标系实例在一张图表内的唯一标识。 |
| `InvalidData` | 获取由两个空图表值组成的无效数据坐标。 |
| `InvalidPoint` | 获取由两个 NaN 分量组成的无效像素点。 |
| `IsEmpty` | 获取任一维度是否没有有效数据域。 |
| `Type` | 获取坐标系类型，例如 `cartesian2d`、`polar` 或 `radar`。 |
| `XScale` | 获取负责第一个数据维度的不可变水平比例尺。 |
| `YScale` | 获取负责第二个数据维度的不可变垂直比例尺。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `CoordinateSystemType` | 直角坐标系在注册表和构建管线中使用的稳定类型名。 |

## 方法

### `Contains(SkiaSharp.SKPoint)`

判断有限像素点是否位于有正面积的坐标系闭区间内；四条边均计入命中，
但宽度或高度为零的坐标系不包含任何像素。

| 参数 | 说明 |
| --- | --- |
| `point` | 待判断的像素点。 |

**返回：** 坐标系具有正面积且像素点位于闭区间内时返回 `true`。

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

尝试把二维数据坐标转换为有限的单精度像素点。

| 参数 | 说明 |
| --- | --- |
| `value` | 待转换的二维数据坐标。 |
| `point` | 成功时得到有限像素点；失败时为 `InvalidPoint`。 |

**返回：** 两个比例尺都非空、均能完成转换，且双精度结果可以表示为有限单精度数时返回
`true`。

### `TryPointToData(SkiaSharp.SKPoint,TCYM.UI.Chart.CoordinateSystems.ChartCoordinateValue@)`

尝试把有限像素点反向转换为二维数据坐标。

| 参数 | 说明 |
| --- | --- |
| `point` | 待转换的像素点；可以位于 `Bounds` 之外。 |
| `value` | 成功时得到二维数据坐标；失败时为 `InvalidData`。 |

**返回：** 像素点有限且两个比例尺均能执行反向转换时返回 `true`。

**说明：** 本方法不隐式执行 `Contains` 检查，因此非 Clamp 比例尺可以外插，Clamp
比例尺则按照自身契约吸附到输出范围端点。
