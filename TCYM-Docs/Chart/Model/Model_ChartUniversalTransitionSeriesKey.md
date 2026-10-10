# ChartUniversalTransitionSeriesKey

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 universal transition 用于关联前后系列的单一键或顺序无关键序列（多重集合）。
序列输入会在构造时复制并按 ordinal 顺序规范化；重复项、多重性与空字符串均精确保留，
后续调用方修改原数组不会影响选项。

## 构造函数

### `ChartUniversalTransitionSeriesKey(Collections.Generic.IEnumerable{String})`

使用顺序无关的字符串键序列创建系列关联键；输入会立即复制并按
`Ordinal` 排序。

| 参数 | 说明 |
| --- | --- |
| `values` | 至少包含一个非 null 元素的系列键序列；空字符串与重复项合法。 |

### `ChartUniversalTransitionSeriesKey(String)`

使用一个精确字符串键创建系列关联键。

| 参数 | 说明 |
| --- | --- |
| `value` | 区分大小写且不做裁剪的系列键。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `IsArray` | 获取当前联合值是否来自字符串数组。 |
| `StringValue` | 获取单字符串联合值；数组联合值返回 `null`。 |
| `Values` | 获取规范化的只读值；单字符串联合值返回仅含该字符串的序列，数组联合值返回排序后的副本，<br />且精确保留重复项、多重性和空字符串。 |

## 方法

### `Equals(Object)`

### `Equals(TCYM.UI.Chart.Model.ChartUniversalTransitionSeriesKey)`

### `GetHashCode`

### `ToString`
