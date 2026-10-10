# ChartAxisSplitAreaOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示相邻主刻度之间交替填充区域的显示、采样和样式。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AreaStyle` | 获取或设置区域样式；空或未修改实例表示整块重置。 |
| `Interval` | 获取或设置 category 区域采样间隔；空值表示自动。 |
| `Show` | 获取或设置是否显示交替分隔区域。 |

## 方法

### `Clone`

创建颜色集合完全隔离的 splitArea 副本。

**返回：** 独立副本。

### `Reset`

显式恢复整个 splitArea 默认值。
