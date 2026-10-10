# ChartFrameTask

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

表示由 `ChartFrameScheduler` 管理的逐帧任务句柄。

## 属性

| 名称 | 说明 |
| --- | --- |
| `IsCanceled` | 获取任务是否已请求取消或已完成取消。 |

## 方法

### `Cancel`

可从任意线程请求取消。此方法不会直接调用取消回调；调度器会在所属线程推进、清空、
取消 owner 或释放时至多调用该回调一次。
