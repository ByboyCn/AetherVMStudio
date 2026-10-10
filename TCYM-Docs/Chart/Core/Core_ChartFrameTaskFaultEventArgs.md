# ChartFrameTaskFaultEventArgs

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

提供逐帧任务回调失败的信息。

## 构造函数

### `ChartFrameTaskFaultEventArgs(TCYM.UI.Chart.Core.ChartFrameTask,Exception)`

提供逐帧任务回调失败的信息。

| 参数 | 说明 |
| --- | --- |
| `task` | 发生故障的任务。 |
| `exception` | 逐帧或取消回调抛出的异常。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Exception` | 获取回调抛出的异常。 |
| `Task` | 获取发生故障的任务。 |
