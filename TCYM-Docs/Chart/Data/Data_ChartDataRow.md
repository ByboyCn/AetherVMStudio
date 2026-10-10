# ChartDataRow

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

表示输入表中的一行。值数组及 `RawItem` 在构造时完成隔离，此后只读。

## 构造函数

### `ChartDataRow(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},String,String,String,Object)`

创建数据行。

| 参数 | 说明 |
| --- | --- |
| `values` | 维度值。 |
| `id` | 业务 ID。 |
| `name` | 显示名称。 |
| `key` | 显式稳定键。 |
| `rawItem` | 领域对象，须满足数据值不可变或快照契约。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Id` | 获取业务 ID。 |
| `Item(Int32)` | 按维度索引取值；越界时返回 `Null`。 |
| `Key` | 获取显式稳定键。 |
| `Name` | 获取显示名称。 |
| `RawItem` | 获取已隔离的领域对象。 |
| `Values` | 获取只读维度值。 |
