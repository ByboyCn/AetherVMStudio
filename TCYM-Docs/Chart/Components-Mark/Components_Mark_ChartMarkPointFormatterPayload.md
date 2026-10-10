# ChartMarkPointFormatterPayload

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存 formatter 与公开事件可读取的深度不可变 markPoint 原始数据快照。

## 构造函数

### `ChartMarkPointFormatterPayload(TCYM.UI.Chart.Components.Mark.ChartMarkPointItemSnapshot,TCYM.UI.Chart.Data.ChartValue)`

从一个规范化 markPoint 项创建不可变 formatter 负载。

| 参数 | 说明 |
| --- | --- |
| `item` | 当前规范化数据项。 |
| `value` | Label 与 Tooltip 使用的最终主值。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataIndex` | 获取该项在 markPoint data 中的原始索引。 |
| `DataIndexInside` | 获取该项在当前有效 markPoint 视图中的连续索引。 |
| `Id` | 获取可选业务 ID。 |
| `Key` | 获取带 Point 命名空间的 Mark 稳定键。 |
| `Name` | 获取可选显示名称。 |
| `SourceLineages` | 获取参与统计或坐标定位的真实宿主数据 lineage。 |
| `Value` | 获取已隔离的最终主值。 |
