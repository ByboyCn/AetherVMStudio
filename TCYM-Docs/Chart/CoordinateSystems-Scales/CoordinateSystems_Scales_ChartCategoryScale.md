# ChartCategoryScale

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Scales`　**Chart 版本**：`0.1.1.25`

## 概述

把离散 `ChartValue` 分类映射到输出范围的不可变比例尺。空值和非有限数字作为缺失数据忽略；
公开构造入口稳定去重，内部显式 axis.data 模式可保留重复 ordinal 槽位。

## 构造函数

### `ChartCategoryScale(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleRange,TCYM.UI.Chart.CoordinateSystems.Scales.ChartCategoryPlacement,Boolean,Boolean,Int32,Int32)`

从完整来源分类域和有效 ordinal 窗口创建保留全域查找语义的内部比例尺。

| 参数 | 说明 |
| --- | --- |
| `categories` | 完整分类序列；空值和非有限数字会被忽略。 |
| `range` | 有限输出范围，允许反向或零跨度。 |
| `placement` | 分类位于端点还是等宽分段中心。 |
| `clamp` | 正反变换超出范围时是否吸附到有效窗口。 |
| `deduplicateCategories` | 是否稳定保留分类第一次出现并丢弃后续重复值。 |
| `minimumOrdinalIndex` | 有效窗口在过滤后完整分类域中的首索引。 |
| `maximumOrdinalIndex` | 有效窗口在过滤后完整分类域中的尾索引。 |

### `ChartCategoryScale(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleRange,TCYM.UI.Chart.CoordinateSystems.Scales.ChartCategoryPlacement,Boolean,Boolean)`

按内部轴来源策略创建可选择保留重复 ordinal 槽位的分类比例尺。

| 参数 | 说明 |
| --- | --- |
| `categories` | 分类序列；空值和非有限数字会被忽略。 |
| `range` | 有限输出范围，允许反向或零跨度。 |
| `placement` | 分类位于端点还是等宽分段中心。 |
| `clamp` | 反向变换超出范围时是否吸附到首尾分类。 |
| `deduplicateCategories` | 是否稳定保留分类第一次出现并丢弃后续重复值。 |

### `ChartCategoryScale(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleRange,TCYM.UI.Chart.CoordinateSystems.Scales.ChartCategoryPlacement,Boolean)`

从分类序列创建离散比例尺。

| 参数 | 说明 |
| --- | --- |
| `categories` | 分类序列；空值、非有限数字和后续重复值会被忽略。 |
| `range` | 有限输出范围，允许反向或零跨度。 |
| `placement` | 分类位于端点还是等宽分段中心。 |
| `clamp` | 反向变换超出范围时是否吸附到首尾分类。 |

### `ChartCategoryScale(Collections.Generic.IReadOnlyList{TCYM.UI.Chart.Data.ChartValue},TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleRange,TCYM.UI.Chart.CoordinateSystems.Scales.ChartCategoryPlacement,Boolean,Boolean,Nullable{Int32},Nullable{Int32},Double,TCYM.UI.Chart.CoordinateSystems.Scales.ChartCategoryScale)`

用已经过滤的完整分类快照初始化比例尺，并选择需要发布的有效窗口。

| 参数 | 说明 |
| --- | --- |
| `sourceCategories` | 已经过滤并按来源策略选择性去重的完整只读分类域。 |
| `range` | 有限输出范围，允许反向或零跨度。 |
| `placement` | 分类位于端点还是等宽分段中心。 |
| `clamp` | 正反变换超出范围时是否吸附到有效窗口。 |
| `deduplicateCategories` | 是否使用稳定去重来源语义。 |
| `minimumOrdinalIndex` | 可选有效窗口首索引；省略时使用自然首端。 |
| `maximumOrdinalIndex` | 可选有效窗口尾索引；省略时使用自然尾端。 |
| `mappingOrdinalPadding` | 仅用于坐标映射的两端非负 ordinal 留白。 |
| `sharedDomain` | 共享同一已冻结来源域的比例尺；为空时独立建立来源索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `BandWidth` | 获取单个分类分段的绝对宽度；仅 `CenteredInBand` 模式有非零宽度。 |
| `Categories` | 获取按构造策略选择性去重并应用 min/max 窗口后的只读分类槽位。 |
| `IsEmpty` | 获取数据域是否没有任何有效值。 |
| `Placement` | 获取分类相对于输出端点的放置方式。 |
| `Step` | 获取相邻分类中心的绝对坐标间距；分类不足两个且不使用分段中心时返回零。 |
| `Ticks` | 获取已经按当前输出范围映射的只读主刻度。 |
| `Type` | 获取比例尺类型。 |

## 方法

### `TryGetIndex(TCYM.UI.Chart.Data.ChartValue,Int32@)`

尝试取得分类值在有效窗口内的局部零基索引；重复值返回窗口内最后一次出现的位置。

| 参数 | 说明 |
| --- | --- |
| `value` | 待查询分类值。 |
| `index` | 成功时得到的零基索引；失败时为负一。 |

**返回：** 分类存在时返回 `true`。

### `TryInverse(Double,TCYM.UI.Chart.Data.ChartValue@)`

尝试把输出坐标反向转换为图表值。

| 参数 | 说明 |
| --- | --- |
| `coordinate` | 待转换的有限输出坐标。 |
| `value` | 成功时得到的图表值；失败时为 `Null`。 |

**返回：** 坐标可转换且结果属于目标数据类型时返回 `true`。

### `TryInverseIndex(Double,Int32@)`

尝试把输出坐标吸附到最近的稳定分类索引。

| 参数 | 说明 |
| --- | --- |
| `coordinate` | 待反向转换的有限输出坐标。 |
| `index` | 成功时得到的零基分类索引；失败时为负一。 |

**返回：** 比例尺非空，且坐标位于范围内或启用了 clamp 时返回 `true`。

### `TryTransform(TCYM.UI.Chart.Data.ChartValue,Double@)`

按普通 series/公共查询语义转换分类值。显式 `axis.data` 构建的 source-slot 比例尺保留重复槽位，
Number 作为 raw ordinal；省略数据并由系列聚合的稳定去重比例尺把 Number 作为语义分类值查表。
marker/source-position 调用方不得使用本入口猜测来源，应显式调用
`TryParseSourceOrdinal` 与 `TryTransformOrdinal`。

| 参数 | 说明 |
| --- | --- |
| `value` | 待转换的普通系列分类值或显式 source-slot ordinal。 |
| `coordinate` | 成功时返回有限输出坐标；失败时为 NaN。 |

**返回：** 输入符合当前比例尺来源语义且可投影时返回真。

### `TryTransformIndex(Int32,Double@)`

尝试把稳定分类索引转换为输出坐标。

| 参数 | 说明 |
| --- | --- |
| `index` | 零基分类索引。 |
| `coordinate` | 成功时得到的有限输出坐标；失败时为 NaN。 |

**返回：** 索引有效且结果有限时返回 `true`。
