# ChartDataZoomSliderMoveHandleOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

定义 slider 选中窗口中央 moveHandle 的尺寸和视觉。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Size` | 获取或设置有限且非负的 moveHandle 高度。 |
| `Style` | 获取或设置 moveHandle 样式；赋空或全新空节点表示整块样式重置。 |

## 方法

### `Clone`

创建尺寸、样式、presence 与 reset 意图均隔离的副本。

### `Reset`

显式清除 moveHandle 尺寸和样式。
