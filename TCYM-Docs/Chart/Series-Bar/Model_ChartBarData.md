# ChartBarData

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

为 Bar inline data 提供标量、二维值和富数据项的表格数据源。提交后仍由公共
`ChartDataSnapshot`、schema、encode 与 lineage 管线统一处理。

## 构造函数

### `ChartBarData`

创建没有预声明维度和数据项的 Bar 数据源。

### `ChartBarData(TCYM.UI.Chart.Data.ChartValue[])`

从 ECharts 风格的外层标量序列创建 Bar 数据源；每个参数形成一个独立标量数据项。

| 参数 | 说明 |
| --- | --- |
| `values` | 按原始数据顺序排列的标量；空数组创建显式空数据源。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取原始数据项数量。 |
| `Dimensions` | 获取可在提交前修改的维度定义。 |
| `Items` | 获取可在提交前修改的 Bar 数据项。 |
| `Relations` | 获取数据项之间的关系；表格数据通常返回空集合。 |
| `SourceTraits` | 获取 Bar 强类型数据的一维简写语义；单维 inline 且没有显式 encode 时映射为<br />`rawIndex/value`。 |
| `Topology` | 获取数据的逻辑拓扑。 |

## 方法

### `Add(TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue)`

追加一个保持紧凑 RawItem 的 X/Y 二维项。

| 参数 | 说明 |
| --- | --- |
| `x` | 第一个值维度。 |
| `y` | 第二个值维度。 |

**返回：** 当前数据源，便于链式添加。

### `Add(TCYM.UI.Chart.Data.ChartValue)`

追加一个保持紧凑 RawItem 的简单标量项。

| 参数 | 说明 |
| --- | --- |
| `value` | 唯一值维度。 |

**返回：** 当前数据源，便于链式添加。

### `Add(TCYM.UI.Chart.Model.ChartBarDataItem)`

追加一个可携带逐项覆盖的富 Bar 数据项。

| 参数 | 说明 |
| --- | --- |
| `item` | 待加入的数据项。 |

**返回：** 当前数据源，便于链式添加。

### `Clone`

创建维度和数据项均相互隔离的可变副本。

**返回：** 内容等价的新 Bar 数据源。

### `GetItem(Int32)`

按原始索引取得数据项。

| 参数 | 说明 |
| --- | --- |
| `rawIndex` | 数据源中的原始索引。 |

**返回：** 指定位置的数据项，不得返回 `null`。
