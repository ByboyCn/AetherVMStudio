# ChartScatterEmphasisOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Scatter emphasis 状态；除公共 disabled、blurScope、Label 与 ItemStyle 外，精确公开
focus 和 symbol scale。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Focus` | 获取或设置 emphasis 聚焦目标：`none`、`self` 或 `series`。 |
| `Scale` | 获取或设置 emphasis symbol 的布尔值或明确正数倍率缩放。 |

## 方法

### `Clone`

创建公共视觉、focus、scale 与 presence 日志均隔离的副本。

**返回：** 内容等价的新 Scatter emphasis 状态。
