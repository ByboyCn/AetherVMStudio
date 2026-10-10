# ChartFrameScheduler

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

驱动渐进渲染、力导向布局、tooltip 计时器等非补间逐帧工作。
调度器具有创建线程亲和性；除 `Cancel` 外均应在所属线程调用。

## 构造函数

### `ChartFrameScheduler`

在当前线程创建空的逐帧调度器。

### `ChartFrameScheduler(Object,TCYM.UI.Chart.Core.IChartMonotonicClock)`

创建绑定指定 Engine 运行时令牌和可选单调时钟的调度器。

| 参数 | 说明 |
| --- | --- |
| `runtimeToken` | 用于隔离 owner 工作的 Engine 引用令牌。 |
| `clock` | 可选单调时钟；为空时创建默认 Stopwatch 时钟。 |

### `ChartFrameScheduler(Object)`

创建绑定指定 Engine 运行时令牌的逐帧调度器。

| 参数 | 说明 |
| --- | --- |
| `runtimeToken` | 用于隔离 owner 工作的 Engine 引用令牌。 |

### `ChartFrameScheduler(TCYM.UI.Chart.Core.IChartMonotonicClock)`

在当前线程使用指定单调时钟创建空的逐帧调度器。

| 参数 | 说明 |
| --- | --- |
| `clock` | 可控或平台单调时钟；不能为 `null`。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Elapsed` | 获取自调度器创建以来的单调经过时间；扩展应在创建延迟请求时捕获此值作为请求起点。 |
| `IsDisposed` | 获取调度器是否已释放。 |
| `IsRunning` | 获取是否存在等待下一次推进的任务。 |

## 事件

| 名称 | 说明 |
| --- | --- |
| `Changed` | 在任务集合或运行状态可能发生变化时触发。 |
| `Faulted` | 在逐帧回调或取消回调抛出异常时触发。 |

## 方法

### `Advance`

推进当前帧的任务快照，并处理完成、取消和故障。

**返回：** 推进结束后是否仍需下一帧。

### `CheckAccess`

检查当前线程是否为创建调度器的线程。

**返回：** 具有线程访问权时为 `true`。

### `Clear`

取消并移除全部任务。

**说明：** 每个已登记的取消回调至多执行一次；重入清空会合并为当前清理请求。

### `Dispose`

取消全部任务、释放调度器并断开事件订阅。

### `Schedule(Func{TimeSpan,Boolean},Action,TCYM.UI.Chart.Core.ChartRuntimeInvocationLease)`

注册由精确 Engine invocation 创建、具备事务式命令能力的逐帧回调。

| 参数 | 说明 |
| --- | --- |
| `advance` | 接收经过时间的逐帧回调。 |
| `canceled` | 可选同步取消回调。 |
| `runtimeInvocation` | 创建任务的精确运行时 lease。 |

**返回：** 可用于请求取消的任务句柄。

### `Schedule(Func{TimeSpan,Boolean},Action)`

注册逐帧回调。回调返回 `true` 请求下一帧，返回
`false` 正常完成任务。

| 参数 | 说明 |
| --- | --- |
| `advance` | 接收自调度器创建以来经过时间的逐帧回调。 |
| `canceled` | 取消时在调度器所属线程至多调用一次的回调。 |

**返回：** 可用于请求取消的任务句柄。

### `VerifyAccess`

验证当前线程具有调度器访问权。
