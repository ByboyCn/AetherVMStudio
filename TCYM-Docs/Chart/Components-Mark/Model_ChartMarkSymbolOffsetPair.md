# ChartMarkSymbolOffsetPair

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 markLine 两个端点各自的 symbol 偏移。

## 构造函数

### `ChartMarkSymbolOffsetPair(TCYM.UI.Chart.Model.ChartSymbolOffset,TCYM.UI.Chart.Model.ChartSymbolOffset)`

表示 markLine 两个端点各自的 symbol 偏移。

| 参数 | 说明 |
| --- | --- |
| `Start` | 起点偏移。 |
| `End` | 终点偏移。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `End` | 终点偏移。 |
| `Start` | 起点偏移。 |

## 方法

### `Uniform(TCYM.UI.Chart.Model.ChartSymbolOffset)`

把同一偏移应用到两个端点。

| 参数 | 说明 |
| --- | --- |
| `offset` | 两个端点共用的偏移。 |

**返回：** 起终点相同的偏移对。
