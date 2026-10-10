# IChartImmutableRuntimeState

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Core.Runtime`　**Chart 版本**：`0.1.1.25`

## 概述

标记可进入 Engine 运行时状态存储的不可变快照。实现不得在发布后就地改变公开数据，也不得持有
`ChartScene`、View、图元或其他跨组件生命周期的可变渲染句柄。
