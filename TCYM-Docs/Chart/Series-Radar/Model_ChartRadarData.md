# ChartRadarData

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

Radar inline 多维向量数据源，仍走公共快照、维度及 lineage 管线。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取原始数据项数量。 |
| `Dimensions` | 获取可在提交前修改的维度定义。 |
| `Items` | 获取可在提交前修改的数据项。 |
| `Relations` | 获取数据项之间的关系；表格数据通常返回空集合。 |
| `Topology` | 获取数据的逻辑拓扑。 |

## 方法

### `Add(TCYM.UI.Chart.Data.ChartValue[])`

追加一个完整指标向量。

### `Add(TCYM.UI.Chart.Model.ChartRadarDataItem)`

追加一个富数据项。

### `Clone`

创建独立数据源副本。

### `GetEnumerator`

### `GetItem(Int32)`

按原始索引取得数据项。

| 参数 | 说明 |
| --- | --- |
| `rawIndex` | 数据源中的原始索引。 |

**返回：** 指定位置的数据项，不得返回 `null`。
