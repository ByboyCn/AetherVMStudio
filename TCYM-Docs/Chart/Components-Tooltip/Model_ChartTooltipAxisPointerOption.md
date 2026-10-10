# ChartTooltipAxisPointerOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Tooltip axisPointer 的 presence-aware 便捷配置。轴自身 axisPointer 在后续坐标系级联中应具有
更高优先级；CrossTextStyle 对应 ECharts crossStyle.textStyle。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Animation` | 获取或设置更新动画开关。 |
| `AnimationDurationUpdate` | 获取或设置更新动画时长，单位毫秒。 |
| `AnimationEasingUpdate` | 获取或设置更新动画 easing 关键字。 |
| `Axis` | 获取或设置 auto、x、y、angle 或 radius 目标轴。 |
| `CrossStyle` | 获取或设置 cross 非 base axis 使用的线条样式。 |
| `CrossTextStyle` | 获取或设置 cross label 继承的文本差异样式。 |
| `LineStyle` | 获取或设置 line pointer 样式；整块赋值优先于字段补丁。 |
| `Precision` | 获取或设置 cross 轴值标签保留的小数位数。空值保留原始自动格式；显式值必须位于 0～20。 |
| `ShadowStyle` | 获取或设置 shadow pointer 区域样式。 |
| `Snap` | 获取或设置吸附开关。空值表示自动：tooltip 触发的 value/time/log 轴吸附，category 轴不吸附。 |
| `Type` | 获取或设置 line、shadow、none 或 cross 类型。 |
| `Z` | 获取或设置 axisPointer 在同一 zlevel 的绘制顺序。 |

## 方法

### `Clone`

创建全部嵌套样式与 presence 均隔离的副本。

**返回：** 等价新 axisPointer option。

### `Reset`

显式清除整个 Tooltip axisPointer 块。
