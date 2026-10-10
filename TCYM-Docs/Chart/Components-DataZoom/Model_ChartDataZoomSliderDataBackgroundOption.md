# ChartDataZoomSliderDataBackgroundOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

组合 slider 数据缩略图的线条和区域样式。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AreaStyle` | 获取或设置数据轮廓下方的区域样式；赋空或全新空节点表示整块重置。 |
| `LineStyle` | 获取或设置数据轮廓线样式；赋空或全新空节点表示整块重置。 |

## 方法

### `Clone`

创建两个嵌套样式、presence 与 reset 意图均隔离的副本。

### `Reset`

显式清除线条和区域两个嵌套样式块。
