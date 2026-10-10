# ChartTooltipContentSection

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

表示 axis Tooltip 中具有可选 header 的一组稳定内容行。

## 构造函数

### `ChartTooltipContentSection(String,Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Tooltip.ChartTooltipContentLine})`

创建不可变内容分区。

| 参数 | 说明 |
| --- | --- |
| `header` | 可选轴值或分组标题。 |
| `lines` | 按系列声明顺序提供的内容行。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Header` | 获取可选标题。 |
| `Lines` | 获取不可变内容行。 |
