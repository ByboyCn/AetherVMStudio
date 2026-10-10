# ChartDataZoomSliderBrushSelectOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

定义在 slider 空白区域拖出新窗口的开关和选框视觉。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Enabled` | 获取或设置是否允许在 slider 面板内拖出新范围。 |
| `Style` | 获取或设置拖选范围样式；赋空或全新空节点表示整块样式重置。 |

## 方法

### `Clone`

创建开关、样式、presence 与 reset 意图均隔离的副本。

### `Reset`

显式清除 brushSelect 开关和样式。
