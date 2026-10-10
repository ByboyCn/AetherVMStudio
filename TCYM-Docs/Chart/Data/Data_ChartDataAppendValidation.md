# ChartDataAppendValidation

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

数据追加的结构验证结果。

## 构造函数

### `ChartDataAppendValidation(Boolean,String,String,Int32,Int32)`

数据追加的结构验证结果。

| 参数 | 说明 |
| --- | --- |
| `IsValid` | 是否允许追加。 |
| `Code` | 失败时的稳定诊断代码。 |
| `Message` | 失败时的可读说明。 |
| `ExpectedDimensionCount` | 当前 store 期望的维度数。 |
| `ActualDimensionCount` | 待追加数据的维度数。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `ActualDimensionCount` | 待追加数据的维度数。 |
| `Code` | 失败时的稳定诊断代码。 |
| `ExpectedDimensionCount` | 当前 store 期望的维度数。 |
| `IsValid` | 是否允许追加。 |
| `Message` | 失败时的可读说明。 |
