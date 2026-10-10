# ChartCartesianAxisBinding

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

表示系列绑定的一根最终 Cartesian 轴；轴身份、有效类型和比例尺均来自同一次公共布局。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AxisType` | 获取由最终比例尺确认的有效轴类型。 |
| `AxisTypeName` | 获取供 ECharts 风格交互描述使用的小写有效轴类型名。 |
| `GridId` | 获取轴所属网格的稳定布局 ID。 |
| `Identity` | 获取完整轴身份，包括维度、同主类型索引和可选组件 ID。 |
| `Layout` | 获取与绑定同代次的完整不可变轴布局。 |
