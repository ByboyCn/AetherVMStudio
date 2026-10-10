# ChartGaugeColorStop

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 `axisLine.lineStyle.color` 中一个有限比例颜色断点。与 ECharts 6.1 GaugeView
一致，区间外比例保留原值并由后续布局/绘制阶段夹到 0～1。

## 构造函数

### `ChartGaugeColorStop(Double,TCYM.UI.Chart.Rendering.ChartBrush)`

创建值与画刷均经过验证和隔离的颜色断点。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Color` | 获取已经按公共画刷契约隔离的颜色。 |
| `Offset` | 获取原始有限比例位置；View 消费前才夹到 0～1。 |
| `Stop` | 获取 `Offset` 的 ECharts stop 语义别名。 |
