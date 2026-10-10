# UIGpuRenderStatus

> **类型**：Record　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

GPU 线程执行诊断；Presented 只在实际窗口交换成功后写入。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `RequestedMode` | `UIGpuRenderMode` |  |
| `Stage` | `string` |  |
| `Reason` | `string` |  |
| `RecordingThreadId` | `int` |  |
| `RenderingThreadId` | `int` |  |
| `PresentationThreadId` | `int` |  |
