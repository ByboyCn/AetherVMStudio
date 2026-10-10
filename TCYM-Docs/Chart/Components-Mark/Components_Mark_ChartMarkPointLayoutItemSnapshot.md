# ChartMarkPointLayoutItemSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个已经投影并通过数据域准入的 markPoint 布局项。

## 构造函数

### `ChartMarkPointLayoutItemSnapshot(TCYM.UI.Chart.Components.Mark.ChartMarkPointItemSnapshot,SkiaSharp.SKPoint,SkiaSharp.SKRect)`

创建一个与规范化 Mark 数据项深度隔离的像素布局项。

| 参数 | 说明 |
| --- | --- |
| `item` | 规范化 markPoint 数据项。 |
| `point` | 应用宿主投影与 x/y 覆盖后的有限像素中心。 |
| `clipBounds` | 宿主二维坐标系的最终粗包围盒；该兼容名称不表示 View 会裁剪 symbol 外沿。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `ClipBounds` | 获取宿主二维坐标系的最终粗包围盒；该兼容属性不表示渲染裁剪。 |
| `CoordinateSystemBounds` | 获取宿主 Grid 内容区或 Polar 外圆的最终粗包围盒。 |
| `Item` | 获取规范化 markPoint 数据项的独占快照。 |
| `Point` | 获取最终图表本地像素中心。 |
