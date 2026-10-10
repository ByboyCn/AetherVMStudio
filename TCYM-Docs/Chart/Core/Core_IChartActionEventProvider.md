# IChartActionEventProvider

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

由 action 处理器选择实现，用于在 action 完成后创建对应语义事件。

## 方法

### `CreateEvent(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Core.ChartAction)`

根据已执行的 action 创建语义事件。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前已发布状态的只读回调上下文。 |
| `action` | 刚完成的 action。 |

**返回：** 要派发的事件；返回 `null` 表示不派发。
