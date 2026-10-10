# ChartMarkSourceLineage

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个规范化 Mark 位置分量所引用的宿主系列数据 lineage。
Source 是当前处理后数据项，RawSource 是 lineage 根数据项，二者均在构造时深度隔离。

## 构造函数

### `ChartMarkSourceLineage(TCYM.UI.Chart.Data.ChartDataKey,Int32,Int32,Int32,TCYM.UI.Chart.Data.ChartRawDataItem,TCYM.UI.Chart.Data.ChartRawDataItem)`

创建一份与调用方数据项不共享可变载荷的宿主 lineage 快照。

| 参数 | 说明 |
| --- | --- |
| `dataKey` | 宿主系列数据项的稳定键。 |
| `rawIndex` | lineage 根 rawIndex。 |
| `dataIndex` | 当前处理链中数据项对应的 processed dataIndex。 |
| `insideIndex` | 当前处理后数据视图的 insideIndex。 |
| `source` | 当前处理后数据项。 |
| `rawSource` | lineage 根数据项。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataIndex` | 获取当前处理链中数据项对应的 processed dataIndex。 |
| `DataKey` | 获取宿主系列数据项的稳定键。 |
| `InsideIndex` | 获取当前处理后数据视图的 insideIndex。 |
| `RawIndex` | 获取 lineage 根 rawIndex。 |
| `RawSource` | 获取已经隔离的 lineage 根数据项。 |
| `Source` | 获取已经隔离的当前处理后数据项。 |

## 方法

### `FromDataItem(TCYM.UI.Chart.Data.ChartDataViewItem)`

从当前处理后数据视图项创建完整 raw/data/inside lineage 快照。

| 参数 | 说明 |
| --- | --- |
| `item` | 有效 ChartDataViewItem。 |

**返回：** 已深度隔离 source 与 rawSource 的 lineage。
