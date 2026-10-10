# ChartPolarPipelineOrders

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

冻结 Polar 公共 Layout 阶段内的处理顺序。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ComponentLayout` | Polar 组件绘制布局晚于权威坐标布局、早于系列绑定执行；它只冻结组件图元与文本消费的纯托管快照。 |
| `Layout` | Polar 布局晚于 Cartesian 布局一个顺序执行，二者只写各自命名制品。 |
| `SeriesBinding` | Polar 系列绑定晚于两个坐标布局和 Cartesian 绑定执行。 |
| `SeriesLayoutLowerBound` | 后续 Polar 系列布局允许使用的最小顺序。 |
