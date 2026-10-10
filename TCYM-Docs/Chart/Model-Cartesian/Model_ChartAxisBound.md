# ChartAxisBound

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示坐标轴 min/max 的强类型联合值，避免把 ECharts 的特殊文本 `dataMin`、
`dataMax` 与真实分类字符串混为一谈。

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataMaximum` | 获取直接采用数据最大值的边界。 |
| `DataMinimum` | 获取直接采用数据最小值的边界。 |
| `Kind` | 获取边界值的来源。 |
| `Value` | 获取固定边界值；非固定来源时返回 `Null`。 |

## 方法

### `Fixed(TCYM.UI.Chart.Data.ChartValue)`

创建固定边界。

| 参数 | 说明 |
| --- | --- |
| `value` | 非空图表值；具体轴类型会在布局解析时进一步验证。 |

**返回：** 固定值边界。
