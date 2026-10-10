# ChartAxisEffectiveScale

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

包装一个不可变基础比例尺，并发布经过 axis interval 策略统一生成的有效只读主刻度。
所有正反变换仍委托给同一个基础比例尺。显式 category data 含重复值时，刻度按槽位定位，而值查询
按完整 ordinal 域的最后一次出现定位，因此调用方不得假定每个重复刻度都能按值无歧义往返。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Clamp` | 获取正向或反向变换是否把结果限制在数据域和输出范围内。 |
| `EffectiveExtent` | 获取 nice/align 后的最终刻度有效域；分类轴为空，containShape 不改变该值。 |
| `EffectiveInterval` | 获取最终正有限数值间隔；自动日历 time 和 category 返回 null。 |
| `InnerScale` | 获取实际执行正反变换的不可变具体比例尺；containShape 生效时其映射域可以大于<br />`EffectiveExtent`，但类型与输出范围保持不变。 |
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
