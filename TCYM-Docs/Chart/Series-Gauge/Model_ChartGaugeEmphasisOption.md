# ChartGaugeEmphasisOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Gauge emphasis 状态；除公共 disabled、blurScope、Label 与 ItemStyle 外，
精确公开 ECharts Gauge 使用的 focus。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Focus` | 获取或设置聚焦目标：`none`、`self` 或 `series`。 |

## 方法

### `Clone`

创建公共视觉、focus 与 presence 日志均独立的副本。
