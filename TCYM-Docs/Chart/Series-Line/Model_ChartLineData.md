# ChartLineData

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

为 Line inline data 提供标量、任意非空值向量和富数据项的表格数据源。提交给系列后仍由公共
`ChartDataSnapshot`、schema、encode 与 lineage 管线统一处理。

## 构造函数

### `ChartLineData`

创建没有预声明维度和数据项的 Line 数据源。

### `ChartLineData(TCYM.UI.Chart.Data.ChartValue[])`

从 ECharts 风格的外层标量序列创建 Line 数据源；每个参数形成一个独立标量数据项。

| 参数 | 说明 |
| --- | --- |
| `values` | 按原始数据顺序排列的标量；空数组创建显式空数据源。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取原始数据项数量。 |
| `Dimensions` | 获取可在提交前修改的维度定义。 |
| `Items` | 获取可在提交前修改的 Line 数据项。 |
| `Relations` | 获取数据项之间的关系；表格数据通常返回空集合。 |
| `SourceTraits` | 获取 Line 强类型数据已冻结的一维简写语义；公共 schema 只在单维 inline 且没有<br />显式 encode 时把它解释为 `rawIndex/value`。 |
| `Topology` | 获取数据的逻辑拓扑。 |

## 方法

### `Add(TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue[])`

追加一个具有三个或更多维度的值向量。

| 参数 | 说明 |
| --- | --- |
| `first` | 第一个值维度。 |
| `second` | 第二个值维度。 |
| `third` | 第三个值维度。 |
| `remaining` | 按顺序排列的其余值维度。 |

**返回：** 当前数据源，便于链式添加和多参数集合初始化。

### `Add(TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue)`

追加一个 X/Y 二维项。

| 参数 | 说明 |
| --- | --- |
| `x` | 第一个值维度。 |
| `y` | 第二个值维度。 |

**返回：** 当前数据源，便于链式添加。

### `Add(TCYM.UI.Chart.Data.ChartValue)`

追加一个简单标量项。

| 参数 | 说明 |
| --- | --- |
| `value` | 唯一数值维度。 |

**返回：** 当前数据源，便于链式添加。

### `Add(TCYM.UI.Chart.Model.ChartLineDataItem)`

追加一个富 Line 数据项。

| 参数 | 说明 |
| --- | --- |
| `item` | 待加入的数据项。 |

**返回：** 当前数据源，便于链式添加。

### `AddValue(TCYM.UI.Chart.Data.ChartValue,String,String,String)`

追加带可选Name/Id/Key的纯标量项，不创建逐项样式和状态对象。

### `Clone`

创建维度和数据项均相互隔离的可变副本。

**返回：** 内容等价的新 Line 数据源。

### `GetEnumerator`

按原始顺序枚举当前可变 Line 数据项。

**返回：** 直接读取当前数据项顺序的枚举器。

### `GetItem(Int32)`

按原始索引取得数据项。

| 参数 | 说明 |
| --- | --- |
| `rawIndex` | 数据源中的原始索引。 |

**返回：** 指定位置的数据项，不得返回 `null`。
