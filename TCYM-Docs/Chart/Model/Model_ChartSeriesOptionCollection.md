# ChartSeriesOptionCollection

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 `Series` 的唯一有序系列集合，并为 ECharts 风格的单对象或数组
输入提供强类型、无反射的隐式归一化入口。

## 说明

该集合仍是普通可写列表；索引、Add、Insert、Remove、Clear 与 LINQ 用法和既有 Series API 一致。
把单个 `ChartSeriesOption` 或系列数组赋给 `Series` 时，输入的
集合结构会复制到 ChartOption 自己持有的实例，不会保留外部数组或临时集合的结构别名。

## 构造函数

### `ChartSeriesOptionCollection`

创建空系列集合。

### `ChartSeriesOptionCollection(Collections.Generic.IEnumerable{TCYM.UI.Chart.Model.ChartSeriesOption})`

创建包含指定系列顺序快照的集合。

| 参数 | 说明 |
| --- | --- |
| `series` | 要复制其结构的系列序列。 |

### `ChartSeriesOptionCollection(Int32)`

创建具有指定初始容量的内部集合。

| 参数 | 说明 |
| --- | --- |
| `capacity` | 预留的系列节点数量。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | - |
| `IsReadOnly` | - |
| `Item(Int32)` | - |

## 方法

### `Add(TCYM.UI.Chart.Model.ChartSeriesOption)`

### `Clear`

### `Contains(TCYM.UI.Chart.Model.ChartSeriesOption)`

### `CopyTo(TCYM.UI.Chart.Model.ChartSeriesOption[],Int32)`

### `Create(ReadOnlySpan{TCYM.UI.Chart.Model.ChartSeriesOption})`

供 C# collection expression 创建强类型系列集合。

| 参数 | 说明 |
| --- | --- |
| `series` | 编译器提供的连续系列节点。 |

**返回：** 保持输入顺序的独立系列集合。

### `GetEnumerator`

### `IndexOf(TCYM.UI.Chart.Model.ChartSeriesOption)`

### `Insert(Int32,TCYM.UI.Chart.Model.ChartSeriesOption)`

### `Remove(TCYM.UI.Chart.Model.ChartSeriesOption)`

### `RemoveAt(Int32)`
