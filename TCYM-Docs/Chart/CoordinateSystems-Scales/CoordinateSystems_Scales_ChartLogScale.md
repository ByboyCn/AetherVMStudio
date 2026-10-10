# ChartLogScale

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Scales`　**Chart 版本**：`0.1.1.25`

## 概述

把严格正数域按指定底数进行对数映射的不可变比例尺。由数据序列构造时，零、负数、空值和非有限值
都作为不属于对数域的数据忽略；显式非空 extent 若包含非正端点则立即抛出参数异常。

## 构造函数

### `ChartLogScale(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleRange,Double,Int32,Boolean,Boolean)`

从图表值序列收集严格正数域并创建对数比例尺。

| 参数 | 说明 |
| --- | --- |
| `values` | 待扫描值；非正数、空值、非有限值和不可转换值会被忽略。 |
| `range` | 有限输出范围，允许反向或零跨度。 |
| `logarithmBase` | 对数底数，必须为大于一的有限数。 |
| `splitNumber` | 期望主刻度分段数，必须为一至一千。 |
| `nice` | 是否把指数域向外扩展到友好主刻度边界。 |
| `clamp` | 是否把正反变换限制在当前正数域和输出范围内。 |

### `ChartLogScale(TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleExtent,TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleRange,Double,Int32,Boolean,Boolean)`

从显式严格正数域创建对数比例尺。

| 参数 | 说明 |
| --- | --- |
| `extent` | 有限正数域；空 extent 创建空比例尺。 |
| `range` | 有限输出范围，允许反向或零跨度。 |
| `logarithmBase` | 对数底数，必须为大于一的有限数。 |
| `splitNumber` | 期望主刻度分段数，必须为一至一千。 |
| `nice` | 是否把指数域向外扩展到友好主刻度边界。 |
| `clamp` | 是否把正反变换限制在当前正数域和输出范围内。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataExtent` | 获取从输入数据直接收集的严格正数范围。 |
| `ExponentInterval` | 获取相邻主刻度之间的正有限指数间隔；空比例尺返回 NaN。 |
| `Extent` | 获取实际参与变换的严格正数范围。 |
| `IsEmpty` | 获取数据域是否没有任何有效值。 |
| `LogarithmBase` | 获取大于一的对数底数。 |
| `Nice` | 获取是否启用友好指数域扩展。 |
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

尝试把输出坐标反向转换为严格正有限数值。

| 参数 | 说明 |
| --- | --- |
| `coordinate` | 待反向转换的有限输出坐标。 |
| `value` | 成功时得到的严格正有限数值；失败时为 NaN。 |

**返回：** 比例尺非空且指数结果可表示时返回 `true`。

### `TryTransform(TCYM.UI.Chart.Data.ChartValue,Double@)`

尝试把图表值转换为输出坐标。

| 参数 | 说明 |
| --- | --- |
| `value` | 待转换的图表值。 |
| `coordinate` | 成功时得到的有限输出坐标；失败时为 NaN。 |

**返回：** 值属于当前比例尺语义且结果有限时返回 `true`。

### `TryTransformNumber(Double,Double@)`

尝试把严格正有限数值转换为输出坐标。

| 参数 | 说明 |
| --- | --- |
| `value` | 待转换数值。 |
| `coordinate` | 成功时得到的有限输出坐标；失败时为 NaN。 |

**返回：** 值属于正数域且结果有限时返回 `true`。
