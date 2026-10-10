# ChartDataRelation

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

表示树父子链接或图边使用的关系元数据。

## 构造函数

### `ChartDataRelation(Int32,Int32,TCYM.UI.Chart.Data.ChartDataRelationKind,Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},String,String,Object)`

创建两个原始数据项之间的关系。

| 参数 | 说明 |
| --- | --- |
| `sourceRawIndex` | 源项的原始索引。 |
| `targetRawIndex` | 目标项的原始索引。 |
| `kind` | 关系类型。 |
| `values` | 关系自身的维度值。 |
| `id` | 关系 ID。 |
| `name` | 关系名称。 |
| `rawItem` | 可选领域对象，须满足数据值不可变或快照契约。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Id` | 获取关系 ID。 |
| `Kind` | 获取关系类型。 |
| `Name` | 获取关系名称。 |
| `RawItem` | 获取已隔离的关系领域对象。 |
| `SourceRawIndex` | 获取源项的原始索引。 |
| `TargetRawIndex` | 获取目标项的原始索引。 |
| `Values` | 获取关系自身的只读值向量。 |
