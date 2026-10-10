# ChartValueScale

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Scales`　**Chart 版本**：`0.1.1.25`

## 概述

把有限数值域线性映射到输出范围的不可变比例尺。由数据序列构造时会忽略空值、NaN、Infinity
和不可转换值；显式传入的 extent 则必须已经满足有限端点契约。

## 构造函数

### `ChartValueScale(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleRange,Int32,Boolean,Boolean,Boolean)`

从图表值序列收集数值域并创建线性比例尺。

| 参数 | 说明 |
| --- | --- |
| `values` | 待扫描的数据值；空值和非有限值会被忽略。 |
| `range` | 有限输出范围，允许反向或零跨度。 |
| `splitNumber` | 期望主刻度分段数，必须为一至一千。 |
| `nice` | 是否向外扩展为 ECharts 1、2、3、5、10 系列的友好范围。 |
| `clamp` | 是否把正反变换限制在当前友好域和输出范围内。 |
| `includeZero` | 是否在存在有效数据时强制让数据域包含零。 |

### `ChartValueScale(TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleExtent,TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleRange,Int32,Boolean,Boolean,Boolean)`

从显式连续域创建线性比例尺。

| 参数 | 说明 |
| --- | --- |
| `extent` | 有限数据域；`Empty` 创建空比例尺。 |
| `range` | 有限输出范围，允许反向或零跨度。 |
| `splitNumber` | 期望主刻度分段数，必须为一至一千。 |
| `nice` | 是否向外扩展为 ECharts 1、2、3、5、10 系列的友好范围。 |
| `clamp` | 是否把正反变换限制在当前友好域和输出范围内。 |
| `includeZero` | 是否在非空数据域中强制包含零。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataExtent` | 获取从输入数据直接收集的原始有限范围。 |
| `Extent` | 获取实际参与变换的非零范围；启用 nice 时会向外覆盖原始范围。 |
| `IncludeZero` | 获取非空数据域是否被强制扩展到包含零。 |
| `Interval` | 获取主刻度的正有限数值间隔；空比例尺返回 NaN。 |
| `IsEmpty` | 获取数据域是否没有任何有效值。 |
| `Nice` | 获取是否启用友好范围扩展。 |
| `SplitNumber` | 获取期望主刻度分段数。 |
| `Ticks` | 获取已经按当前输出范围映射的只读主刻度。 |
| `Type` | 获取比例尺类型。 |

## 方法

### `TryInverse(Double,TCYM.UI.Chart.Data.ChartValue@)`

尝试把输出坐标反向转换为图表值。

| 参数 | 说明 |
| --- | --- |
| `coordinate` | 待转换的有限输出坐标。 |
| `value` | 成功时得到的图表值；失败时为 `Null`。 |

**返回：** 坐标可转换且结果属于目标数据类型时返回 `true`。

### `TryInverseNumber(Double,Double@)`

尝试把输出坐标反向转换为有限双精度数值。

| 参数 | 说明 |
| --- | --- |
| `coordinate` | 待转换输出坐标。 |
| `value` | 成功时得到的有限数值；失败时为 NaN。 |

**返回：** 比例尺非空且结果有限时返回 `true`。

### `TryTransform(TCYM.UI.Chart.Data.ChartValue,Double@)`

尝试把图表值转换为输出坐标。

| 参数 | 说明 |
| --- | --- |
| `value` | 待转换的图表值。 |
| `coordinate` | 成功时得到的有限输出坐标；失败时为 NaN。 |

**返回：** 值属于当前比例尺语义且结果有限时返回 `true`。

### `TryTransformNumber(Double,Double@)`

尝试把有限双精度数值转换为输出坐标。

| 参数 | 说明 |
| --- | --- |
| `value` | 待转换数值。 |
| `coordinate` | 成功时得到的有限输出坐标；失败时为 NaN。 |

**返回：** 比例尺非空且变换结果有限时返回 `true`。
