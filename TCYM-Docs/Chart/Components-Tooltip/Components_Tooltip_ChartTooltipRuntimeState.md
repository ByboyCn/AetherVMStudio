# ChartTooltipRuntimeState

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

保存单个 Tooltip 组件由所属 Engine 独占的不可变显示快照。该对象不持有 View、场景图元、
DataView 或原生资源；延迟与异步任务由独立 owned work 槽管理。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Content` | 获取当前占位或最终原生内容。 |
| `DisplayState` | 获取当前显示阶段。 |
| `FormatterContext` | 获取 item 或 axis formatter 参数快照。 |
| `Generation` | 获取本次目标请求的正数单调代次。 |
| `IsVisible` | 获取当前阶段是否应继续绘制已有内容。 |
| `Point` | 获取当前指针或 action 锚点。 |
| `Position` | 获取 descriptor 或 action 提供的位置覆盖。 |
| `PreferredBorderColor` | 获取 item 自动边框使用的可选数据色。 |
| `TargetBounds` | 获取可选目标包围盒。 |
| `Ticket` | 获取 formatter 使用的稳定 ticket。 |
