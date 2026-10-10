# ChartLineEndLabelPrecision

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 6.1 Line `endLabel.precision` 的 `auto` 或 0～20 整数联合值。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Auto` | 获取自动精度关键字。 |
| `Digits` | 获取显式 0～20 小数位数；自动精度返回空。 |
| `IsAuto` | 获取是否按相邻 raw 数值自动确定精度。 |

## 方法

### `FromDigits(Int32)`

创建显式 0～20 小数位数。

| 参数 | 说明 |
| --- | --- |
| `digits` | 0～20 小数位数。 |

**返回：** 显式数值精度。

### `ToString`
