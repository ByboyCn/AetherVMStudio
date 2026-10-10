# ChartDataStore

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

捕获数据源后的不可变存储。逻辑 raw store 拥有稳定身份；processed store 通过显式一对一
lineage 映射回 raw store。多个系列可共享 store，但各自必须持有独立的
`ChartDataView`，避免筛选或排序互相污染。

## 属性

| 名称 | 说明 |
| --- | --- |
| `DimensionCount` | 获取维度数量。 |
| `Dimensions` | 获取当前 store 中值向量的维度。 |
| `Empty` | 获取共享的空数据 store。 |
| `IsDerived` | 获取该 store 是否包含映射到另一个 raw store 的处理后值。 |
| `LineageRoot` | 获取定义稳定数据身份的 lineage 根 store。根 store 返回自身；processed store 返回<br />对应系列的不可变 raw store。 |
| `OriginalRawCount` | 获取 lineage 根 store 中的数据项数量。 |
| `ProjectionKind` | 获取构造该逻辑 raw store 时使用的源方向投影。 |
| `ProjectionSource` | 获取方向投影的物理来源 store。它不是 lineage 根：行投影会改变逻辑数据项轴，<br />因而投影后的列会形成新的 raw 身份空间。 |
| `RawCount` | 获取当前 store 的本地数据项数量。 |
| `RawData` | 获取该 store 持有的不可变数据快照。 |
| `SourceTraits` | 获取不可变原始快照保留的数据源解释语义；方向投影会通过新快照清除不再适用的标记。 |
| `Topology` | 获取数据拓扑。 |

## 方法

### `Capture(TCYM.UI.Chart.Data.IChartDataSource)`

捕获数据源并创建不可变根 store。

| 参数 | 说明 |
| --- | --- |
| `source` | 数据源。 |

**返回：** 拥有独立快照与稳定身份的新 store。

### `CreateDerived(TCYM.UI.Chart.Data.IChartDataSource,Collections.Generic.IReadOnlyList{Int32})`

创建 processed store，其每个数据项一对一映射到当前 `LineageRoot` 的索引。
映射必须为每个处理后项提供唯一原始索引；聚合或展开等非一对一 transform 应使用专用 artifact。

### `CreateView`

创建包含当前 store 全部本地项的独立视图。

### `GetDataIndex(Int32)`

将 lineage 根索引映射到当前 store；不存在时返回 -1。

### `GetKey(Int32)`

按本地数据索引取得 lineage 根生成的稳定身份。

### `GetLocalKey(Int32)`

获取由本地处理后值生成的身份。渲染和 diff 通常应使用 `GetKey`；
此成员主要用于 transform 诊断。

### `GetOriginalRawIndex(Int32)`

将当前 store 的本地索引映射为 lineage 根的原始索引。

### `GetOriginalRawItem(Int32)`

按 processed store 本地索引取得 lineage 根中的原始不可变项。

### `GetRawItem(Int32)`

按当前 store 的本地索引取得数据项。

### `ToTable(TCYM.UI.Chart.Data.ChartDataLayout)`

创建兼容性数据表副本；修改返回表不会影响当前 store。

| 参数 | 说明 |
| --- | --- |
| `layout` | 返回表的布局方向。 |

**返回：** 可独立修改的数据表。

### `TryAppend(TCYM.UI.Chart.Data.IChartDataSource,TCYM.UI.Chart.Data.ChartDataStore@,TCYM.UI.Chart.Data.ChartDataAppendValidation@)`

尝试创建包含当前与新增数据的新 store。当前 store 及其 raw 快照始终保持不变。

### `ValidateAppend(TCYM.UI.Chart.Data.ChartDataSnapshot)`

在来源已捕获后验证拓扑、维度数量、名称与类型兼容性；方法只返回诊断，不修改当前 store。

| 参数 | 说明 |
| --- | --- |
| `incoming` | 待追加的不可变快照。 |

**返回：** 结构兼容性结果。

### `ValidateAppend(TCYM.UI.Chart.Data.IChartDataSource)`

验证数据源能否追加到当前根 store，但不执行修改。

| 参数 | 说明 |
| --- | --- |
| `source` | 待追加数据源。 |

**返回：** 包含结构兼容性与诊断信息的验证结果。
