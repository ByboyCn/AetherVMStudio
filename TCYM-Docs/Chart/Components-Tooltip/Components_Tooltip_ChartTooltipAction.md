# ChartTooltipAction

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

表示可按 Tooltip 的显式 Id、Name 或同类索引选择目标组件的强类型 action。
自动交互请求还会携带程序集内部 RuntimeUid，防止排队期间组件重排后误命中。

## 属性

| 名称 | 说明 |
| --- | --- |
| `TooltipId` | 获取目标 Tooltip 的显式 Id 查询条件。 |
| `TooltipIndex` | 获取目标 Tooltip 的同类索引查询条件。 |
| `TooltipName` | 获取目标 Tooltip 的显式 Name 查询条件。 |
