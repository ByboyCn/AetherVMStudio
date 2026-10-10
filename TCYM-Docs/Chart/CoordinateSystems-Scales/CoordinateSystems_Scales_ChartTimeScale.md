# ChartTimeScale

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Scales`　**Chart 版本**：`0.1.1.25`

## 概述

把 UTC 时间线性映射到输出范围的不可变比例尺。内部域统一为 Unix 毫秒，刻度按 UTC 日历边界对齐；
DateTime、数字和 ISO-8601 字符串的输入规则由 `ChartTimeValue` 明确定义。刻度通常携带 UTC
DateTimeOffset；当 Unix 毫秒无法以 100ns tick 精确往返时会保留原始 numeric Unix 毫秒，消费者必须通过
`TryGetUnixMilliseconds` 读取，不得强制转换刻度载荷。

## 构造函数

### `ChartTimeScale(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleRange,Int32,Boolean,Boolean)`

从图表值序列收集 UTC 时间域并创建时间比例尺。

| 参数 | 说明 |
| --- | --- |
| `values` | DateTime、有限 Unix 毫秒和 invariant ISO-8601 文本序列；空值、非有限值和无效文本会被忽略。 |
| `range` | 有限输出范围，允许反向或零跨度。 |
| `splitNumber` | 期望主刻度分段数，必须为一至一千。 |
| `nice` | 是否把域向外扩展到选中的 UTC 日历刻度边界。 |
| `clamp` | 是否把正反变换限制在当前时间域和输出范围内。 |

### `ChartTimeScale(TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleExtent,TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleRange,Int32,Boolean,Boolean)`

从显式 UTC Unix 毫秒域创建时间比例尺。

| 参数 | 说明 |
| --- | --- |
| `unixMillisecondsExtent` | 有限 Unix 毫秒范围；非空端点必须位于 `DateTimeOffset` 支持的完整毫秒范围内。 |
| `range` | 有限输出范围，允许反向或零跨度。 |
| `splitNumber` | 期望主刻度分段数，必须为一至一千。 |
| `nice` | 是否把域向外扩展到选中的 UTC 日历刻度边界。 |
| `clamp` | 是否把正反变换限制在当前时间域和输出范围内。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataExtent` | 获取从输入数据直接收集的 UTC Unix 毫秒范围。 |
| `Extent` | 获取实际参与变换的 UTC Unix 毫秒范围。 |
| `IsEmpty` | 获取数据域是否没有任何有效值。 |
| `Nice` | 获取是否启用 UTC 日历友好范围扩展。 |
| `SplitNumber` | 获取期望主刻度分段数。 |
| `TickInterval` | 获取选中的 UTC 日历主刻度间隔；空比例尺返回 `null`。 |
| `Ticks` | 获取只读 UTC 时间主刻度。Value 通常是 DateTimeOffset；无法用 100ns tick 精确往返的端点会使用<br />numeric Unix 毫秒，以保证 Value 重新变换后严格对应 `Coordinate`。 |
| `Type` | 获取比例尺类型。 |

## 方法

### `TryInverse(Double,TCYM.UI.Chart.Data.ChartValue@)`

尝试把输出坐标反向转换为时间图表值。结果能够通过 `DateTimeOffset` 精确往返时返回 UTC
时间；否则返回 numeric Unix 毫秒，避免 100ns tick 量化破坏反向值再次正向变换的坐标一致性。

| 参数 | 说明 |
| --- | --- |
| `coordinate` | 待反向转换的有限输出坐标。 |
| `value` | 成功时得到 UTC 时间或保真 numeric Unix 毫秒；失败时为 `Null`。 |

**返回：** 比例尺非空、坐标可转换且结果位于受支持日期范围内时返回 `true`。

### `TryInverseUtc(Double,DateTimeOffset@)`

尝试把输出坐标反向转换为 UTC 时间。此便利 API 会把 Unix 毫秒量化到最近的
`DateTimeOffset` 100ns tick；要求 inverse → transform 严格往返时应使用 `TryInverse`。

| 参数 | 说明 |
| --- | --- |
| `coordinate` | 待反向转换的有限输出坐标。 |
| `value` | 成功时得到 offset 为零、可能已量化到 100ns tick 的 UTC 时间。 |

**返回：** 比例尺非空且结果落在受支持日期范围内时返回 `true`。

### `TryTransform(TCYM.UI.Chart.Data.ChartValue,Double@)`

尝试把图表值转换为输出坐标。

| 参数 | 说明 |
| --- | --- |
| `value` | 待转换的图表值。 |
| `coordinate` | 成功时得到的有限输出坐标；失败时为 NaN。 |

**返回：** 值属于当前比例尺语义且结果有限时返回 `true`。

### `TryTransformUnixMilliseconds(Double,Double@)`

尝试把 UTC Unix 毫秒转换为输出坐标。

| 参数 | 说明 |
| --- | --- |
| `unixMilliseconds` | 待转换的有限 Unix 毫秒。 |
| `coordinate` | 成功时得到的有限输出坐标；失败时为 NaN。 |

**返回：** 时间比例尺非空、输入可表示且结果有限时返回 `true`。
