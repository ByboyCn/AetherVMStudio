# ChartYAxisOptionCollection

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示可接受单轴、数组或 collection expression 的有序 Y 轴集合；从
`YAxis` 获取时是 `Components` 的实时视图，
直接构造时则是用于整体赋值且结构独立的输入集合。

## 构造函数

### `ChartYAxisOptionCollection`

创建空的独立 Y 轴集合。

### `ChartYAxisOptionCollection(Collections.Generic.IEnumerable{TCYM.UI.Chart.Model.ChartYAxisOption})`

创建包含指定 Y 轴顺序快照的独立集合。

| 参数 | 说明 |
| --- | --- |
| `axes` | 要复制其结构的 Y 轴序列。 |

### `ChartYAxisOptionCollection(Int32)`

创建具有指定初始容量的独立 Y 轴集合。

| 参数 | 说明 |
| --- | --- |
| `capacity` | 预留的 Y 轴数量。 |

### `ChartYAxisOptionCollection(TCYM.UI.Chart.Model.ChartAxisOptionCollectionCore{TCYM.UI.Chart.Model.ChartYAxisOption})`

从已经确定存储模式的核心创建 Y 轴集合。

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

### `Add(TCYM.UI.Chart.Model.ChartYAxisOption)`

### `Clear`

### `Contains(TCYM.UI.Chart.Model.ChartYAxisOption)`

### `CopyTo(TCYM.UI.Chart.Model.ChartYAxisOption[],Int32)`

### `Create(ReadOnlySpan{TCYM.UI.Chart.Model.ChartYAxisOption})`

供 C# collection expression 创建强类型 Y 轴集合。

| 参数 | 说明 |
| --- | --- |
| `axes` | 编译器提供的连续 Y 轴节点。 |

**返回：** 保持输入顺序的独立 Y 轴集合。

### `GetEnumerator`

### `IndexOf(TCYM.UI.Chart.Model.ChartYAxisOption)`

### `Insert(Int32,TCYM.UI.Chart.Model.ChartYAxisOption)`

### `Remove(TCYM.UI.Chart.Model.ChartYAxisOption)`

### `RemoveAt(Int32)`
