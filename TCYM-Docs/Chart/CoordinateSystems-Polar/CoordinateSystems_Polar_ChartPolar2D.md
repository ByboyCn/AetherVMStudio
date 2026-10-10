# ChartPolar2D

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

表示由半径比例尺和角度比例尺组成的不可变二维极坐标系。

## 说明

半径比例尺输出像素半径，且范围端点必须完整对应内外半径；外插得到的负半径按绝对值与
一百八十度角偏移规范化。角度比例尺输出角度度数，显式范围允许任意方向和多圈；像素反算
由有效 inverse 选择一个规范 360 度分支，且只恢复非负半径分支。
`Bounds` 只是外圆的粗包围盒，
精确命中应调用 `Contains`。

## 构造函数

### `ChartPolar2D(String,SkiaSharp.SKPoint,Single,Single,TCYM.UI.Chart.CoordinateSystems.Scales.IChartScale,TCYM.UI.Chart.CoordinateSystems.Scales.IChartScale,Boolean)`

创建带显式有效角度反向标志的二维极坐标系。该重载用于显式 endAngle 的 ECharts
兼容路径，因为其 scale range 方向不一定与 inverse/clockwise 合成方向一致。

| 参数 | 说明 |
| --- | --- |
| `id` | 同一张图表内唯一且非空白的坐标系标识。 |
| `center` | 有限像素中心点。 |
| `innerRadius` | 非负圆环内半径。 |
| `outerRadius` | 不小于内半径的圆环外半径。 |
| `radiusScale` | 把 Radius 数据映射到像素半径的比例尺。 |
| `angleScale` | 把 Angle 数据映射到角度度数的比例尺。 |
| `angleInverse` | angleAxis.inverse 与 clockwise 合成后的有效反向标志，仅决定像素反算采用的 360 度分支。 |

### `ChartPolar2D(String,SkiaSharp.SKPoint,Single,Single,TCYM.UI.Chart.CoordinateSystems.Scales.IChartScale,TCYM.UI.Chart.CoordinateSystems.Scales.IChartScale)`

创建绑定到中心、圆环半径和两个不可变比例尺的极坐标系。

| 参数 | 说明 |
| --- | --- |
| `id` | 同一张图表内唯一且非空白的坐标系标识。 |
| `center` | 有限的像素中心点。 |
| `innerRadius` | 非负的圆环内半径。 |
| `outerRadius` | 不小于内半径的圆环外半径。 |
| `radiusScale` | 半径比例尺，其输出范围端点必须以任意方向对应 `innerRadius` 和<br />`outerRadius`。 |
| `angleScale` | 角度比例尺，其输出范围单位为度，允许正向、反向、零跨度或显式多圈范围。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AngleInverse` | 获取有效角度反向标志；是 `EffectiveAngleInverse` 的兼容短名称。 |
| `AngleScale` | 获取把角度数据映射为角度度数的不可变比例尺。 |
| `Bounds` | 获取坐标系在图表内容区中的像素边界。 |
| `Center` | 获取极坐标系的有限像素中心点。 |
| `EffectiveAngleInverse` | 获取 angleAxis.inverse 与 clockwise 合成后的有效方向；它只控制像素角选择哪个<br />360 度等价分支，不改写显式 angle scale range。 |
| `Id` | 获取当前坐标系实例在一张图表内的唯一标识。 |
| `InnerRadius` | 获取圆环内边界的非负像素半径。 |
| `InvalidData` | 获取由两个空图表值组成的无效极坐标数据。 |
| `InvalidPoint` | 获取由两个 NaN 分量组成的无效像素点。 |
| `IsEmpty` | 获取任一比例尺是否没有有效数据域。 |
| `OuterRadius` | 获取圆环外边界的非负像素半径。 |
| `RadiusScale` | 获取把半径数据映射为像素半径的不可变比例尺。 |
| `Type` | 获取坐标系类型，例如 `cartesian2d`、`polar` 或 `radar`。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `CoordinateSystemType` | 极坐标系在注册表和构建管线中使用的稳定类型名。 |

## 方法

### `Contains(SkiaSharp.SKPoint)`

判断有限像素点是否同时位于闭合半径范围和角轴可见扇区内。半径与角度边界均计入命中；
中心点没有可定义的几何角，因此与 ECharts containPoint 一致，不属于任何 Polar 数据区域。

| 参数 | 说明 |
| --- | --- |
| `point` | 待判断的像素点。 |

**返回：** 点位于精确 Polar 扇区闭区间时返回 `true`。

### `ContainsAnnulus(SkiaSharp.SKPoint)`

判断有限像素点是否位于闭合内外半径圆环内，而不考虑 partial angle 范围。该粗判对应
ECharts Polar area 的 ring 语义，只供 clip/几何预筛选；containPixel 必须调用 `Contains`。

| 参数 | 说明 |
| --- | --- |
| `point` | 待判断的像素点。 |

**返回：** 点位于内外半径组成的圆环闭区间时返回 `true`。

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
