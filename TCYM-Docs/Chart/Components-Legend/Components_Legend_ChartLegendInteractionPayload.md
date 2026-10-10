# ChartLegendInteractionPayload

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Legend`　**Chart 版本**：`0.1.1.25`

## 概述

Legend 命中后附加到通用 metadata 的不可变负载。公开字段用于宿主识别语义；内部运行时身份
只供无状态控制器在 queued action 中防止组件重排串用。

## 属性

| 名称 | 说明 |
| --- | --- |
| `CanSelect` | 获取普通项是否允许转换为选择 action。 |
| `ComponentId` | 获取 Legend 显式 Id。 |
| `ComponentIndex` | 获取 Legend 在同主类型组件中的索引。 |
| `HoverTargets` | 获取当前普通项允许由 Legend hover 强调的目标子集。 |
| `Key` | 获取普通图例项稳定键。 |
| `Kind` | 获取交互区域用途。 |
| `Name` | 获取普通图例项名称；selector 和分页按钮为空。 |
| `ScrollDataIndex` | 获取分页按钮目标起始索引；非分页按钮为空。 |
| `TargetBounds` | 获取普通项在图表视口中的已解析命中边界；selector 与分页控件为空。 |
| `Targets` | 获取当前普通项控制的 series/data-item 目标；控制按钮为空。 |
| `TooltipShow` | 获取当前命中是否允许 M1.6 Tooltip 生成内容。 |
