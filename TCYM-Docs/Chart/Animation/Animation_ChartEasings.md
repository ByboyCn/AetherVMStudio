# ChartEasings

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Animation`　**Chart 版本**：`0.1.1.25`

## 概述

提供与图表动画配置名称对应的内置缓动函数。

## 方法

### `Resolve(String)`

解析缓动名称。

| 参数 | 说明 |
| --- | --- |
| `name` | 不区分大小写的缓动名称；可为 `null`。 |

**返回：** 输入和输出均约定在 0..1 范围内的缓动函数；未知名称返回 cubicOut。
