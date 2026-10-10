# ChartScaleRange

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Scales`　**Chart 版本**：`0.1.1.25`

## 概述

表示比例尺输出坐标的有限范围；起点大于终点时自然形成反向比例尺。

## 构造函数

### `ChartScaleRange(Double,Double)`

创建输出范围；允许起点等于终点以支持零尺寸布局。

| 参数 | 说明 |
| --- | --- |
| `start` | 归一化值零对应的有限坐标。 |
| `end` | 归一化值一对应的有限坐标。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `End` | 获取归一化值一对应的坐标。 |
| `IsReversed` | 获取输出范围是否从较大坐标指向较小坐标。 |
| `Span` | 获取有符号输出跨度。 |
| `Start` | 获取归一化值零对应的坐标。 |
