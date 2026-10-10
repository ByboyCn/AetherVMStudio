# ChartDataTable

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

ECharts `dataset` 与 `series.data` 共用的可变二维数据表。
它是输入模型；进入运行时前会被捕获为不可变 `ChartDataSnapshot`。

## 构造函数

### `ChartDataTable`

创建一个不向外部选项节点报告修改的独立数据表。

### `ChartDataTable(Action,TCYM.UI.Chart.Model.ChartTrackedList{TCYM.UI.Chart.Data.ChartDimension},TCYM.UI.Chart.Model.ChartTrackedList{TCYM.UI.Chart.Data.ChartDataRow},TCYM.UI.Chart.Data.ChartDataLayout)`

创建共享只读 backing、但后续写入会独立分离的数据表副本。

| 参数 | 说明 |
| --- | --- |
| `onChanged` | 维度、数据行或布局被写入时执行的回调。 |
| `dimensions` | 已经与来源建立写时复制关系的维度包装。 |
| `rows` | 已经与来源建立写时复制关系的数据行包装。 |
| `layout` | 来源表的布局方向。 |

### `ChartDataTable(Action)`

创建一个会在可观察内容发生写入时报告修改的数据表。

| 参数 | 说明 |
| --- | --- |
| `onChanged` | 维度、数据行或布局被写入时执行的回调。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取原始数据项数量。 |
| `Dimensions` | 获取可变维度列表。 |
| `Item(Int32)` | 按行索引取得输入行。 |
| `Layout` | 获取或设置行列如何映射为系列与数据项。 |
| `Relations` | 获取数据项之间的关系；表格数据通常返回空集合。 |
| `Rows` | 获取可变数据行列表。 |
| `Topology` | 获取数据的逻辑拓扑。 |

## 方法

### `AddDimension(String,TCYM.UI.Chart.Data.ChartDimensionType)`

追加一个维度定义。

| 参数 | 说明 |
| --- | --- |
| `name` | 维度名称。 |
| `type` | 维度类型。 |

**返回：** 当前数据表，便于链式调用。

### `AddItem(Collections.Generic.IEnumerable{Object},String,String,String,Object)`

追加带稳定身份及原始领域对象的数据行。

| 参数 | 说明 |
| --- | --- |
| `values` | 待规范化的行值。 |
| `id` | 业务 ID。 |
| `name` | 显示名称。 |
| `key` | 优先级最高的显式稳定键。 |
| `rawItem` | 领域对象，须满足数据值不可变或快照契约。 |

**返回：** 当前数据表。

### `AddRow(Collections.Generic.IEnumerable{Object})`

追加一个 CLR 对象数据行，并将各值规范化为 `ChartValue`。

| 参数 | 说明 |
| --- | --- |
| `values` | 待规范化的行值。 |

**返回：** 当前数据表。

### `AddRow(TCYM.UI.Chart.Data.ChartValue[])`

追加一个已经规范化为 `ChartValue` 的数据行。

| 参数 | 说明 |
| --- | --- |
| `values` | 行值；构造行时会再次验证对象载荷隔离契约。 |

**返回：** 当前数据表。

### `Clone`

创建可独立修改的数据表副本。维度和不可变 `ChartDataRow` 包装先共享只读 backing，
任一副本首次写入时自动分离，因此克隆成本不随数据行数增长且不会产生可变别名。

**返回：** 内容等价的新数据表。

### `Clone(Action)`

创建内容等价、并把后续写入绑定到指定回调的数据表副本。

| 参数 | 说明 |
| --- | --- |
| `onChanged` | 副本内容发生写入时执行的回调。 |

**返回：** 与当前表内容等价的新数据表。

### `FindDimension(String)`

按区分大小写的名称查找维度。

| 参数 | 说明 |
| --- | --- |
| `name` | 维度名称。 |

**返回：** 首个匹配索引；未找到时返回 -1。

### `FromRows(Collections.Generic.IEnumerable{Collections.Generic.IEnumerable{Object}},Collections.Generic.IEnumerable{String})`

从对象行序列创建表格。

| 参数 | 说明 |
| --- | --- |
| `rows` | 数据行序列。 |
| `dimensions` | 可选维度名称序列。 |

**返回：** 新建的数据表。

### `GetItem(Int32)`

按原始索引取得数据项。

| 参数 | 说明 |
| --- | --- |
| `rawIndex` | 数据源中的原始索引。 |

**返回：** 指定位置的数据项，不得返回 `null`。
