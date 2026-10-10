# ChartXAxisOptionCollection

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示可接受单轴、数组或 collection expression 的有序 X 轴集合；从
`XAxis` 获取时是 `Components` 的实时视图，
直接构造时则是用于整体赋值且结构独立的输入集合。

## 构造函数

### `ChartXAxisOptionCollection`

创建空的独立 X 轴集合。

### `ChartXAxisOptionCollection(Collections.Generic.IEnumerable{TCYM.UI.Chart.Model.ChartXAxisOption})`

创建包含指定 X 轴顺序快照的独立集合。

| 参数 | 说明 |
| --- | --- |
| `axes` | 要复制其结构的 X 轴序列。 |

### `ChartXAxisOptionCollection(Int32)`

创建具有指定初始容量的独立 X 轴集合。

| 参数 | 说明 |
| --- | --- |
| `capacity` | 预留的 X 轴数量。 |

### `ChartXAxisOptionCollection(TCYM.UI.Chart.Model.ChartAxisOptionCollectionCore{TCYM.UI.Chart.Model.ChartXAxisOption})`

从已经确定存储模式的核心创建 X 轴集合。

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

### `Add(TCYM.UI.Chart.Model.ChartXAxisOption)`

### `Clear`

### `Contains(TCYM.UI.Chart.Model.ChartXAxisOption)`

### `CopyTo(TCYM.UI.Chart.Model.ChartXAxisOption[],Int32)`

### `Create(ReadOnlySpan{TCYM.UI.Chart.Model.ChartXAxisOption})`

供 C# collection expression 创建强类型 X 轴集合。

| 参数 | 说明 |
| --- | --- |
| `axes` | 编译器提供的连续 X 轴节点。 |

**返回：** 保持输入顺序的独立 X 轴集合。

### `GetEnumerator`

### `IndexOf(TCYM.UI.Chart.Model.ChartXAxisOption)`

### `Insert(Int32,TCYM.UI.Chart.Model.ChartXAxisOption)`

### `Remove(TCYM.UI.Chart.Model.ChartXAxisOption)`

### `RemoveAt(Int32)`
