# UICpuRenderStatus

> **类型**：Record　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

最近一次 CPU 窗口决策；Queued 不表示已显示，Presented 才表示 SDL 呈现成功。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `RequestedMode` | `UICpuRenderMode` |  |
| `Stage` | `string` |  |
| `Reason` | `string` |  |
| `Generation` | `long` |  |
| `Sequence` | `long` |  |
| `RasterThreadId` | `int` |  |
