# ChartBrushRectArea

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

定义同时约束 X/Y 坐标闭区间的矩形 Brush area。

## 构造函数

### `ChartBrushRectArea(TCYM.UI.Chart.Model.ChartBrushValueRange,TCYM.UI.Chart.Model.ChartBrushValueRange)`

创建矩形区域。

| 参数 | 说明 |
| --- | --- |
| `xRange` | X 坐标闭区间。 |
| `yRange` | Y 坐标闭区间。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `BrushType` | 获取当前区域的几何类型。 |
| `XRange` | 获取 X 坐标闭区间。 |
| `YRange` | 获取 Y 坐标闭区间。 |

## 方法

### `Clone`

创建几何、共同字段、画刷和 presence 均隔离的同类型副本。
