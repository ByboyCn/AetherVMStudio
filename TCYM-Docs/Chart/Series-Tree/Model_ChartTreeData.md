# ChartTreeData

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

Tree 森林数据源；提交时一次迭代捕获节点、样式及父子关系。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 整棵森林的扁平节点数量，不是根节点数量。 |
| `Dimensions` | 获取值向量各位置对应的维度定义。 |
| `Relations` | 获取数据项之间的关系；表格数据通常返回空集合。 |
| `Roots` | 提交前可修改的根节点列表。 |
| `Topology` | 获取数据的逻辑拓扑。 |

## 方法

### `Add(TCYM.UI.Chart.Model.ChartTreeNode)`

追加一个根节点。

### `Clone`

复制森林，保留节点身份并隔离所有子节点、值及样式。

### `GetEnumerator`

### `GetItem(Int32)`

按原始索引取得数据项。

| 参数 | 说明 |
| --- | --- |
| `rawIndex` | 数据源中的原始索引。 |

**返回：** 指定位置的数据项，不得返回 `null`。
