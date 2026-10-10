# ChartRawDataItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

表示一个原始数据项。`Values` 保存通用向量表示，`RawItem`
则保留树节点、图节点、K 线等富数据的领域对象。构造时会隔离对象载荷。

## 构造函数

### `ChartRawDataItem(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},String,String,String,Object,Boolean)`

创建能够区分标量与值向量语法的原始数据项并捕获领域对象载荷。

| 参数 | 说明 |
| --- | --- |
| `values` | 维度值序列。 |
| `id` | 业务 ID。 |
| `name` | 显示名称，也可作为次级稳定身份。 |
| `key` | 显式稳定键，优先级高于 ID 和名称。 |
| `rawItem` | 可选领域对象，须满足数据值不可变或快照契约。 |
| `isScalarSyntax` | 原始项是否由标量而非值向量语法创建。 |

### `ChartRawDataItem(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},String,String,String,Object)`

按历史五参数入口创建原始数据项并捕获值和领域对象载荷。

| 参数 | 说明 |
| --- | --- |
| `values` | 维度值序列。 |
| `id` | 业务 ID。 |
| `name` | 显示名称，也可作为次级稳定身份。 |
| `key` | 显式稳定键，优先级高于 ID 和名称。 |
| `rawItem` | 可选领域对象，须满足数据值不可变或快照契约。 |

### `ChartRawDataItem(TCYM.UI.Chart.Data.ChartValue[],String,String,String,Object,Boolean,Boolean)`

实现内置来源的单次复制路径；公开构造函数仍逐值捕获。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Id` | 获取业务 ID。 |
| `IsScalarSyntax` | 获取原始项是否由标量而不是值向量语法创建。 |
| `Item(Int32)` | 按维度索引取值；越界时返回 `Null`。 |
| `Key` | 获取显式稳定身份；其优先级高于 `Id` 和 `Name`。 |
| `Name` | 获取显示名称。 |
| `RawItem` | 获取已隔离的原始领域对象。 |
| `Values` | 获取只读维度值。 |
