# ChartDataZoomSliderLineStyleOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

定义 dataZoom slider 数据缩略图使用的描边颜色、宽度和透明度。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Color` | 获取或设置描边画刷；赋值时按公共画刷快照契约隔离。 |
| `Opacity` | 获取或设置 0～1 的整体不透明度。 |
| `Width` | 获取或设置有限且非负的描边宽度。 |

## 方法

### `Clone`

创建值、画刷、presence 与 reset 意图均隔离的副本。

### `Reset`

显式清除整块描边样式。
