# ChartAxisMinorTickOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示连续轴 minorTick 的显示、分段数、长度和样式。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Length` | 获取或设置非负有限次刻度长度。 |
| `LineStyle` | 获取或设置次刻度线样式；空或未修改实例表示整块重置。 |
| `Show` | 获取或设置是否显示次刻度。 |
| `SplitNumber` | 获取或设置相邻主刻度之间的次刻度分段数，范围为 1 到 99。 |

## 方法

### `Clone`

创建独立 minorTick 副本。

**返回：** 独立副本。

### `Reset`

显式恢复整个 minorTick 默认值。
