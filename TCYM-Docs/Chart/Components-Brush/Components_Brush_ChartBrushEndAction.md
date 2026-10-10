# ChartBrushEndAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Brush`　**Chart 版本**：`0.1.1.25`

## 概述

声明一次 Brush 物理手势已经结束并携带最终 areas 的 action。

## 构造函数

### `ChartBrushEndAction(Collections.Generic.IEnumerable{TCYM.UI.Chart.Model.ChartBrushArea},TCYM.UI.Chart.Components.Brush.ChartBrushComponentSelector)`

创建携带最终 areas 的手势结束 action。

| 参数 | 说明 |
| --- | --- |
| `areas` | 要立即深复制的最终区域。 |
| `selector` | 目标 Brush 组件选择器。 |

### `ChartBrushEndAction(TCYM.UI.Chart.Components.Brush.ChartBrushComponentSelector)`

创建保留当前 areas 的手势结束 action。

| 参数 | 说明 |
| --- | --- |
| `selector` | 目标 Brush 组件选择器。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | 获取 ECharts 兼容 action 类型。 |
| `EventType` | 获取 action 成功提交后发布的事件类型。 |
