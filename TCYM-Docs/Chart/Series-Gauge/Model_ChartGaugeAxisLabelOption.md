# ChartGaugeAxisLabelOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Gauge 数值刻度标签及其格式化器和文本样式。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Distance` | 获取或设置相对刻度的有限距离。 |
| `Formatter` | 获取或设置字符串模板；后续 View 只替换第一次出现的 `{value}`。 |
| `FormatterCallback` | 获取或设置数值格式化回调；M11.1 只保存而不执行。 |
| `Rotate` | 获取或设置有限数值、radial 或 tangential 旋转。 |
| `Show` | 获取或设置是否显示刻度标签。 |

## 方法

### `Clone`

创建格式化器、文本样式与 presence 日志均隔离的副本。

### `Reset`

显式清除整个 axisLabel 块。
