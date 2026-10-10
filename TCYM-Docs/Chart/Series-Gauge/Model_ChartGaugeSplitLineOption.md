# ChartGaugeSplitLineOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Gauge 主分隔线的显示、长度、距离和描边。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Distance` | 获取或设置相对轴弧的有限距离；负值表示向相反方向移动。 |
| `Length` | 获取或设置有限非负线长。 |
| `LineStyle` | 获取或设置分隔线描边；赋空或空对象显式重置。 |
| `Show` | 获取或设置是否显示主分隔线。 |

## 方法

### `Clone`

创建标量、描边和 presence 日志均隔离的副本。

### `Reset`

显式清除整个 splitLine 块。
