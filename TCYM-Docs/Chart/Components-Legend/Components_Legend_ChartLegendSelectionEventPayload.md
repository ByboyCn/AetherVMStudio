# ChartLegendSelectionEventPayload

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Legend`　**Chart 版本**：`0.1.1.25`

## 概述

保存 Legend 选择 action 发布的不可变语义事件负载。

## 构造函数

### `ChartLegendSelectionEventPayload(String,Collections.Generic.IEnumerable{Collections.Generic.KeyValuePair{String,Boolean}},Collections.Generic.IEnumerable{Int32})`

创建一份选择事件快照。

| 参数 | 说明 |
| --- | --- |
| `name` | 单项 action 的名称；全选和反选时为空。 |
| `selected` | 全部活动 Legend 按同名 AND 聚合后的选择状态。 |
| `legendIndices` | 本次 action 查询命中的 Legend 同类索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `LegendIndices` | 获取本次 action 查询命中的 Legend 同类索引。 |
| `Name` | 获取单项 action 的名称；全选和反选时返回 `null`。 |
| `Selected` | 获取全部活动 Legend 按同名 AND 聚合后的只读选择快照。 |
