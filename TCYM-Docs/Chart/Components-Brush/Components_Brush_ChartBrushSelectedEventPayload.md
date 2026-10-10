# ChartBrushSelectedEventPayload

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Brush`　**Chart 版本**：`0.1.1.25`

## 概述

保存一次 brushselected 事件的非空 Brush 组件批次。

## 构造函数

### `ChartBrushSelectedEventPayload(Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Brush.ChartBrushSelectedEventBatchItem})`

复制按有效 Brush 组件顺序排列的非空选择批次。

| 参数 | 说明 |
| --- | --- |
| `batch` | 选择结果项。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Batch` | 获取按有效 Brush 组件顺序排列的不可变选择批次。 |
