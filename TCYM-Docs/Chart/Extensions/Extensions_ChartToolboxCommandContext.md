# ChartToolboxCommandContext

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Extensions`　**Chart 版本**：`0.1.1.25`

## 概述

向 toolbox 命令公开当前 action 的安全构建上下文。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Artifacts` | 获取当前已发布制品的只读门面。 |
| `Commands` | 获取只允许同步排队 action 或请求重绘的命令门面。<br />本协议不公开 Animator、FrameScheduler、RenderTarget 或其他长生命周期工作入口；<br />需要异步工作的 feature 应排队由独立 handler owner 管理的专用 action。 |
| `Option` | 获取当前有效 Option 快照。修改该快照不会写回 Engine；业务状态应通过强类型 action 更新。 |
| `RuntimeState` | 获取绑定精确 action invocation 的运行时状态只读门面。<br />离开命令同步回调后重新访问会被拒绝。 |
| `RuntimeStateMutation` | 获取当前 action 事务的运行时状态写门面。<br />离开命令同步回调后重新访问或使用已捕获门面都会失败。 |
| `SeriesData` | 获取当前 Engine 的只读系列数据运行时。 |
| `Theme` | 获取当前有效 Theme 快照。 |
| `Viewport` | 获取当前图表视口。 |
