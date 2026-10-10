# ChartBrushCartesianTarget

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

用 Grid、X 轴和 Y 轴的 ID/index 描述一个 Cartesian Brush 目标；运行时始终优先解析 ID。

## 构造函数

### `ChartBrushCartesianTarget(String,Nullable{Int32},String,Nullable{Int32},String,Nullable{Int32})`

创建一个可部分指定的 Cartesian 目标。

| 参数 | 说明 |
| --- | --- |
| `gridId` | 可选 Grid ID。 |
| `gridIndex` | 可选 Grid 索引。 |
| `xAxisId` | 可选 X 轴 ID。 |
| `xAxisIndex` | 可选 X 轴索引。 |
| `yAxisId` | 可选 Y 轴 ID。 |
| `yAxisIndex` | 可选 Y 轴索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `GridId` | 获取可选 Grid ID。 |
| `GridIndex` | 获取可选 Grid 索引。 |
| `IsDefault` | 获取当前目标是否完全依赖默认 Grid0/X0/Y0。 |
| `XAxisId` | 获取可选 X 轴 ID。 |
| `XAxisIndex` | 获取可选 X 轴索引。 |
| `YAxisId` | 获取可选 Y 轴 ID。 |
| `YAxisIndex` | 获取可选 Y 轴索引。 |
