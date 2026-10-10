# ChartFormatterParameters

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Text`　**Chart 版本**：`0.1.1.25`

## 概述

为公共文本 formatter 提供强类型、只读且已经隔离的数据快照。

## 说明

构造函数会复制维度集合、冻结区域性，并通过图表数据隔离门禁捕获原始数据。
因此 formatter 不能通过调用方随后修改输入集合或可变领域对象来污染当前构建。

## 构造函数

### `ChartFormatterParameters(String,String,String,Int32,Int32,Int32,String,TCYM.UI.Chart.Data.ChartValue,Collections.Generic.IReadOnlyList{String},Collections.Generic.IReadOnlyList{TCYM.UI.Chart.Data.ChartValue},Nullable{Double},Nullable{SkiaSharp.SKColor},Object,Globalization.CultureInfo,Collections.Generic.IReadOnlyDictionary{String,Collections.Generic.IReadOnlyList{String}})`

初始化一份包含公共 encode 映射的完整 formatter 参数快照。

| 参数 | 说明 |
| --- | --- |
| `componentType` | 组件主类型；非组件上下文可为空。 |
| `seriesType` | 系列子类型；非系列上下文可为空。 |
| `seriesName` | 系列名称；非系列上下文可为空。 |
| `seriesIndex` | 系列索引；非系列上下文使用 -1。 |
| `dataIndex` | 数据项在原始数据中的索引；非数据项上下文使用 -1。 |
| `dataIndexInside` | 数据项在系列当前公开 presentation 中的索引；非数据项上下文使用 -1。 |
| `name` | 当前数据项或组件名称。 |
| `value` | 当前主值。 |
| `dimensionNames` | 按存储顺序排列的维度名称；为空表示没有维度名称。 |
| `dimensionValues` | 与维度名称对应的值；为空表示没有维度值。 |
| `percent` | 当前数据项的百分比数值；不自动附加百分号。 |
| `color` | 当前数据项的确定颜色；没有确定颜色时为空。 |
| `rawData` | 原始领域数据；自定义引用必须满足<br />`IChartImmutableDataValue` 或 `IChartDataValueSnapshot` 契约。 |
| `culture` | 格式化数字和时间所使用的显式区域性。 |
| `encode` | encode 通道到维度名称序列的映射；为空表示没有通道，显式空通道会被保留。 |

### `ChartFormatterParameters(String,String,String,Int32,Int32,Int32,String,TCYM.UI.Chart.Data.ChartValue,Collections.Generic.IReadOnlyList{String},Collections.Generic.IReadOnlyList{TCYM.UI.Chart.Data.ChartValue},Nullable{Double},Nullable{SkiaSharp.SKColor},Object,Globalization.CultureInfo)`

初始化一份完整的 formatter 参数快照。

| 参数 | 说明 |
| --- | --- |
| `componentType` | 组件主类型；非组件上下文可为空。 |
| `seriesType` | 系列子类型；非系列上下文可为空。 |
| `seriesName` | 系列名称；非系列上下文可为空。 |
| `seriesIndex` | 系列索引；非系列上下文使用 -1。 |
| `dataIndex` | 数据项在原始数据中的索引；非数据项上下文使用 -1。 |
| `dataIndexInside` | 数据项在系列当前公开 presentation 中的索引；非数据项上下文使用 -1。 |
| `name` | 当前数据项或组件名称。 |
| `value` | 当前主值。 |
| `dimensionNames` | 按存储顺序排列的维度名称；为空表示没有维度名称。 |
| `dimensionValues` | 与维度名称对应的值；为空表示没有维度值。 |
| `percent` | 当前数据项的百分比数值；不自动附加百分号。 |
| `color` | 当前数据项的确定颜色；没有确定颜色时为空。 |
| `rawData` | 原始领域数据；自定义引用必须满足<br />`IChartImmutableDataValue` 或 `IChartDataValueSnapshot` 契约。 |
| `culture` | 格式化数字和时间所使用的显式区域性。 |

### `ChartFormatterParameters(String,String,String,Int32,Int32,Int32,String,TCYM.UI.Chart.Text.ChartFormatterValue,TCYM.UI.Chart.Data.ChartValue,Collections.Generic.IReadOnlyList{String},Collections.Generic.IReadOnlyList{TCYM.UI.Chart.Data.ChartValue},Nullable{Double},Nullable{SkiaSharp.SKColor},Object,Globalization.CultureInfo,Collections.Generic.IReadOnlyDictionary{String,Collections.Generic.IReadOnlyList{String}})`

初始化一份包含显式值形状和公共 encode 映射的 formatter 参数快照。

| 参数 | 说明 |
| --- | --- |
| `componentType` | 组件主类型；非组件上下文可为空。 |
| `seriesType` | 系列子类型；非系列上下文可为空。 |
| `seriesName` | 系列名称；非系列上下文可为空。 |
| `seriesIndex` | 系列索引；非系列上下文使用 -1。 |
| `dataIndex` | 数据项在原始数据中的索引；非数据项上下文使用 -1。 |
| `dataIndexInside` | 数据项在系列当前公开 presentation 中的索引；非数据项上下文使用 -1。 |
| `name` | 当前数据项或组件名称。 |
| `value` | 保持原始标量或向量语法形状的 formatter 值。 |
| `primaryValue` | 系列确定的主显示值；向量通常取 value encode 对应维度。 |
| `dimensionNames` | 按存储顺序排列的维度名称；为空表示没有维度名称。 |
| `dimensionValues` | 与维度名称对应的值；为空表示没有维度值。 |
| `percent` | 当前数据项的百分比数值；不自动附加百分号。 |
| `color` | 当前数据项的确定颜色；没有确定颜色时为空。 |
| `rawData` | 原始领域数据；自定义引用必须满足<br />`IChartImmutableDataValue` 或 `IChartDataValueSnapshot` 契约。 |
| `culture` | 格式化数字和时间所使用的显式区域性。 |
| `encode` | encode 通道到维度名称序列的映射；为空表示没有通道，显式空通道会被保留。 |

### `ChartFormatterParameters(String,String,String,Int32,Int32,Int32,String,TCYM.UI.Chart.Text.ChartFormatterValue,TCYM.UI.Chart.Data.ChartValue,Collections.Generic.IReadOnlyList{String},Collections.Generic.IReadOnlyList{TCYM.UI.Chart.Data.ChartValue},Nullable{Double},Nullable{SkiaSharp.SKColor},Object,Globalization.CultureInfo)`

使用显式标量或向量值初始化一份完整的 formatter 参数快照。

| 参数 | 说明 |
| --- | --- |
| `componentType` | 组件主类型；非组件上下文可为空。 |
| `seriesType` | 系列子类型；非系列上下文可为空。 |
| `seriesName` | 系列名称；非系列上下文可为空。 |
| `seriesIndex` | 系列索引；非系列上下文使用 -1。 |
| `dataIndex` | 数据项在原始数据中的索引；非数据项上下文使用 -1。 |
| `dataIndexInside` | 数据项在系列当前公开 presentation 中的索引；非数据项上下文使用 -1。 |
| `name` | 当前数据项或组件名称。 |
| `value` | 保持原始标量或向量语法形状的 formatter 值。 |
| `primaryValue` | 系列确定的主显示值；向量通常取 value encode 对应维度。 |
| `dimensionNames` | 按存储顺序排列的维度名称；为空表示没有维度名称。 |
| `dimensionValues` | 与维度名称对应的值；为空表示没有维度值。 |
| `percent` | 当前数据项的百分比数值；不自动附加百分号。 |
| `color` | 当前数据项的确定颜色；没有确定颜色时为空。 |
| `rawData` | 原始领域数据；自定义引用必须满足<br />`IChartImmutableDataValue` 或 `IChartDataValueSnapshot` 契约。 |
| `culture` | 格式化数字和时间所使用的显式区域性。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Color` | 获取当前数据项的确定颜色。 |
| `ComponentType` | 获取组件主类型。 |
| `Culture` | 获取数字和时间格式化使用的只读区域性；默认结构使用 invariant culture。 |
| `DataIndex` | 获取原始数据索引；非数据项上下文为 -1。 |
| `DataIndexInside` | 获取系列当前公开 presentation 中的索引；非数据项上下文为 -1。 |
| `DimensionNames` | 获取维度名称的只读快照。 |
| `DimensionValues` | 获取维度值的只读快照。 |
| `Empty` | 获取不属于任何系列或数据项的显式空参数；全部非适用索引均为 -1。 |
| `Encode` | 获取 encode 通道到维度名称序列的深度只读快照；默认结构返回空映射。 |
| `Name` | 获取当前数据项或组件名称。 |
| `Percent` | 获取当前百分比数值；文本模板不会自动附加百分号。 |
| `PrimaryValue` | 获取系列确定的主显示值；向量通常取 value encode 对应维度。 |
| `RawData` | 获取通过图表数据隔离门禁捕获的原始领域数据。 |
| `SeriesIndex` | 获取系列索引；非系列上下文为 -1。 |
| `SeriesName` | 获取系列名称。 |
| `SeriesType` | 获取系列子类型。 |
| `Value` | 获取保持原始输入语法形状的标量或向量值。 |

## 方法

### `FormatValue`

使用当前显式区域性格式化保持输入形状的 formatter 值。

**返回：** 标量按自身 CLR 时间和数值语义格式化；向量逐项格式化并使用半角逗号连接。

### `TryGetDimension(Int32,TCYM.UI.Chart.Data.ChartValue@)`

按零基索引尝试取得维度值。

| 参数 | 说明 |
| --- | --- |
| `dimensionIndex` | 维度值索引。 |
| `value` | 找到时得到维度值；否则为空值。 |

**返回：** 索引位于值快照范围内时返回 `true`。

### `TryGetDimension(String,TCYM.UI.Chart.Data.ChartValue@)`

按名称尝试取得第一个同名维度值。

| 参数 | 说明 |
| --- | --- |
| `dimensionName` | 区分大小写的维度名称。 |
| `value` | 找到时得到维度值；否则为空值。 |

**返回：** 名称和值索引均存在时返回 `true`。
