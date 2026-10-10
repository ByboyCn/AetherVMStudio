# ChartPolarCenter

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Polar 中心点的 ECharts 二元长度值。

## 构造函数

### `ChartPolarCenter(TCYM.UI.Chart.Model.ChartLength,TCYM.UI.Chart.Model.ChartLength)`

创建一个水平、垂直分量均经过 Polar 语义验证的中心点。

| 参数 | 说明 |
| --- | --- |
| `x` | 相对视口宽度的水平像素、百分比或水平位置关键字。 |
| `y` | 相对视口高度的垂直像素、百分比或垂直位置关键字。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Default` | 获取 ECharts Polar 的默认中心 `['50%', '50%']`。 |
| `X` | 获取水平中心位置。 |
| `Y` | 获取垂直中心位置。 |

## 方法

### `From(Single,Single,TCYM.UI.Chart.Model.ChartLengthUnit)`

从相同单位的水平和垂直数值创建中心点。

| 参数 | 说明 |
| --- | --- |
| `x` | 水平数值。 |
| `y` | 垂直数值。 |
| `unit` | 两个分量共用的像素或百分比单位。 |

**返回：** 经过验证的中心点。
