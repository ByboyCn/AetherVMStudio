# ChartLegendItemStyleOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Legend 图标填充与边框的 presence-aware 样式补丁。

## 属性

| 名称 | 说明 |
| --- | --- |
| `BorderColor` | 获取或设置图标边框画刷；空值恢复 presentation 继承值。 |
| `BorderWidth` | 获取或设置有限非负边框宽度；空值使用 ECharts 的 auto 继承语义。 |
| `Color` | 获取或设置图标填充画刷；空值恢复 presentation 继承值。 |
| `Opacity` | 获取或设置 0～1 的图标不透明度；空值恢复继承值。 |

## 方法

### `Clone`

创建画刷、数值及 presence 日志均独立的副本。

**返回：** 内容等价的新样式。

### `Reset`

显式清除整个 Legend 图标样式块。
