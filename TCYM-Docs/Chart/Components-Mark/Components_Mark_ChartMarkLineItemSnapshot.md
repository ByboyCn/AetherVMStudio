# ChartMarkLineItemSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个一维轴线或双端点 markLine 数据项。

## 构造函数

### `ChartMarkLineItemSnapshot(TCYM.UI.Chart.Components.Mark.ChartMarkItemKey,Int32,Int32,TCYM.UI.Chart.Components.Mark.ChartMarkShape,TCYM.UI.Chart.Components.Mark.ChartMarkResolvedPositionSnapshot,TCYM.UI.Chart.Components.Mark.ChartMarkResolvedPositionSnapshot,String,String,Nullable{TCYM.UI.Chart.Data.ChartValue})`

创建一个强类型 markLine 运行时快照。

| 参数 | 说明 |
| --- | --- |
| `key` | Line 类型稳定键。 |
| `dataIndex` | Mark option Data 中的原始 dataIndex。 |
| `insideIndex` | 过滤无效项后的连续 Line insideIndex。 |
| `shape` | AxisLine 或 LineSegment。 |
| `start` | 轴值位置或线段起点。 |
| `end` | 线段终点；AxisLine 必须为空。 |
| `id` | 可选业务 ID。 |
| `name` | 可选显示名称。 |
| `displayValue` | 可选显示值。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `End` | 获取双端点线终点；一维轴线为空。 |
| `Shape` | 获取数据形态。 |
| `Start` | 获取一维轴值位置或双端点线起点。 |
