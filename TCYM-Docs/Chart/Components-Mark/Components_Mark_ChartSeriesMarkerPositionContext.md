# ChartSeriesMarkerPositionContext

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存 Cartesian 宿主自定义 markPoint 定位所需的当前候选只读信息。

## 构造函数

### `ChartSeriesMarkerPositionContext(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,TCYM.UI.Chart.Components.Mark.ChartMarkPointItemSnapshot,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartCartesianSeriesBinding)`

创建一次只服务于当前 Layout 调用的定位上下文。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效宿主系列。 |
| `seriesIndex` | 宿主系列在有效 option 中的索引。 |
| `item` | 当前规范化 markPoint 数据项。 |
| `binding` | 宿主系列的最终 Cartesian 绑定。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Binding` | 获取宿主系列的最终 Cartesian 绑定。 |
| `Item` | 获取当前规范化 markPoint 数据项。 |
| `Series` | 获取当前有效宿主系列。 |
| `SeriesIndex` | 获取宿主系列在有效 option 中的索引。 |
