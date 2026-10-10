# ChartCommandAccess

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

向 Engine 管理回调公开的安全命令门面。同步回调中的命令先进入 invocation 候选，只有回调成功
才发布；同一 invocation 创建的 FrameScheduler 回调可在恢复精确令牌后继续使用该门面。

## 方法

### `EnqueueAction(TCYM.UI.Chart.Core.ChartAction)`

把 action 追加到当前 Engine 的 FIFO 队列，在外围稳定边界执行而不重入当前回调。

| 参数 | 说明 |
| --- | --- |
| `action` | 要在当前 pointer/action/frame 批次结束后执行的 action。 |

### `RequestRender`

请求宿主重绘当前已发布场景；不隐式运行 processor 或 View。业务状态变化应排队 action，
并由 action 返回相应的 `ChartUpdateFlags`。
