# ChartBrushPolygonArea

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

定义由深冻结坐标点构成的 Polygon Brush area。

## 构造函数

### `ChartBrushPolygonArea(Collections.Generic.IEnumerable{TCYM.UI.Chart.Model.ChartBrushCoordinatePoint})`

复制三个至 4096 个 polygon 点，并拒绝不足三个不同点的输入。

| 参数 | 说明 |
| --- | --- |
| `points` | 按套索顺序排列的坐标点。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `BrushType` | 获取当前区域的几何类型。 |
| `Points` | 获取与调用方输入集合隔离的只读 polygon 点。 |

## 方法

### `Clone`

创建几何、共同字段、画刷和 presence 均隔离的同类型副本。
