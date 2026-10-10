# ChartDataSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

原始数据的不可变快照。processor 和 renderer 应通过 `ChartDataStore` 或
`ChartDataView` 读取，不得回到选项中的可变来源对象。对象载荷也会遵循
`IChartImmutableDataValue` / `IChartDataValueSnapshot` 契约。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取原始数据项数量。 |
| `Dimensions` | 获取值向量各位置对应的维度定义。 |
| `Empty` | 获取不含维度、数据项和关系的共享空快照。 |
| `Layout` | 获取表格来源的行列解释方向。非表格或未声明方向的通用来源按<br />`Column` 捕获。 |
| `Relations` | 获取数据项之间的关系；表格数据通常返回空集合。 |
| `SourceTraits` | 获取当前来源声明的有效语义标记组合。 |
| `Topology` | 获取数据的逻辑拓扑。 |

## 方法

### `Capture(TCYM.UI.Chart.Data.IChartDataSource)`

从任意数据源捕获隔离快照；维度不足时会为值向量缺失的位置补充默认维度。

| 参数 | 说明 |
| --- | --- |
| `source` | 待捕获的数据源。 |

**返回：** 不再依赖来源集合可变状态的快照。

### `GetItem(Int32)`

按原始索引取得数据项。

| 参数 | 说明 |
| --- | --- |
| `rawIndex` | 数据源中的原始索引。 |

**返回：** 指定位置的数据项，不得返回 `null`。
