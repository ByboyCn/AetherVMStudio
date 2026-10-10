# ChartSeriesDataSchema

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

保存公共数据层为一个系列解析出的不可变 schema。它明确区分 encode 未提供与显式空通道，
并把 row/column 投影后的实际维度冻结给 extent、Tooltip 和后续具体系列复用。

## 构造函数

### `ChartSeriesDataSchema(Int32,TCYM.UI.Chart.Data.ChartDataBindingKind,TCYM.UI.Chart.Data.ChartSeriesLayoutBy,TCYM.UI.Chart.Data.ChartDataTopology,Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartDimension},Collections.Generic.IEnumerable{Collections.Generic.KeyValuePair{String,Collections.Generic.IReadOnlyList{TCYM.UI.Chart.Data.ChartSeriesCoordinateSource}}},Collections.Generic.IEnumerable{String})`

创建包含任意坐标系最终通道和显式扩展通道的深度不可变数据 schema。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | 系列在 effective option 中的索引。 |
| `bindingKind` | inline 或 dataset 绑定。 |
| `seriesLayoutBy` | 实际采用的行列布局。 |
| `topology` | 数据拓扑。 |
| `dimensions` | 处理后 store 的维度定义。 |
| `channels` | 最终坐标通道与全部显式扩展通道；Polar 的坐标通道必须按 radius、angle 发布。 |
| `explicitChannels` | 调用方显式提交过的通道名称，包括显式空通道。 |

### `ChartSeriesDataSchema(Int32,TCYM.UI.Chart.Data.ChartDataBindingKind,TCYM.UI.Chart.Data.ChartSeriesLayoutBy,TCYM.UI.Chart.Data.ChartDataTopology,Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartDimension},Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartSeriesCoordinateSource},Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartSeriesCoordinateSource},Boolean,Boolean,Collections.Generic.IEnumerable{Collections.Generic.KeyValuePair{String,Collections.Generic.IReadOnlyList{TCYM.UI.Chart.Data.ChartSeriesCoordinateSource}}})`

创建包含最终 X/Y 与显式扩展 encode 通道的深度不可变数据 schema。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | 系列在 effective option 中的索引。 |
| `bindingKind` | inline 或 dataset 绑定。 |
| `seriesLayoutBy` | 实际采用的行列布局。 |
| `topology` | 数据拓扑。 |
| `dimensions` | 处理后 store 的维度定义。 |
| `xSources` | X 通道来源。 |
| `ySources` | Y 通道来源。 |
| `hasExplicitXEncode` | X 通道是否由调用方显式提交，包括显式空通道。 |
| `hasExplicitYEncode` | Y 通道是否由调用方显式提交，包括显式空通道。 |
| `additionalChannels` | 除 X/Y 外的显式 encode 通道；允许空通道以保留调用方意图。 |

### `ChartSeriesDataSchema(Int32,TCYM.UI.Chart.Data.ChartDataBindingKind,TCYM.UI.Chart.Data.ChartSeriesLayoutBy,TCYM.UI.Chart.Data.ChartDataTopology,Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartDimension},Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartSeriesCoordinateSource},Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartSeriesCoordinateSource},Boolean,Boolean)`

创建只包含最终 X/Y 通道、与调用方集合隔离的数据 schema。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | 系列在 effective option 中的索引。 |
| `bindingKind` | inline 或 dataset 绑定。 |
| `seriesLayoutBy` | 实际采用的行列布局。 |
| `topology` | 数据拓扑。 |
| `dimensions` | 处理后 store 的维度定义。 |
| `xSources` | X 通道来源。 |
| `ySources` | Y 通道来源。 |
| `hasExplicitXEncode` | X 通道是否由调用方显式提交，包括显式空通道。 |
| `hasExplicitYEncode` | Y 通道是否由调用方显式提交，包括显式空通道。 |

### `ChartSeriesDataSchema(Int32,TCYM.UI.Chart.Data.ChartDataBindingKind,TCYM.UI.Chart.Data.ChartSeriesLayoutBy,TCYM.UI.Chart.Data.ChartDataTopology,Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartDimension},TCYM.UI.Chart.Data.ChartSeriesDataSchema.CartesianCompatibilityInputs)`

从已单次捕获的兼容 X/Y 输入转发到通用通道构造函数。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | 系列索引。 |
| `bindingKind` | 数据绑定类型。 |
| `seriesLayoutBy` | 行列布局。 |
| `topology` | 数据拓扑。 |
| `dimensions` | 处理后维度。 |
| `inputs` | 已物化通道和 presence。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AngleSources` | 获取 Angle 通道的已解析来源；非 Polar schema 或显式空 encode 返回空集合。 |
| `BindingKind` | 获取 inline 或 dataset 绑定类别。 |
| `Channels` | 获取最终二维坐标与全部显式扩展 encode 通道的深度只读快照；无效选择器已被诊断并移除。 |
| `Dimensions` | 获取处理后 store 的只读维度快照。 |
| `HasExplicitAngleEncode` | 获取 Angle encode 是否被显式提交，包括显式空通道。 |
| `HasExplicitRadiusEncode` | 获取 Radius encode 是否被显式提交，包括显式空通道。 |
| `HasExplicitXEncode` | 获取 X encode 是否被显式提交，包括显式空通道。 |
| `HasExplicitYEncode` | 获取 Y encode 是否被显式提交，包括显式空通道。 |
| `RadiusSources` | 获取 Radius 通道的已解析来源；非 Polar schema 或显式空 encode 返回空集合。 |
| `SeriesIndex` | 获取系列在 effective option 中的索引。 |
| `SeriesLayoutBy` | 获取实际采用的 row/column 解释方向。 |
| `Topology` | 获取数据拓扑。 |
| `XSources` | 获取 X 通道的已解析来源；显式空 encode 返回空集合。 |
| `YSources` | 获取 Y 通道的已解析来源；显式空 encode 返回空集合。 |

## 方法

### `GetSources(String)`

按区分大小写的规范通道名称取得来源；不存在的通道返回共享空集合。

| 参数 | 说明 |
| --- | --- |
| `channel` | 非空白 encode 通道名称。 |

**返回：** 与 schema 生命周期一致的只读来源集合。

### `HasExplicitEncode(String)`

判断调用方是否显式提交过指定 encode 通道，包括显式空通道。

| 参数 | 说明 |
| --- | --- |
| `channel` | 非空白 encode 通道名称。 |

**返回：** 通道在原始 encode presence 中出现时为 `true`。
