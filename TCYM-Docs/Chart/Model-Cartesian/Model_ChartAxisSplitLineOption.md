# ChartAxisSplitLineOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示坐标轴主分隔线的显示、采样和线条样式。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Interval` | 获取或设置 category 分隔线采样间隔；空值表示自动。 |
| `LineStyle` | 获取或设置主分隔线样式；空或未修改实例表示整块重置。 |
| `Show` | 获取或设置是否显示主分隔线。 |
| `ShowMaxLine` | 获取或设置是否绘制最大值端点分隔线。 |
| `ShowMinLine` | 获取或设置是否绘制最小值端点分隔线。 |

## 方法

### `Clone`

创建独立 splitLine 副本。

**返回：** 独立副本。

### `Reset`

显式恢复整个 splitLine 默认值。
