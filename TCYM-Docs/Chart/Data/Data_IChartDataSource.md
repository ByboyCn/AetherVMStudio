# IChartDataSource

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

表格、层级和关系系列共用的原始数据契约。实现可以是可变的，但图表会在 processor 运行前
通过 `ChartDataSnapshot` 捕获不可变快照；实现不应依赖捕获后的外部修改。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取原始数据项数量。 |
| `Dimensions` | 获取值向量各位置对应的维度定义。 |
| `Relations` | 获取数据项之间的关系；表格数据通常返回空集合。 |
| `Topology` | 获取数据的逻辑拓扑。 |

## 方法

### `GetItem(Int32)`

按原始索引取得数据项。

| 参数 | 说明 |
| --- | --- |
| `rawIndex` | 数据源中的原始索引。 |

**返回：** 指定位置的数据项，不得返回 `null`。
