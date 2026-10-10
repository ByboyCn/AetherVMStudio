# ChartGaugeProgressOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Gauge 当前值进度弧。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Clip` | 获取或设置进度弧是否裁剪在轴弧值域内。 |
| `ItemStyle` | 获取或设置进度弧图元样式；赋空或空对象显式重置。 |
| `Overlap` | 获取或设置多个进度弧是否允许重叠。 |
| `RoundCap` | 获取或设置进度弧端点是否使用圆帽。 |
| `Show` | 获取或设置是否显示进度弧。 |
| `Width` | 获取或设置有限非负进度弧宽度。 |

## 方法

### `Clone`

创建标量、itemStyle 与 presence 日志均隔离的副本。

### `Reset`

显式清除整个 progress 块。
