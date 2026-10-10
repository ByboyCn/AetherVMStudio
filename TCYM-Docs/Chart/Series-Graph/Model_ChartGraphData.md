# ChartGraphData

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

Graph 节点和边数据源，复用不可变 raw store、关系拓扑和稳定键管线。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取原始数据项数量。 |
| `Dimensions` | 获取值向量各位置对应的维度定义。 |
| `Links` | 提交前可修改的有向边集合。 |
| `Nodes` | 提交前可修改的节点集合。 |
| `Relations` | 按本次节点身份解析并捕获边；错误端点拒绝整次候选。 |
| `Topology` | 获取数据的逻辑拓扑。 |

## 方法

### `Add(TCYM.UI.Chart.Model.ChartGraphNode)`

追加一个节点。

### `AddLink(TCYM.UI.Chart.Model.ChartGraphEdge)`

追加一条边。

### `Clone`

复制整个图，保留身份而隔离所有节点、边和样式。

### `GetEnumerator`

### `GetItem(Int32)`

按原始索引取得数据项。

| 参数 | 说明 |
| --- | --- |
| `rawIndex` | 数据源中的原始索引。 |

**返回：** 指定位置的数据项，不得返回 `null`。
