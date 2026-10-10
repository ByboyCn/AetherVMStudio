# ChartGaugeCenter

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Gauge 布局圆心的横纵像素或百分比坐标。

## 构造函数

### `ChartGaugeCenter(TCYM.UI.Chart.Model.ChartLength,TCYM.UI.Chart.Model.ChartLength)`

创建已经验证的 Gauge 圆心。

| 参数 | 说明 |
| --- | --- |
| `x` | 相对布局区域宽度的横坐标。 |
| `y` | 相对布局区域高度的纵坐标。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Middle` | 获取布局区域正中心。 |
| `X` | 获取横坐标。 |
| `Y` | 获取纵坐标。 |

## 方法

### `Percent(Single,Single)`

从百分比横纵坐标创建圆心。

| 参数 | 说明 |
| --- | --- |
| `x` | 横向百分数，例如 50 表示 50%。 |
| `y` | 纵向百分数，例如 50 表示 50%。 |

**返回：** 经过验证的 Gauge 圆心。

### `Pixels(Single,Single)`

从像素横纵坐标创建圆心。

| 参数 | 说明 |
| --- | --- |
| `x` | 横向像素坐标。 |
| `y` | 纵向像素坐标。 |

**返回：** 经过验证的 Gauge 圆心。
