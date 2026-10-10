# ChartLegendSelectorOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

描述 Legend 的“全选”或“反选”selector 按钮。

## 构造函数

### `ChartLegendSelectorOption(TCYM.UI.Chart.Model.ChartLegendSelectorType)`

创建指定类型的 selector；默认创建“全选”。

| 参数 | 说明 |
| --- | --- |
| `type` | selector 行为类型。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `EmphasisTextRich` | 获取 emphasis 状态 rich 样式字典。 |
| `EmphasisTextStyle` | 获取或设置 emphasis 状态文字样式。 |
| `TextRich` | 获取普通状态 rich 样式字典。 |
| `TextStyle` | 获取或设置普通状态文字样式。 |
| `Title` | 获取或设置按钮标题；空值由后续本地化策略补默认标题。 |
| `Type` | 获取或设置 selector 行为类型。 |

## 方法

### `Clone`

创建样式与 rich 字典均隔离的 selector 副本。

**返回：** 内容等价的新 selector。
