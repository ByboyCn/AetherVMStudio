# ChartDataZoomSliderDetailOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

定义 slider 两端 detail 文本的显示、精度、模板和基础文字视觉。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Color` | 获取或设置 detail 文字画刷。 |
| `FontSize` | 获取或设置有限且大于零的 detail 字号。 |
| `Formatter` | 获取或设置只替换 `{value}` 的 AOT-safe detail 文本模板。 |
| `Precision` | 获取或设置 detail 小数位数；空值表示按轴刻度自动决定，合法范围为 0～20。 |
| `Show` | 获取或设置拖动及 hover 时是否显示窗口端点 detail。 |

## 方法

### `Clone`

创建文本字段、画刷、presence 与 reset 意图均隔离的副本。

### `Reset`

显式清除整块 detail 配置。
