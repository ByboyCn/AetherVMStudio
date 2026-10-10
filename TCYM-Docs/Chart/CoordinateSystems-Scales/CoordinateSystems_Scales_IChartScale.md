# IChartScale

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Scales`　**Chart 版本**：`0.1.1.25`

## 概述

定义不依赖具体坐标系或系列的比例尺契约。实现必须在构造完成后深度不可变，
因而可以作为只读制品跨候选管线安全共享。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Clamp` | 获取正向或反向变换是否把结果限制在数据域和输出范围内。 |
| `IsEmpty` | 获取数据域是否没有任何有效值。 |
| `Range` | 获取比例尺的输出坐标范围。 |
| `Ticks` | 获取已经按当前输出范围映射的只读主刻度。 |
| `Type` | 获取比例尺类型。 |

## 方法

### `Inverse(Double)`

把输出坐标反向转换为图表值，无法转换时返回空值。

| 参数 | 说明 |
| --- | --- |
| `coordinate` | 待转换的输出坐标。 |

**返回：** 转换后的图表值，或失败时的 `Null`。

### `Transform(TCYM.UI.Chart.Data.ChartValue)`

把图表值转换为输出坐标，无法转换时返回 NaN。

| 参数 | 说明 |
| --- | --- |
| `value` | 待转换的图表值。 |

**返回：** 有限输出坐标，或失败时的 NaN。

### `TryInverse(Double,TCYM.UI.Chart.Data.ChartValue@)`

尝试把输出坐标反向转换为图表值。

| 参数 | 说明 |
| --- | --- |
| `coordinate` | 待转换的有限输出坐标。 |
| `value` | 成功时得到的图表值；失败时为 `Null`。 |

**返回：** 坐标可转换且结果属于目标数据类型时返回 `true`。

### `TryTransform(TCYM.UI.Chart.Data.ChartValue,Double@)`

尝试把图表值转换为输出坐标。

| 参数 | 说明 |
| --- | --- |
| `value` | 待转换的图表值。 |
| `coordinate` | 成功时得到的有限输出坐标；失败时为 NaN。 |

**返回：** 值属于当前比例尺语义且结果有限时返回 `true`。
