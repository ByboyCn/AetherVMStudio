# ChartBrushAreaStyleOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

定义 Brush cover 的填充、边框和整体透明度。

## 属性

| 名称 | 说明 |
| --- | --- |
| `BorderColor` | 获取或设置 cover 边框画刷。 |
| `BorderWidth` | 获取或设置有限且非负的 cover 边框宽度。 |
| `Color` | 获取或设置 cover 填充画刷。 |
| `Opacity` | 获取或设置 0～1 的 cover 不透明度。 |

## 方法

### `Clone`

创建值、画刷、presence 与 reset 意图均隔离的副本。

### `Reset`

显式清除整块 cover 样式。
