# ChartLineEmphasisOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Line emphasis 状态。除公共 disabled/blurScope 外，它精确公开 Line 的
focus、scale、lineStyle、areaStyle、label、itemStyle 和 endLabel。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AreaStyle` | 获取或设置 emphasis 面积样式；赋空显式重置整块样式。 |
| `EndLabel` | 获取或设置 emphasis 终点标签；赋空显式重置整块标签。 |
| `Focus` | 获取或设置 emphasis 聚焦目标，例如 `none`、`self` 或 `series`。 |
| `LineStyle` | 获取或设置 emphasis 折线路径样式；赋空显式重置整块样式。 |
| `Scale` | 获取或设置 emphasis symbol 的布尔值或明确倍率缩放。 |

## 方法

### `Clone`

创建 emphasis 全部公共和 Line 专属字段均隔离的副本。

**返回：** 内容等价的新 emphasis 状态。
