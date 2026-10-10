# ChartDataKey

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

数据项用于 diff、动画和持久视图匹配的稳定身份。

## 构造函数

### `ChartDataKey(TCYM.UI.Chart.Data.ChartDataKeyKind,String,Int32)`

数据项用于 diff、动画和持久视图匹配的稳定身份。

| 参数 | 说明 |
| --- | --- |
| `Kind` | 身份来源。 |
| `Value` | 身份文本。 |
| `Occurrence` | 相同来源和值的出现序号，用于稳定区分重复键。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Kind` | 身份来源。 |
| `Occurrence` | 相同来源和值的出现序号，用于稳定区分重复键。 |
| `Value` | 身份文本。 |

## 方法

### `ToString`
