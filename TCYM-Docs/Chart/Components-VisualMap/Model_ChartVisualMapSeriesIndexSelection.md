# ChartVisualMapSeriesIndexSelection

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

可由单值、数组或 collection expression 创建的不可变系列索引选择。

## 构造函数

### `ChartVisualMapSeriesIndexSelection(Collections.Generic.IEnumerable{Int32})`

复制唯一、非负的系列索引。

| 参数 | 说明 |
| --- | --- |
| `indices` | 系列索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | - |
| `Item(Int32)` | - |

## 方法

### `Create(ReadOnlySpan{Int32})`

供 collection expression 创建不可变选择。

### `GetEnumerator`
