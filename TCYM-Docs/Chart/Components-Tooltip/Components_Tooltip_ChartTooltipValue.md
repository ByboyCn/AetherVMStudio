# ChartTooltipValue

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Tooltip 的单值或多维值不可变快照。

## 构造函数

### `ChartTooltipValue(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},Boolean)`

按显式原始语法创建值快照。

| 参数 | 说明 |
| --- | --- |
| `values` | 待复制并隔离的值。 |
| `isScalar` | 原始语法是否为标量。 |

### `ChartTooltipValue(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue})`

创建向量值快照并隔离每个自定义对象载荷。

| 参数 | 说明 |
| --- | --- |
| `values` | 按 encode/维度顺序排列的向量值；空集合表示空向量。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Empty` | 获取没有任何维度值的共享显式空向量。 |
| `IsScalar` | 获取原始语法是否为标量；单元素数组仍返回假。 |
| `IsVector` | 获取原始语法是否为向量，包括空数组和单元素数组。 |
| `Primary` | 获取第一个值；空集合返回 `Null`。 |
| `Values` | 获取按稳定维度顺序排列的只读值。 |

## 方法

### `From(TCYM.UI.Chart.Data.ChartValue)`

从单个图表值创建不可变 Tooltip 值。

| 参数 | 说明 |
| --- | --- |
| `value` | 待捕获的标量。 |

**返回：** 只含一个值的新快照。

### `FromVector(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue})`

从值序列创建显式向量快照。

| 参数 | 说明 |
| --- | --- |
| `values` | 待捕获的向量值。 |

**返回：** 保留向量语法的新快照。
