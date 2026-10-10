# ChartPieLabelLineSmooth

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Pie labelLine.smooth 的布尔值或 0～1 平滑强度。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Automatic` | 获取使用默认强度的平滑值。 |
| `Disabled` | 获取关闭平滑的值。 |
| `Enabled` | 获取是否启用平滑引导线。 |
| `Tension` | 获取明确的 0～1 平滑强度；空表示布尔 `true` 的默认强度。 |

## 方法

### `FromTension(Single)`

从明确的 0～1 强度创建平滑值。

| 参数 | 说明 |
| --- | --- |
| `tension` | 平滑强度。 |

**返回：** 启用平滑的联合值。
