# ChartGaugeAxisTickOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Gauge 次刻度线的分段、显示、长度、距离和描边。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Distance` | 获取或设置相对轴弧的有限距离。 |
| `Length` | 获取或设置有限非负刻度长度。 |
| `LineStyle` | 获取或设置次刻度描边；赋空或空对象显式重置。 |
| `Show` | 获取或设置是否显示次刻度。 |
| `SplitNumber` | 获取或设置每个主分段内的正数次刻度分段数。 |

## 方法

### `Clone`

创建标量、描边和 presence 日志均隔离的副本。

### `Reset`

显式清除整个 axisTick 块。
