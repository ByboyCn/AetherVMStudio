# ChartBrushOptionCollection

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示可接受单个节点、数组或 collection expression 的有序 Brush 集合；绑定到
`ChartOption` 时直接投影其唯一 Components 存储。

## 构造函数

### `ChartBrushOptionCollection`

创建空的独立 Brush 集合。

### `ChartBrushOptionCollection(Collections.Generic.IEnumerable{TCYM.UI.Chart.Model.ChartBrushOption})`

创建保持输入顺序且结构独立的 Brush 集合。

| 参数 | 说明 |
| --- | --- |
| `brushes` | 待复制其结构的 Brush 节点。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | - |
| `IsReadOnly` | - |
| `Item(Int32)` | - |

## 方法

### `Add(TCYM.UI.Chart.Model.ChartBrushOption)`

### `Clear`

### `Contains(TCYM.UI.Chart.Model.ChartBrushOption)`

### `CopyTo(TCYM.UI.Chart.Model.ChartBrushOption[],Int32)`

### `Create(ReadOnlySpan{TCYM.UI.Chart.Model.ChartBrushOption})`

供 collection expression 创建独立 Brush 集合。

| 参数 | 说明 |
| --- | --- |
| `brushes` | 编译器提供的连续 Brush 节点。 |

**返回：** 保持输入顺序的独立集合。

### `GetEnumerator`

### `IndexOf(TCYM.UI.Chart.Model.ChartBrushOption)`

### `Insert(Int32,TCYM.UI.Chart.Model.ChartBrushOption)`

### `Remove(TCYM.UI.Chart.Model.ChartBrushOption)`

### `RemoveAt(Int32)`
