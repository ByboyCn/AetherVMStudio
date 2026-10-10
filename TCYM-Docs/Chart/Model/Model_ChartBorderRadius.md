# ChartBorderRadius

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts `itemStyle.borderRadius` 的强类型四角值。数值按像素解释，百分比由
具体图元相对于自身尺寸解析；一至四值的展开顺序与 CSS/ECharts 一致。

## 构造函数

### `ChartBorderRadius(TCYM.UI.Chart.Model.ChartLength,TCYM.UI.Chart.Model.ChartLength,TCYM.UI.Chart.Model.ChartLength,TCYM.UI.Chart.Model.ChartLength)`

使用左上、右上、右下、左下顺序创建完整四角半径。

| 参数 | 说明 |
| --- | --- |
| `topLeft` | 左上角半径。 |
| `topRight` | 右上角半径。 |
| `bottomRight` | 右下角半径。 |
| `bottomLeft` | 左下角半径。 |

### `ChartBorderRadius(TCYM.UI.Chart.Model.ChartLength,TCYM.UI.Chart.Model.ChartLength,TCYM.UI.Chart.Model.ChartLength)`

使用三个值创建四角半径，第二个值同时用于右上角和左下角。

| 参数 | 说明 |
| --- | --- |
| `topLeft` | 左上角半径。 |
| `topRightBottomLeft` | 右上角与左下角半径。 |
| `bottomRight` | 右下角半径。 |

### `ChartBorderRadius(TCYM.UI.Chart.Model.ChartLength,TCYM.UI.Chart.Model.ChartLength)`

使用两个值创建对角成对的四角半径。

| 参数 | 说明 |
| --- | --- |
| `topLeftBottomRight` | 左上角与右下角半径。 |
| `topRightBottomLeft` | 右上角与左下角半径。 |

### `ChartBorderRadius(TCYM.UI.Chart.Model.ChartLength)`

使用一个半径创建四角一致的值。

| 参数 | 说明 |
| --- | --- |
| `all` | 四个角共用的非负像素或百分比长度。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `BottomLeft` | 获取左下角半径。 |
| `BottomRight` | 获取右下角半径。 |
| `TopLeft` | 获取左上角半径。 |
| `TopRight` | 获取右上角半径。 |

## 方法

### `ForSector(TCYM.UI.Chart.Model.ChartLength,TCYM.UI.Chart.Model.ChartLength)`

按 ECharts Sector/Pie 的双值数组语义创建内外圆角：第一个值同时用于 inner-start/
inner-end，第二个值同时用于 outer-start/outer-end。它与两个参数的 CSS 对角构造函数
刻意不同。

| 参数 | 说明 |
| --- | --- |
| `inner` | 两个内弧端角共用的有限非负像素或百分比半径。 |
| `outer` | 两个外弧端角共用的有限非负像素或百分比半径。 |

**返回：** 按 inner-start、inner-end、outer-start、outer-end 展开的四值半径。

### `FromValues(TCYM.UI.Chart.Model.ChartLength[])`

从一至四个 ECharts 顺序值创建四角半径。

| 参数 | 说明 |
| --- | --- |
| `values` | 一至四个非负像素或百分比长度。 |

**返回：** 按 CSS/ECharts 规则展开后的强类型四角值。

### `ToArray`

返回左上、右上、右下、左下顺序的独立数组。

**返回：** 不与当前值共享可变状态的四元素数组。

### `ToString`

返回左上、右上、右下、左下顺序的稳定可读文本。

**返回：** 使用不变区域格式的四值文本。
