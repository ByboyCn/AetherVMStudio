# ChartCartesianBackdropProcessor

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

在 Visual 阶段把直角坐标轴的分隔区域和分隔线绘制到组件视图之前的背景层。
本处理器无可变实例状态，可以安全地由多个图表引擎共享注册。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Order` | 获取同阶段中的稳定顺序；负值使坐标背景早于普通视觉处理器。 |
| `Stage` | 获取处理器所属的视觉编码阶段。 |

## 方法

### `Process(TCYM.UI.Chart.Core.ChartBuildContext)`

根据不可变布局快照绘制 splitArea、splitLine 和 minorSplitLine。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前 Visual 阶段的受限构建上下文。 |
