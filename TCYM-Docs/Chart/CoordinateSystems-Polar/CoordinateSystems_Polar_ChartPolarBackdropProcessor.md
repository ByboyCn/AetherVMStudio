# ChartPolarBackdropProcessor

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

在 Visual 阶段绘制 Polar 坐标轴共享的分隔区域和分隔线。前景轴线、刻度和文本由持久组件
View 独占，避免同一几何被两个生命周期重复管理。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Order` | 获取背景处理器的稳定顺序；它晚于 Cartesian 背景一位但仍早于普通视觉编码。 |
| `Stage` | 获取处理器所属的管线阶段。 |

## 方法

### `Process(TCYM.UI.Chart.Core.ChartBuildContext)`

从预计算 Polar 渲染布局创建 splitArea 和 splitLine 场景元素。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前 Visual 候选的受限构建上下文。 |
