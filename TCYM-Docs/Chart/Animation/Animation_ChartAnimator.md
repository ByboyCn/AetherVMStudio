# ChartAnimator

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Animation`　**Chart 版本**：`0.1.1.25`

## 概述

图表共享的逐帧补间时钟。它与 `UIElement` 动画系统相互独立，并把所有操作
绑定到创建线程；图表宿主应在收到 `Changed` 后安排下一帧。

## 构造函数

### `ChartAnimator`

在当前线程创建一个独立动画时钟。

### `ChartAnimator(Object,TCYM.UI.Chart.Core.IChartMonotonicClock)`

创建绑定指定 Engine 运行时令牌和可选单调时钟的动画时钟。

| 参数 | 说明 |
| --- | --- |
| `runtimeToken` | 用于隔离 owner 工作的 Engine 引用令牌。 |
| `clock` | 可选单调时钟；为空时创建默认 Stopwatch 时钟。 |

### `ChartAnimator(Object)`

创建绑定指定 Engine 运行时令牌的动画时钟。

| 参数 | 说明 |
| --- | --- |
| `runtimeToken` | 用于隔离 owner 工作的 Engine 引用令牌。 |

### `ChartAnimator(TCYM.UI.Chart.Core.IChartMonotonicClock)`

在当前线程使用指定单调时钟创建一个独立动画时钟。

| 参数 | 说明 |
| --- | --- |
| `clock` | 可控或平台单调时钟；不能为 `null`。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `IsDisposed` | 获取动画时钟是否已经释放。 |
| `IsRunning` | 获取是否仍有等待开始或尚未完成的补间。 |

## 事件

| 名称 | 说明 |
| --- | --- |
| `Changed` | 新增、结束或取消动画后触发，宿主可据此调度或停止后续帧。 |
| `Faulted` | 用户动画回调发生异常时触发；异常补间会被终止，不会污染后续帧。 |

## 方法

### `Add(Int32,Action{Single},Int32,String,Action)`

添加一个从 0 到 1 推进的数值补间。

| 参数 | 说明 |
| --- | --- |
| `duration` | 补间持续时间（毫秒）；负值按 0 处理。 |
| `update` | 每帧接收缓动后进度的回调。 |
| `delay` | 开始前延迟（毫秒）；负值按 0 处理。 |
| `easing` | 缓动名称；未知名称回退为 cubicOut。 |
| `completed` | 补间自然完成后调用的回调；取消时不会调用。 |

**返回：** 可用于提前取消此次补间的句柄。

### `Advance`

使用当前单调时钟推进全部补间一次。用户回调异常会被隔离并通过
`Faulted` 报告。

**返回：** 推进后仍需要后续帧时为 `true`。

### `CheckAccess`

判断调用线程是否为创建该动画时钟的线程。

### `Clear`

取消并移除所有补间。若在 `Advance` 回调内调用，清理会安全延迟到
当前快照遍历结束，且本轮尚未执行的补间不会再运行。

### `Dispose`

在创建线程上取消全部补间并释放时钟。重复调用安全；释放后事件订阅会被清空。

### `VerifyAccess`

验证当前线程具有访问权，否则抛出 `InvalidOperationException`。
