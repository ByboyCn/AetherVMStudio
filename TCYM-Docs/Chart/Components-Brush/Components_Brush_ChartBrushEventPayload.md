# ChartBrushEventPayload

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Brush`　**Chart 版本**：`0.1.1.25`

## 概述

保存一次 brush 或 brushEnd action 成功提交的非空组件批次。

## 构造函数

### `ChartBrushEventPayload(Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Brush.ChartBrushEventBatchItem})`

复制按有效 Brush 组件顺序排列的非空事件批次。

| 参数 | 说明 |
| --- | --- |
| `batch` | 组件事件项。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Areas` | 获取单组件事件的区域深副本；多组件事件返回空。 |
| `Batch` | 获取按有效 Brush 组件顺序排列的只读批次。 |
| `BrushId` | 获取单组件事件的 ID；多组件事件返回空。 |
| `BrushIndex` | 获取单组件事件的索引；多组件事件返回空。 |
| `BrushName` | 获取单组件事件的名称；多组件事件返回空。 |
