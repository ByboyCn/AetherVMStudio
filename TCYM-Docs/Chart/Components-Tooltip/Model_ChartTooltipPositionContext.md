# ChartTooltipPositionContext

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

保存 Tooltip position 回调使用的只读几何和 formatter 参数快照。

## 构造函数

### `ChartTooltipPositionContext(SkiaSharp.SKPoint,TCYM.UI.Chart.Components.Tooltip.ChartTooltipFormatterContext,Nullable{SkiaSharp.SKRect},SkiaSharp.SKSize,SkiaSharp.SKSize)`

创建一次位置回调上下文。

| 参数 | 说明 |
| --- | --- |
| `point` | 相对于图表视口的有限触发点。 |
| `formatterContext` | 本次内容格式化使用的不可变上下文。 |
| `targetBounds` | 可选命中图元包围盒。 |
| `viewSize` | 有限非负图表视口尺寸。 |
| `contentSize` | 有限非负 Tooltip 内容尺寸。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `ContentSize` | 获取已经完成测量的 Tooltip 内容尺寸。 |
| `FormatterContext` | 获取本次 formatter 的不可变参数与 ticket。 |
| `Point` | 获取触发 Tooltip 的图表视口坐标。 |
| `TargetBounds` | 获取命中图元包围盒；axis 或纯坐标触发时可为空。 |
| `ViewSize` | 获取图表视口尺寸。 |
