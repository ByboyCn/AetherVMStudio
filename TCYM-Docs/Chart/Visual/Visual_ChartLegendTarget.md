# ChartLegendTarget

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Visual`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Legend 选择状态映射到系列或数据项时使用的不可变规范身份。等值只依赖系列运行时身份
与可选数据键；强类型键保留来源、值和重复序号，旧字符串键保留独立的兼容身份空间。
显示名称、显式 ID 和系列类型仅用于诊断及事件投影。

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataIndex` | 获取 presentation 已知的原始数据索引；系列目标或未知时为 -1。 |
| `DataIndexInside` | 获取系列公开 presentation 中的已知数据索引；系列目标或未知时为 -1。 |
| `DataKey` | 获取旧字符串工厂提供的稳定键；强类型目标返回兼容的 `Kind:Value#Occurrence` 展示文本，不能代替<br />`TypedDataKey` 参与规范等值判断；系列目标返回 `null`。 |
| `Kind` | 获取目标种类。 |
| `SeriesId` | 获取创建目标时系列的显式 ID。 |
| `SeriesIndex` | 获取 presentation 已知的系列索引；未知时为 -1。 |
| `SeriesName` | 获取创建目标时系列的显示名称。 |
| `SeriesType` | 获取系列注册类型，例如 `line`、`bar` 或自定义系列类型。 |
| `TypedDataKey` | 获取强类型工厂提供的完整数据键；旧字符串目标和系列目标返回 `null`。 |

## 方法

### `Equals(Object)`

### `Equals(TCYM.UI.Chart.Visual.ChartLegendTarget)`

### `ForDataItem(TCYM.UI.Chart.Model.ChartSeriesOption,String,Int32,Int32,Int32)`

为系列中的稳定数据项创建 Legend 目标。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效配置或保留同一规范身份的系列快照。 |
| `dataKey` | 由系列定义、跨处理视图索引变化仍稳定的非空数据键。 |
| `seriesIndex` | 当前 effective option 中的系列索引；未知时保留 -1。 |
| `dataIndex` | 原始数据中的稳定索引；未知时保留 -1。 |
| `dataIndexInside` | 系列公开 presentation 索引；未知时保留 -1。 |

**返回：** 由系列身份和数据键共同标识的不可变目标。

### `ForSeries(TCYM.UI.Chart.Model.ChartSeriesOption,Int32)`

为整个系列创建稳定 Legend 目标。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效配置或保留同一规范身份的系列快照。 |
| `seriesIndex` | 当前 effective option 中的系列索引；未知时保留 -1。 |

**返回：** 以系列运行时身份为键的不可变目标。

### `ForTypedDataItem(TCYM.UI.Chart.Model.ChartSeriesOption,TCYM.UI.Chart.Data.ChartDataKey,Int32,Int32,Int32)`

为系列中的强类型稳定数据项创建 Legend 目标。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效配置或保留同一规范身份的系列快照。 |
| `dataKey` | 包含来源、值和重复序号的强类型规范数据键。 |
| `seriesIndex` | 当前 effective option 中的系列索引；未知时保留 -1。 |
| `dataIndex` | 原始数据中的稳定索引；未知时保留 -1。 |
| `dataIndexInside` | 系列公开 presentation 索引；未知时保留 -1。 |

**返回：** 由系列身份和完整强类型数据键共同标识的不可变目标。

### `GetHashCode`

### `MatchesDataItem(TCYM.UI.Chart.Model.ChartSeriesOption,String)`

判断当前目标是否精确表示指定系列中的数据项。

| 参数 | 说明 |
| --- | --- |
| `series` | 待匹配系列。 |
| `dataKey` | 待匹配的稳定数据键。 |

**返回：** 系列身份和数据键均相同时为 `true`。

### `MatchesSeries(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断当前目标是否精确表示指定整个系列。

| 参数 | 说明 |
| --- | --- |
| `series` | 待匹配系列。 |

**返回：** 目标种类为系列且 canonical identity 相同时为 `true`。

### `MatchesTypedDataItem(TCYM.UI.Chart.Model.ChartSeriesOption,TCYM.UI.Chart.Data.ChartDataKey)`

判断当前目标是否精确表示指定系列中的强类型数据项。

| 参数 | 说明 |
| --- | --- |
| `series` | 待匹配系列。 |
| `dataKey` | 待匹配的完整强类型稳定数据键。 |

**返回：** 系列身份、键来源、键值和重复序号均相同时为 `true`。
