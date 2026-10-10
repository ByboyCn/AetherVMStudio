# ChartDataViewItem

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

按 inside 索引访问一个系列视图项的轻量只读句柄。

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataIndex` | 获取该项在当前 processed store 中的本地索引。 |
| `Id` | 获取当前物化项的业务 ID。 |
| `InsideIndex` | 获取该项在当前视图中的 inside 索引。 |
| `IsScalarSyntax` | 获取 lineage 根原始项是否由标量语法创建。 |
| `Item(Int32)` | 按维度索引取得当前物化值。 |
| `Key` | 获取 lineage 根稳定键。 |
| `Name` | 获取当前物化项的名称。 |
| `RawIndex` | 获取该项在 lineage 根中的 raw 索引。 |
| `RawItem` | 获取原始项中已隔离的领域对象。 |
| `RawSource` | 获取处理前 lineage 根中的原始不可变项。 |
| `Source` | 获取当前 processed store 物化的数据项。 |
| `Values` | 获取当前物化项的只读值向量。 |
| `View` | 获取所属数据视图。 |
