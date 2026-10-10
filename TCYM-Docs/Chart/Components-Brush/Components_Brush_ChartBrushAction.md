# ChartBrushAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Brush`　**Chart 版本**：`0.1.1.25`

## 概述

替换、清除或查询一个或多个 Brush 组件 Engine-local areas 的 action。

## 构造函数

### `ChartBrushAction(Collections.Generic.IEnumerable{TCYM.UI.Chart.Model.ChartBrushArea},TCYM.UI.Chart.Components.Brush.ChartBrushComponentSelector)`

创建显式替换 areas 的 action；空序列清除目标组件区域。

| 参数 | 说明 |
| --- | --- |
| `areas` | 要立即深复制的区域。 |
| `selector` | 目标 Brush 组件选择器。 |

### `ChartBrushAction(TCYM.UI.Chart.Components.Brush.ChartBrushComponentSelector)`

创建保留当前 areas并请求重新计算选择结果的 action。

| 参数 | 说明 |
| --- | --- |
| `selector` | 目标 Brush 组件选择器。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | 获取 ECharts 兼容 action 类型。 |
| `EventType` | 获取 action 成功提交后发布的事件类型。 |
