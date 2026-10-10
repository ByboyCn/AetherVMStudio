# ChartDataWindow

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Extensions`　**Chart 版本**：`0.1.1.25`

## 概述

描述一个已经规范化为百分比的 dataZoom 窗口。
请求快照和解析快照共用此不可变值，未来模块可在解析阶段把 value 范围转换为百分比。

## 构造函数

### `ChartDataWindow(Int32,TCYM.UI.Chart.Extensions.ChartDataWindowTarget,Double,Double,TCYM.UI.Chart.Extensions.ChartDataWindowFilterMode)`

创建一个不可变数据窗口。

| 参数 | 说明 |
| --- | --- |
| `sourceIndex` | 产生窗口的 dataZoom 同类索引。 |
| `target` | 目标坐标轴。 |
| `startPercent` | 包含端点的起始百分比，范围为 0～100。 |
| `endPercent` | 包含端点的结束百分比，范围为 0～100 且不小于起点。 |
| `filterMode` | 窗口外数据的处理模式。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `EndPercent` | 获取包含端点的结束百分比。 |
| `FilterMode` | 获取窗口外数据的处理模式。 |
| `SourceIndex` | 获取产生窗口的 dataZoom 同类索引。 |
| `StartPercent` | 获取包含端点的起始百分比。 |
| `Target` | 获取目标坐标轴。 |
