# ChartDataWindowFilterMode

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Extensions`　**Chart 版本**：`0.1.1.25`

## 概述

指定 dataZoom 应如何处理窗口之外的数据。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `Empty` | 保留数据项，但把窗口外的相关维度置为空值。 |
| `Filter` | 移除任一相关维度落在窗口外的数据项。 |
| `None` | 不修改数据，只发布窗口供布局或视觉阶段消费。 |
| `WeakFilter` | 仅移除所有相关维度都位于窗口同一侧的数据项。 |
