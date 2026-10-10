# ChartVisualMapSeriesIdSelection

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

可由单值、数组或 collection expression 创建的不可变系列 ID 选择。

## 构造函数

### `ChartVisualMapSeriesIdSelection(Collections.Generic.IEnumerable{String})`

复制唯一、非空白的系列 ID。

| 参数 | 说明 |
| --- | --- |
| `ids` | 系列 ID。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | - |
| `Item(Int32)` | - |

## 方法

### `Create(ReadOnlySpan{String})`

供 collection expression 创建不可变选择。

### `GetEnumerator`
