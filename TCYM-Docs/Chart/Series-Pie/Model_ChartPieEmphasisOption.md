# ChartPieEmphasisOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Pie emphasis 状态；公共 disabled/blurScope/itemStyle 之外还公开 Pie label、
labelLine、focus、scale 与 scaleSize。

## 构造函数

### `ChartPieEmphasisOption`

创建带精确 Pie label 类型的空 emphasis。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Focus` | 获取或设置 emphasis 聚焦目标：none、self 或 series。 |
| `Label` | 获取或设置 Pie emphasis 标签；赋空或空对象显式重置整块标签。 |
| `LabelLine` | 获取或设置 emphasis 标签引导线；赋空或空对象显式重置整块。 |
| `Scale` | 获取或设置 emphasis 是否放大扇区。 |
| `ScaleSize` | 获取或设置 emphasis 放大的有限非负像素量。 |

## 方法

### `Clone`

创建 emphasis 全部公共和 Pie 专属字段均隔离的副本。

**返回：** 内容等价的新 Pie emphasis。
