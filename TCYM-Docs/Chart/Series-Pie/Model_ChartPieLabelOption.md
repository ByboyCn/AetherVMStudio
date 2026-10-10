# ChartPieLabelOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Pie label 的 presence-aware 扩展；公共文本、formatter 与 rich 字段继续由
`ChartLabelOption` 管理。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AlignTo` | 获取或设置外部标签按自身、引导线或布局视口边缘对齐。 |
| `BleedMargin` | 获取或设置非 edge 对齐时标签可越过布局视口的有限非负余量。 |
| `DistanceToLabelLine` | 获取或设置标签文本与引导线末端之间的有限非负像素距离。 |
| `EdgeDistance` | 获取或设置 alignTo=edge 时标签与布局视口边缘的像素或百分比距离。 |
| `Overflow` | 获取或设置 Pie 标签的原生文本溢出策略。 |
| `Position` | 获取或设置 outer/inside/center 及其 ECharts 兼容别名。 |
| `Rotate` | 获取或设置有限角度、布尔径向模式或 radial/tangential 关键字旋转。 |

## 方法

### `Clone`

创建公共标签、Pie 专属字段与 presence 日志均隔离的副本。

**返回：** 内容等价的新 Pie 标签。
