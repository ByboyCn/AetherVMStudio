# ChartLegendRuntimeState

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Legend`　**Chart 版本**：`0.1.1.25`

## 概述

保存单个 Legend 组件由所属 `ChartEngine` 独占的选择与分页状态。全部字段均为深度
不可变快照；普通 option merge 可保留该状态，而组件身份退休时由 Engine 自动清理。

## 构造函数

### `ChartLegendRuntimeState(Collections.Generic.IEnumerable{Collections.Generic.KeyValuePair{String,Boolean}},Int64,Int32,Int64,String)`

创建一份不可变 Legend 运行时状态。

| 参数 | 说明 |
| --- | --- |
| `selected` | 按区分大小写名称保存的完整选择状态。 |
| `selectionOptionRevision` | 产生选择种子的 option 修订号。 |
| `scrollDataIndex` | 当前分页起始数据索引。 |
| `scrollOptionRevision` | 产生分页种子的 option 修订号。 |
| `dataSignature` | 产生状态时的 Legend 名称集合签名。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataSignature` | 获取产生当前状态时的 Legend 名称集合签名；外部构造的旧状态可为空。 |
| `ScrollDataIndex` | 获取当前分页起始数据索引。 |
| `ScrollOptionRevision` | 获取产生当前分页种子的 option 修订号。 |
| `Selected` | 获取按区分大小写名称索引的完整只读选择快照。 |
| `SelectionOptionRevision` | 获取产生当前选择种子的 option 修订号。 |
