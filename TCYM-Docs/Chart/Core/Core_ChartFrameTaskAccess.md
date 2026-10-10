# ChartFrameTaskAccess

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

owner 作用域的非补间逐帧任务 API；调度器的全局推进和清空仅由引擎执行。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Elapsed` | 获取自所属调度器创建以来的单调经过时间，供当前 owner 捕获延迟请求的相对起点。 |

## 方法

### `Schedule(Func{TimeSpan,Boolean},Action)`

为当前回调 owner 安排一个逐帧任务。

| 参数 | 说明 |
| --- | --- |
| `advance` | 逐帧回调；返回 `true` 继续，返回 `false` 完成。 |
| `canceled` | 任务被取消时在调度器所属线程调用一次的可选回调。 |

**返回：** 可从任意线程请求取消的任务句柄。
