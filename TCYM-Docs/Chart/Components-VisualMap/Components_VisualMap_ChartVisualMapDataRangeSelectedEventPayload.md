# ChartVisualMapDataRangeSelectedEventPayload

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.VisualMap`　**Chart 版本**：`0.1.1.25`

## 概述

保存一次 action 成功提交的全部 VisualMap 结果。

## 构造函数

### `ChartVisualMapDataRangeSelectedEventPayload(Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.VisualMap.ChartVisualMapDataRangeSelectedEventItem})`

创建并冻结非空事件批次。

| 参数 | 说明 |
| --- | --- |
| `batch` | 按有效组件顺序排列的非空结果。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Batch` | 获取按有效组件顺序排列的只读结果。 |
| `Range` | 单 continuous 事件时获取最终范围。 |
| `Selected` | 单 piecewise 事件时获取选择映射。 |
| `VisualMapId` | 单组件事件时获取组件 ID。 |
| `VisualMapIndex` | 单组件事件时获取组件索引。 |
| `VisualMapName` | 单组件事件时获取组件名称。 |
