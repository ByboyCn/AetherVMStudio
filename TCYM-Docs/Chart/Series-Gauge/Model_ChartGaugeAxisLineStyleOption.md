# ChartGaugeAxisLineStyleOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Gauge 轴弧使用的颜色断点、宽度和线型。

## 构造函数

### `ChartGaugeAxisLineStyleOption`

创建不携带任何 presence 的空轴弧样式。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Color` | 获取 ECharts `lineStyle.color` 的有序比例断点。修改集合表示整组替换；<br />每个断点由 `ChartGaugeColorStop` 在构造时验证并隔离画刷。 |
| `ColorStops` | 获取 `Color` 的说明性别名。 |
| `Opacity` | 获取或设置 0～1 的整体透明度。 |
| `Type` | 获取或设置实线、虚线或点线类型。 |
| `Width` | 获取或设置有限非负轴弧宽度。 |

## 方法

### `Clone`

创建颜色集合、画刷与 presence 日志均隔离的副本。

### `Reset`

显式清除整个轴弧样式。
