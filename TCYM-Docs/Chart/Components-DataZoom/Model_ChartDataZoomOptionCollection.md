# ChartDataZoomOptionCollection

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示可接受单个节点、数组或 collection expression 的有序 dataZoom 集合；从
`DataZoom` 获取时是 `Components` 的实时视图，
直接构造时则是用于整体赋值且结构独立的输入集合。

## 构造函数

### `ChartDataZoomOptionCollection`

创建空的独立 dataZoom 集合。

### `ChartDataZoomOptionCollection(Collections.Generic.IEnumerable{TCYM.UI.Chart.Model.ChartDataZoomOption})`

创建包含指定 dataZoom 顺序快照的独立集合。

| 参数 | 说明 |
| --- | --- |
| `dataZooms` | 要复制其结构的 dataZoom 序列。 |

### `ChartDataZoomOptionCollection(Int32)`

创建具有指定初始容量的独立 dataZoom 集合。

| 参数 | 说明 |
| --- | --- |
| `capacity` | 预留的 dataZoom 数量。 |

### `ChartDataZoomOptionCollection(TCYM.UI.Chart.Model.ChartDataZoomOptionCollectionCore)`

从已经确定存储模式的核心创建 dataZoom 集合。

| 参数 | 说明 |
| --- | --- |
| `core` | 独立存储或 Components 实时投影核心。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | - |
| `IsReadOnly` | - |
| `Item(Int32)` | - |

## 方法

### `Add(TCYM.UI.Chart.Model.ChartDataZoomOption)`

### `Clear`

### `Contains(TCYM.UI.Chart.Model.ChartDataZoomOption)`

### `CopyTo(TCYM.UI.Chart.Model.ChartDataZoomOption[],Int32)`

### `Create(ReadOnlySpan{TCYM.UI.Chart.Model.ChartDataZoomOption})`

供 C# collection expression 创建强类型 dataZoom 集合。

| 参数 | 说明 |
| --- | --- |
| `dataZooms` | 编译器提供的连续 dataZoom 节点。 |

**返回：** 保持输入顺序的独立 dataZoom 集合。

### `GetEnumerator`

### `IndexOf(TCYM.UI.Chart.Model.ChartDataZoomOption)`

### `Insert(Int32,TCYM.UI.Chart.Model.ChartDataZoomOption)`

### `Remove(TCYM.UI.Chart.Model.ChartDataZoomOption)`

### `RemoveAt(Int32)`
