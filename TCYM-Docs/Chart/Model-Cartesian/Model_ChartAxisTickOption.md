# ChartAxisTickOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示坐标轴主刻度的显示、位置、长度和样式。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AlignWithLabel` | 获取或设置 category 轴刻度是否与标签中心对齐。 |
| `Inside` | 获取或设置主刻度是否朝 grid 内侧绘制。 |
| `Interval` | 获取或设置 category 轴每两个已显示刻度之间跳过的刻度数；空值表示 auto。 |
| `Length` | 获取或设置非负有限刻度长度。 |
| `LineStyle` | 获取或设置刻度线样式；空或未修改实例表示整块重置。 |
| `Show` | 获取或设置主刻度是否显示；空值表示自动。 |

## 方法

### `Clone`

创建独立 axisTick 副本。

**返回：** 独立副本。

### `Reset`

显式恢复整个 axisTick 默认值。
