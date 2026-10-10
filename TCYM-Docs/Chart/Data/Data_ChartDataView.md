# ChartDataView

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

系列私有的不可变排序/筛选视图，可建立在 raw 或 processed store 上。inside 索引同时映射到
本地 processed-store 索引与 lineage 根 raw 索引；创建新视图不会修改原视图。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取筛选后的 inside 项数量。 |
| `Dimensions` | 获取当前 store 的维度。 |
| `Item(Int32)` | 按 inside 索引创建轻量视图项。 |
| `RawCount` | 获取 lineage 根中的项目总数。 |
| `Store` | 获取视图所引用的不可变 store。 |
| `StoreCount` | 获取应用该视图筛选前，当前 processed store 的项目数。 |
| `Topology` | 获取数据拓扑。 |

## 方法

### `EnumerateRelations`

枚举两端都仍在当前视图中的关系；derived store 的关系索引会规范化回 lineage 根。

### `Filter(Func{TCYM.UI.Chart.Data.ChartDataViewItem,Boolean})`

按谓词筛选当前视图并保留原相对顺序。

| 参数 | 说明 |
| --- | --- |
| `predicate` | 针对当前 inside 项执行的筛选谓词。 |

**返回：** 引用同一 store 的新视图。

### `GetDataIndex(Int32)`

将 view/inside 索引映射到当前 processed-store 索引。

### `GetDataItem(Int32)`

按 inside 索引取得当前 processed store 物化的值和元数据。

### `GetInsideIndex(Int32)`

将 lineage 根 raw 索引映射为 inside 索引；未选中时返回 -1。

### `GetKey(Int32)`

按 inside 索引取得 lineage 根稳定键。

### `GetRawIndex(Int32)`

将 view/inside 索引映射到 lineage 根 raw 索引。

### `GetRawItem(Int32)`

按 inside 索引取得 lineage 根中的原始不可变项。

### `SelectDataIndices(Collections.Generic.IEnumerable{Int32})`

按当前 processed-store 本地索引创建选择视图。

### `SelectRawIndices(Collections.Generic.IEnumerable{Int32})`

按 lineage 根 raw 索引创建选择视图。

| 参数 | 说明 |
| --- | --- |
| `rawIndices` | 按期望视图顺序排列的原始索引。 |

**返回：** 引用同一 store 的新视图。

### `Sort(Comparison{TCYM.UI.Chart.Data.ChartDataViewItem})`

按比较器创建重新排序的视图。

| 参数 | 说明 |
| --- | --- |
| `comparison` | 比较两个当前视图项的函数。 |

**返回：** 引用同一 store 的新视图。
