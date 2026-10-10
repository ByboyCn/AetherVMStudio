# ChartDataZoomAxisIndexSelection

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 dataZoom 绑定的一项或多项同类坐标轴索引。实例在构造后不可变，因此可安全地在
option 克隆与 canonical 快照之间共享，同时支持整数、整数数组和 collection expression 输入。

## 构造函数

### `ChartDataZoomAxisIndexSelection(Collections.Generic.IEnumerable{Int32})`

创建并复制目标轴索引序列。

| 参数 | 说明 |
| --- | --- |
| `indices` | 按 dataZoom 配置顺序提供的非负且互不重复的同类轴索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | - |
| `Item(Int32)` | - |

## 方法

### `Create(ReadOnlySpan{Int32})`

供 C# collection expression 创建不可变轴索引选择。

| 参数 | 说明 |
| --- | --- |
| `indices` | 编译器提供的连续轴索引。 |

**返回：** 保持输入顺序且结构隔离的不可变选择。

### `GetEnumerator`
