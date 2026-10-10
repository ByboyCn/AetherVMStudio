# ChartDataZoomAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.DataZoom`　**Chart 版本**：`0.1.1.25`

## 概述

修改一个或多个 dataZoom 组件的 Engine-local 百分比窗口。查询条件为空时匹配全部当前
可用的 inside/slider dataZoom；交互控制器会额外绑定精确 RuntimeUid，避免排队期间组件重排后误命中。

## 构造函数

### `ChartDataZoomAction(Double,Double,String,Nullable{Int32})`

创建 dataZoom 百分比窗口 action。

| 参数 | 说明 |
| --- | --- |
| `start` | 包含端点的窗口起始百分比，范围为 0～100。 |
| `end` | 包含端点的窗口结束百分比，范围为 0～100 且不小于起点。 |
| `dataZoomId` | 可选 dataZoom 组件 ID。 |
| `dataZoomIndex` | 可选 dataZoom 同主类型索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataZoomId` | 获取可选 dataZoom 组件 ID 查询条件。 |
| `DataZoomIndex` | 获取可选 dataZoom 同主类型索引查询条件。 |
| `End` | 获取窗口结束百分比。 |
| `Start` | 获取窗口起始百分比。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | ECharts 兼容的 action 类型。 |
| `EventType` | action 成功改变窗口后发布的 ECharts 兼容事件类型。 |
