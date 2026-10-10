# ChartLineDataEmphasisOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示单个 Line 数据项的 emphasis 差异；精确公开公共 disabled/blurScope、
Line focus/scale、label、itemStyle 和 endLabel。

## 属性

| 名称 | 说明 |
| --- | --- |
| `EndLabel` | 获取或设置逐项 emphasis 终点标签；赋空显式重置整块标签。 |
| `Focus` | 获取或设置逐项 emphasis 聚焦目标。 |
| `Scale` | 获取或设置逐项 emphasis symbol 的布尔值或明确倍率缩放。 |

## 方法

### `Clone`

创建逐项 emphasis 全部公共和 Line 专属字段均隔离的副本。

**返回：** 内容等价的新逐项 emphasis 状态。
