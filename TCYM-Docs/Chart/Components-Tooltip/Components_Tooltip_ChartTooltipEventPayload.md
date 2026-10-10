# ChartTooltipEventPayload

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

保存 showTip/hideTip 语义事件的不可变原生负载。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Generation` | 获取本次显示状态的代次。 |
| `Point` | 获取可选最终锚点。 |
| `Ticket` | 获取可选 formatter ticket。 |
| `TooltipIndex` | 获取命中的 Tooltip 同类索引。 |
| `Visible` | 获取 action 完成后内容是否可见。 |
