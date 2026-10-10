# ChartMarkItemSnapshot

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

定义三种 Mark item 快照共同的稳定身份、显示值和宿主 lineage 契约。

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataIndex` | 获取 Mark option Data 中未经无效项过滤的原始 dataIndex。 |
| `DisplayValue` | 获取已经隔离的可选 Label/Tooltip 显示值。 |
| `Id` | 获取可选业务 ID。 |
| `InsideIndex` | 获取无效项过滤后、在同一种 Mark 数据块内连续的 insideIndex。 |
| `Key` | 获取 Mark 类型和块内稳定键。 |
| `Kind` | 获取 Mark 类型。 |
| `Name` | 获取可选显示名称。 |
| `Shape` | 获取数据形态。 |
| `SourceLineages` | 获取该项全部位置分量引用的去重宿主 lineage。 |
