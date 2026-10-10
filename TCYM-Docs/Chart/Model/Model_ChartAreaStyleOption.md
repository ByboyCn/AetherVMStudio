# ChartAreaStyleOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示折线下方区域的填充、基线、阴影与不透明度补丁。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Color` | 获取或设置区域填充画刷；显式赋空恢复系列视觉颜色。 |
| `Opacity` | 获取或设置 0～1 的整体不透明度。 |
| `Origin` | 获取或设置面积区域的自动、起点、终点或数值基线。 |
| `ShadowBlur` | 获取或设置非负有限阴影模糊半径。 |
| `ShadowColor` | 获取或设置阴影画刷。 |
| `ShadowOffsetX` | 获取或设置有限水平阴影偏移。 |
| `ShadowOffsetY` | 获取或设置有限垂直阴影偏移。 |

## 方法

### `Clone`

创建画刷、字段值和 presence 日志均隔离的副本。

**返回：** 内容等价的新区域样式。

### `Reset`

显式清除整块区域样式。
