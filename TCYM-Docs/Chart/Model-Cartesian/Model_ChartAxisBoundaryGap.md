# ChartAxisBoundaryGap

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts axis.boundaryGap 的强类型联合值：分类轴使用布尔值，连续轴使用两个
绝对值或百分比间隙。

## 属性

| 名称 | 说明 |
| --- | --- |
| `CategoryEnabled` | 获取分类轴是否在首尾保留半个 band；连续分支下该值无意义。 |
| `End` | 获取连续轴终点间隙；分类分支下返回零绝对间隙。 |
| `Kind` | 获取当前联合值分支。 |
| `Start` | 获取连续轴起点间隙；分类分支下返回零绝对间隙。 |

## 方法

### `Category(Boolean)`

创建分类轴 boundaryGap。

| 参数 | 说明 |
| --- | --- |
| `enabled` | 是否把分类放在等宽 band 中心。 |

**返回：** 分类轴联合值。

### `Continuous(TCYM.UI.Chart.Model.ChartAxisBoundaryGapValue,TCYM.UI.Chart.Model.ChartAxisBoundaryGapValue)`

创建连续轴双端 boundaryGap。

| 参数 | 说明 |
| --- | --- |
| `start` | 数据域起点间隙。 |
| `end` | 数据域终点间隙。 |

**返回：** 连续轴联合值。
