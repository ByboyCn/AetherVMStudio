# ChartTextRunLayout

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Text`　**Chart 版本**：`0.1.1.25`

## 概述

表示单个格式化文本 run 在最终行中的不可变几何和样式。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Advance` | 获取包含 run box 的水平推进量。 |
| `Baseline` | 获取文字基线纵坐标。 |
| `InkBounds` | 获取文字、背景、边框和阴影可能产生像素的 run 包围盒。 |
| `LineIndex` | 获取所属行索引。 |
| `LogicalBounds` | 获取参与布局和命中的 run 逻辑框。 |
| `Style` | 获取已经完成继承解析的不可变样式。 |
| `StyleName` | 获取来源 rich 样式名称；普通文本为空。 |
| `Text` | 获取实际显示文本。 |
| `X` | 获取实际文字绘制原点的横坐标；run 逻辑框左边缘由 `LogicalBounds` 提供。 |
