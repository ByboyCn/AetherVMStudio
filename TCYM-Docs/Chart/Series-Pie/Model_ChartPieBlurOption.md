# ChartPieBlurOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Pie blur 状态；复用公共 itemStyle 并精确公开 Pie label 与 labelLine。

## 构造函数

### `ChartPieBlurOption`

创建带精确 Pie label 类型的空 blur。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Label` | 获取或设置 Pie blur 标签；赋空或空对象显式重置整块标签。 |
| `LabelLine` | 获取或设置 blur 标签引导线；赋空或空对象显式重置整块。 |

## 方法

### `Clone`

创建 blur 公共和 Pie 专属字段均隔离的副本。

**返回：** 内容等价的新 Pie blur。
