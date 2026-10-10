# ChartMarkAreaLayoutItemSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个已经完成 Cartesian 相交过滤、数据 clamp 与屏幕覆盖的 markArea polygon 布局项。

## 构造函数

### `ChartMarkAreaLayoutItemSnapshot(TCYM.UI.Chart.Components.Mark.ChartMarkAreaItemSnapshot,Collections.Generic.IEnumerable{SkiaSharp.SKPoint},SkiaSharp.SKRect)`

创建一个与规范 Mark 制品和后续 option 更新隔离的区域布局项。

| 参数 | 说明 |
| --- | --- |
| `item` | 规范化 markArea 数据项。 |
| `points` | 按 start/start、end/start、end/end、start/end 排列的四个像素角。 |
| `gridBounds` | 宿主 Cartesian Grid 的最终有限边界。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Bounds` | 获取四角 polygon 的规范化轴对齐边界；屏幕覆盖允许它伸出 Grid。 |
| `GridBounds` | 获取宿主 Cartesian Grid 边界。 |
| `Item` | 获取当前布局独占的规范 markArea 项。 |
| `Points` | 获取保持 ECharts corner 顺序的四个最终像素角。 |
