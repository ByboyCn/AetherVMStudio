# ChartGaugeData

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

为 Gauge inline data 提供 value、value/name 和富数据项入口。数据通过公共
`ChartDataSnapshot` 管线捕获，不绑定 Cartesian 或 Polar 坐标系。

## 构造函数

### `ChartGaugeData`

创建没有预声明维度和数据项的 Gauge 数据源。

### `ChartGaugeData(TCYM.UI.Chart.Data.ChartValue[])`

从外层标量序列创建 Gauge 数据源；每个参数形成一个独立数据项。

| 参数 | 说明 |
| --- | --- |
| `values` | 按原始顺序排列的值；空数组创建显式空数据源。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取原始数据项数量。 |
| `Dimensions` | 获取可在提交前修改的维度定义。 |
| `Items` | 获取可在提交前修改的 Gauge 数据项。 |
| `Relations` | 获取数据项之间的关系；表格数据通常返回空集合。 |
| `Topology` | 获取数据的逻辑拓扑。 |

## 方法

### `Add(TCYM.UI.Chart.Data.ChartValue,String)`

追加一个 value/name 项。

| 参数 | 说明 |
| --- | --- |
| `value` | 仪表盘显示值。 |
| `name` | 数据项显示名称。 |

**返回：** 当前数据源，便于链式添加。

### `Add(TCYM.UI.Chart.Data.ChartValue)`

追加一个简单 value 项。

| 参数 | 说明 |
| --- | --- |
| `value` | 仪表盘显示值。 |

**返回：** 当前数据源，便于链式添加。

### `Add(TCYM.UI.Chart.Model.ChartGaugeDataItem)`

追加一个携带稳定身份的 Gauge 数据项。

| 参数 | 说明 |
| --- | --- |
| `item` | 待加入的数据项。 |

**返回：** 当前数据源，便于链式添加。

### `CaptureSnapshot`

立即捕获与当前可变集合隔离的公共不可变数据快照。

**返回：** 不再依赖当前 Gauge 数据源可变状态的快照。

### `Clone`

创建维度和数据项均相互隔离的可变副本。

**返回：** 内容等价的新 Gauge 数据源。

### `GetEnumerator`

按原始顺序枚举当前可变 Gauge 数据项。

### `GetItem(Int32)`

按原始索引取得数据项。

| 参数 | 说明 |
| --- | --- |
| `rawIndex` | 数据源中的原始索引。 |

**返回：** 指定位置的数据项，不得返回 `null`。
