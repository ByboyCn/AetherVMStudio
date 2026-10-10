# ChartMarkSymbolSizePair

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 markLine 起点和终点的 symbol 尺寸。

## 构造函数

### `ChartMarkSymbolSizePair(TCYM.UI.Chart.Model.ChartSymbolSize,TCYM.UI.Chart.Model.ChartSymbolSize)`

表示 markLine 起点和终点的 symbol 尺寸。

| 参数 | 说明 |
| --- | --- |
| `Start` | 起点尺寸。 |
| `End` | 终点尺寸。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `End` | 终点尺寸。 |
| `Start` | 起点尺寸。 |

## 方法

### `Uniform(TCYM.UI.Chart.Model.ChartSymbolSize)`

把同一尺寸应用到两个端点。

| 参数 | 说明 |
| --- | --- |
| `size` | 两个端点共用的尺寸。 |

**返回：** 起终点相同的尺寸对。
