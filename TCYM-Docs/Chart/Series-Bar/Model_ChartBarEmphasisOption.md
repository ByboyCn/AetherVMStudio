# ChartBarEmphasisOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Bar emphasis 状态；公共 disabled、blurScope、label 与 itemStyle 之外，精确公开
`focus`。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Focus` | 获取或设置 emphasis 聚焦目标：`none`、`self` 或 `series`。 |

## 方法

### `Clone`

创建公共 emphasis 视觉、focus 与 presence 日志均隔离的副本。

**返回：** 内容等价的新 Bar emphasis 状态。
