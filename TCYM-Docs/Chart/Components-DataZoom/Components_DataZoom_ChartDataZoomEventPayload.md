# ChartDataZoomEventPayload

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.DataZoom`　**Chart 版本**：`0.1.1.25`

## 概述

保存 `datazoom` 语义事件中全部已改变组件的不可变范围快照。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Batch` | 获取按有效 option 顺序排列的已改变组件范围。 |
| `End` | 获取单目标事件的窗口终点；批次包含多项时返回空值。 |
| `Start` | 获取单目标事件的窗口起点；批次包含多项时返回空值。 |
