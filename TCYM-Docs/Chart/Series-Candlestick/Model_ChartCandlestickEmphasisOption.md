# ChartCandlestickEmphasisOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Candlestick emphasis 状态；在公共 disabled、blurScope、label 与精确 itemStyle 之外，
增加 focus 和实体缩放开关。

## 构造函数

### `ChartCandlestickEmphasisOption`

创建拥有独立 Candlestick itemStyle 的空 emphasis 状态。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Focus` | 获取或设置聚焦目标：`none`、`self` 或 `series`。 |
| `ItemStyle` | 获取或设置精确的 Candlestick emphasis itemStyle。 |
| `Scale` | 获取或设置 emphasis 时是否缩放实体与影线。 |

## 方法

### `Clone`

创建公共 emphasis、focus、scale 与专用 itemStyle 均隔离的副本。

**返回：** 内容等价的新 Candlestick emphasis 状态。
