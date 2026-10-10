# ChartGaugePointerOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Gauge 指针符号、布局及图元样式。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Icon` | 获取或设置 built-in、path:// 或 image:// 指针声明；空值恢复默认指针路径。 |
| `ItemStyle` | 获取或设置指针图元样式；赋空或空对象显式重置。 |
| `KeepAspect` | 获取或设置自定义图标是否保持原始宽高比。 |
| `Length` | 获取或设置相对半径的百分比或明确像素长度。 |
| `OffsetCenter` | 获取或设置相对 Gauge 圆心的有限像素/百分比二维偏移。 |
| `Show` | 获取或设置是否显示指针。 |
| `ShowAbove` | 获取或设置指针是否绘制在标题、详情等内容上方。 |
| `Width` | 获取或设置有限非负指针宽度。 |

## 方法

### `Clone`

创建标量、itemStyle 与 presence 日志均隔离的副本。

### `Reset`

显式清除整个 pointer 块。
