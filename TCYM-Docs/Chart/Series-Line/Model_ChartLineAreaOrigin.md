# ChartLineAreaOrigin

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts `areaStyle.origin` 的关键字或数值联合类型。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Auto` | 获取自动基线值。 |
| `End` | 获取坐标轴最大侧基线值。 |
| `Kind` | 获取基线类别。 |
| `Start` | 获取坐标轴最小侧基线值。 |
| `Value` | 获取明确基线数值；非数值类别为空。 |

## 方法

### `FromValue(Double)`

从有限数据值创建明确基线。

| 参数 | 说明 |
| --- | --- |
| `value` | 有限数据值。 |

**返回：** 数值基线。
