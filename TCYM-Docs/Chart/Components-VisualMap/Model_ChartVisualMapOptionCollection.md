# ChartVisualMapOptionCollection

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示可接受单个节点、数组或 collection expression 的有序 VisualMap 集合。
从 ChartOption 获取时直接写穿唯一 Components 存储。

## 构造函数

### `ChartVisualMapOptionCollection`

创建空的独立 VisualMap 集合。

### `ChartVisualMapOptionCollection(Collections.Generic.IEnumerable{TCYM.UI.Chart.Model.ChartVisualMapOption})`

创建保持来源顺序的独立集合。

| 参数 | 说明 |
| --- | --- |
| `visualMaps` | 待复制的 VisualMap 节点。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | - |
| `IsReadOnly` | - |
| `Item(Int32)` | - |

## 方法

### `Add(TCYM.UI.Chart.Model.ChartVisualMapOption)`

### `Clear`

### `Contains(TCYM.UI.Chart.Model.ChartVisualMapOption)`

### `CopyTo(TCYM.UI.Chart.Model.ChartVisualMapOption[],Int32)`

### `Create(ReadOnlySpan{TCYM.UI.Chart.Model.ChartVisualMapOption})`

供 collection expression 创建强类型集合。

### `GetEnumerator`

### `IndexOf(TCYM.UI.Chart.Model.ChartVisualMapOption)`

### `Insert(Int32,TCYM.UI.Chart.Model.ChartVisualMapOption)`

### `Remove(TCYM.UI.Chart.Model.ChartVisualMapOption)`

### `RemoveAt(Int32)`
