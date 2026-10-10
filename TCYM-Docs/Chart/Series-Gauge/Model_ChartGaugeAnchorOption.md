# ChartGaugeAnchorOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Gauge 中心锚点符号、布局及图元样式。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Icon` | 获取或设置 built-in、path:// 或 image:// 锚点符号。 |
| `ItemStyle` | 获取或设置锚点图元样式；赋空或空对象显式重置。 |
| `KeepAspect` | 获取或设置自定义锚点图标是否保持原始宽高比。 |
| `OffsetCenter` | 获取或设置相对 Gauge 圆心的有限像素/百分比偏移。 |
| `Show` | 获取或设置是否显示锚点。 |
| `ShowAbove` | 获取或设置锚点是否绘制在指针上方。 |
| `Size` | 获取或设置有限非负锚点尺寸。 |

## 方法

### `Clone`

创建标量、itemStyle 与 presence 日志均隔离的副本。

### `Reset`

显式清除整个 anchor 块。
