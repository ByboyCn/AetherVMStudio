# ChartTooltipFormatterContext

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

保存一次 formatter 调用的稳定 ticket 和 item/axis 参数数组。

## 构造函数

### `ChartTooltipFormatterContext(String,Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Tooltip.ChartTooltipFormatterParameters},Globalization.CultureInfo)`

创建 formatter 上下文并复制参数集合。

| 参数 | 说明 |
| --- | --- |
| `ticket` | 用于拒绝过期异步结果的非空稳定票据。 |
| `parameters` | item 使用一项，axis 使用一项或多项。 |
| `culture` | 数字和时间格式化使用的区域性。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Culture` | 获取只读区域性快照；默认结构返回 InvariantCulture。 |
| `IsAxis` | 获取参数是否来自 axis 聚合。 |
| `Parameters` | 获取 item 或 axis formatter 参数快照。 |
| `Ticket` | 获取拒绝过期异步结果使用的稳定票据。 |
