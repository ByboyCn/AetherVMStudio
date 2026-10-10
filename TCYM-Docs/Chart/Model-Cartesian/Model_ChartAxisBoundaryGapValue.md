# ChartAxisBoundaryGapValue

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示连续轴一端的非负 boundaryGap。

## 构造函数

### `ChartAxisBoundaryGapValue(Double,TCYM.UI.Chart.Model.ChartAxisBoundaryGapUnit)`

创建绝对值或百分数间隙。

| 参数 | 说明 |
| --- | --- |
| `value` | 非负有限数；百分比单位下表示百分数而非零至一比例。 |
| `unit` | 间隙单位。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Unit` | 获取间隙单位。 |
| `Value` | 获取间隙数值。 |

## 方法

### `Absolute(Double)`

创建按数据域绝对值计量的间隙。

| 参数 | 说明 |
| --- | --- |
| `value` | 非负有限数据量。 |

**返回：** 绝对间隙。

### `Percent(Double)`

创建按数据域跨度百分数计量的间隙。

| 参数 | 说明 |
| --- | --- |
| `value` | 非负百分数；25 表示 25%。 |

**返回：** 百分比间隙。
