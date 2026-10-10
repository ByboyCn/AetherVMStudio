# ChartLabelLineRouter

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Components.Label`　**Chart 版本**：`0.1.1.25`

## 概述

在固定 anchor 与标签端点之间解析 ECharts 风格的两段标签引导线。

## 说明

当两个配置长度与固定端点满足三角形条件时，两段实际长度分别严格等于
`length` 和 `length2`；固定标签位置使该条件不成立时，按长度比例退化为
共线路线。具体 series 可以在提交 descriptor 前按相同长度决定外部标签位置，从而避免退化。

## 方法

### `TryResolve(SkiaSharp.SKPoint,SkiaSharp.SKPoint,Single,Single,TCYM.UI.Chart.Components.Label.ChartLabelLineRoute@)`

根据两个固定端点和两段期望长度解析稳定三点路线。

| 参数 | 说明 |
| --- | --- |
| `start` | 有限 anchor 边界点。 |
| `end` | 有限标签边界点。 |
| `length` | 第一段有限非负期望长度。 |
| `length2` | 第二段有限非负期望长度。 |
| `route` | 成功时返回有限、确定的三点路线。 |

**返回：** 端点可形成非零路线且全部计算结果可表示时为 `true`。
