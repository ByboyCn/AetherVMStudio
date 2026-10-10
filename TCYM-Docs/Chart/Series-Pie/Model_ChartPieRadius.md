# ChartPieRadius

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Pie 内外半径；百分比相对布局 box 最短边的一半。

## 构造函数

### `ChartPieRadius(TCYM.UI.Chart.Model.ChartLength,TCYM.UI.Chart.Model.ChartLength)`

创建已经验证的内外半径；内半径大于外半径时布局阶段按 ECharts 交换。

| 参数 | 说明 |
| --- | --- |
| `inner` | 有限非负内半径。 |
| `outer` | 有限非负外半径。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Inner` | 获取内半径。 |
| `Outer` | 获取外半径。 |

## 方法

### `FromOuter(TCYM.UI.Chart.Model.ChartLength)`

从单个外半径创建实心 Pie。

| 参数 | 说明 |
| --- | --- |
| `outer` | 外半径。 |

**返回：** 内半径为零的 Pie 半径。
