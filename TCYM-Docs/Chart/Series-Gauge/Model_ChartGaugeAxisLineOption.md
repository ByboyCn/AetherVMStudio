# ChartGaugeAxisLineOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Gauge 轴弧的显示、圆帽和描边样式。

## 属性

| 名称 | 说明 |
| --- | --- |
| `LineStyle` | 获取或设置轴弧样式；赋空或空对象显式重置整块样式。 |
| `RoundCap` | 获取或设置轴弧端点是否使用圆帽。 |
| `Show` | 获取或设置是否显示轴弧。 |

## 方法

### `Clone`

创建标量、样式与 presence 日志均隔离的副本。

### `Reset`

显式清除整个 axisLine 块。
