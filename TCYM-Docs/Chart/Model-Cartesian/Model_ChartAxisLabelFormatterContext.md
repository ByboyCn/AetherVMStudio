# ChartAxisLabelFormatterContext

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

提供一个坐标轴标签 formatter 的不可变输入。

## 构造函数

### `ChartAxisLabelFormatterContext(TCYM.UI.Chart.Data.ChartValue,Int32,TCYM.UI.Chart.Model.ChartAxisType,Int32)`

提供一个坐标轴标签 formatter 的不可变输入。

| 参数 | 说明 |
| --- | --- |
| `Value` | 当前主刻度值。 |
| `TickIndex` | 当前主刻度在已采样刻度中的索引。 |
| `AxisType` | 当前轴类型。 |
| `AxisIndex` | 当前轴在同一 mainType 中的索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AxisIndex` | 当前轴在同一 mainType 中的索引。 |
| `AxisType` | 当前轴类型。 |
| `TickIndex` | 当前主刻度在已采样刻度中的索引。 |
| `Value` | 当前主刻度值。 |
