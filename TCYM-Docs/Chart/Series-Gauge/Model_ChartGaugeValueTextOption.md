# ChartGaugeValueTextOption

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

为 Gauge title/detail 保存共同的显示、偏移、formatter 和值动画字段。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Formatter` | 获取或设置字符串模板；后续 View 只替换第一次出现的 `{value}`。 |
| `FormatterCallback` | 获取或设置数值格式化回调；M11.1 只保存而不执行。 |
| `OffsetCenter` | 获取或设置相对 Gauge 圆心的有限像素/百分比偏移。 |
| `Show` | 获取或设置是否显示文本。 |
| `ValueAnimation` | 获取或设置更新时是否对数值文本插值。 |

## 方法

### `Reset`

显式清除整个文本块。
