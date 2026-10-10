# ChartTimeTickInterval

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Scales`　**Chart 版本**：`0.1.1.25`

## 概述

描述时间比例尺选中的 UTC 日历刻度间隔。

## 构造函数

### `ChartTimeTickInterval(TCYM.UI.Chart.CoordinateSystems.Scales.ChartTimeUnit,Int32)`

创建由日历单位和正整数步数组成的时间间隔。

| 参数 | 说明 |
| --- | --- |
| `unit` | UTC 日历单位。 |
| `step` | 每两个相邻主刻度跨越的单位数。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Step` | 获取每两个相邻主刻度跨越的单位数。 |
| `Unit` | 获取 UTC 日历单位。 |
