# IChartActionHandler

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

表示一个由 `DispatchAction` 调用的 action 处理器。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ActionType` | 获取此处理器接受的 action 类型。 |

## 方法

### `Handle(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Core.ChartAction)`

执行 action 并返回需要重新运行的管线范围。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前已发布状态的只读回调上下文。 |
| `action` | 要执行的 action。 |

**返回：** 本次 action 引起的更新标志。
