# ChartTooltipContentLine

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

表示结构化 Tooltip 中的一行名称、值与 marker。

## 构造函数

### `ChartTooltipContentLine(String,Collections.Generic.IEnumerable{String},TCYM.UI.Chart.Rendering.ChartBrush,String,Nullable{Double},Int32,Single)`

创建携带独立 marker 透明度的内部不可变内容行。

### `ChartTooltipContentLine(String,Collections.Generic.IEnumerable{String},TCYM.UI.Chart.Rendering.ChartBrush,String,Nullable{Double},Int32)`

创建不可变内容行。

| 参数 | 说明 |
| --- | --- |
| `name` | 可选显示名称。 |
| `values` | 已完成 valueFormatter 的显示值。 |
| `markerColor` | 可选 marker 画刷。 |
| `markerType` | 可选 marker 关键字。 |
| `sortValue` | valueAsc/valueDesc 使用的可选有限数值。 |
| `seriesOrder` | 系列声明的稳定零基顺序。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `MarkerColor` | 获取已快照隔离的 marker 画刷。 |
| `MarkerType` | 获取 marker 关键字。 |
| `Name` | 获取可选名称。 |
| `SeriesOrder` | 获取系列声明的稳定顺序。 |
| `SortValue` | 获取按值排序使用的可选数值。 |
| `Values` | 获取已完成格式化的只读值集合。 |
