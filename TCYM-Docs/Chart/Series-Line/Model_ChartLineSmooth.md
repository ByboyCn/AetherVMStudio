# ChartLineSmooth

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts `smooth` 的布尔值或 0～1 数值联合类型。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Automatic` | 获取开启标准 0.5 平滑强度的值，对应 ECharts 的 `true`。 |
| `Disabled` | 获取关闭平滑的值。 |
| `Enabled` | 获取是否启用平滑折线。 |
| `Tension` | 获取显式平滑张力；为空表示使用 ECharts 的标准 0.5 平滑强度。 |

## 方法

### `FromTension(Single)`

使用明确的 0～1 张力创建平滑值。

| 参数 | 说明 |
| --- | --- |
| `tension` | 平滑张力。 |

**返回：** 启用且携带指定张力的值。
