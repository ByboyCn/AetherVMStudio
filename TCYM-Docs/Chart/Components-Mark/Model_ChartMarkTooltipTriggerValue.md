# ChartMarkTooltipTriggerValue

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 mark Tooltip 的 item/axis/none 或布尔兼容触发值。

## 构造函数

### `ChartMarkTooltipTriggerValue(Boolean)`

从 ECharts 兼容布尔触发值创建 mark 值。

| 参数 | 说明 |
| --- | --- |
| `enabled` | 是否允许该标记触发 Tooltip。 |

### `ChartMarkTooltipTriggerValue(TCYM.UI.Chart.Model.ChartTooltipTrigger)`

从强类型 Tooltip 触发枚举创建 mark 值。

| 参数 | 说明 |
| --- | --- |
| `trigger` | item、axis 或 none。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `BooleanValue` | 获取布尔兼容值；仅在 `Kind` 为 Boolean 时有效。 |
| `Kind` | 获取联合类型。 |
