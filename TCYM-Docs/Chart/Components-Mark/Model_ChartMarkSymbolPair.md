# ChartMarkSymbolPair

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 markLine 起点和终点的 symbol 类型。

## 构造函数

### `ChartMarkSymbolPair(String,String)`

创建一个起终点 symbol 对。

| 参数 | 说明 |
| --- | --- |
| `start` | 起点 symbol 类型、path 或 image URI。 |
| `end` | 终点 symbol 类型、path 或 image URI。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `End` | 获取终点 symbol。 |
| `Start` | 获取起点 symbol。 |

## 方法

### `Uniform(String)`

把同一个 symbol 应用于两个端点。

| 参数 | 说明 |
| --- | --- |
| `symbol` | 两个端点共用的 symbol。 |

**返回：** 起终点相同的 symbol 对。
