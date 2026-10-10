# ChartBrushSeriesSelection

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Brush 的不可变系列索引联合值，可表达全部、空集合或显式索引，并支持 collection expression。

## 构造函数

### `ChartBrushSeriesSelection(Collections.Generic.IEnumerable{Int32})`

复制唯一非负索引；空序列规范为 `None`。

| 参数 | 说明 |
| --- | --- |
| `indices` | 待冻结的系列索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `All` | 获取全部系列选择。 |
| `Count` | - |
| `IsAll` | 获取选择是否匹配全部系列。 |
| `IsNone` | 获取选择是否明确为空。 |
| `Item(Int32)` | - |
| `Kind` | 获取选择的联合种类。 |
| `None` | 获取明确空系列选择。 |

## 方法

### `Clone`

创建联合种类和索引数组均独立的副本。

### `Create(ReadOnlySpan{Int32})`

供 collection expression 创建不可变系列选择。

| 参数 | 说明 |
| --- | --- |
| `indices` | 编译器提供的连续系列索引。 |

**返回：** 不可变系列选择。

### `GetEnumerator`
