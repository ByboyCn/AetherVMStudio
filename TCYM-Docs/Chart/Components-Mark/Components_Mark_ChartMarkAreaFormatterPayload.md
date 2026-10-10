# ChartMarkAreaFormatterPayload

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存 formatter、Tooltip 与公开事件可读取的深度不可变 markArea 原始数据快照。

## 构造函数

### `ChartMarkAreaFormatterPayload(TCYM.UI.Chart.Components.Mark.ChartMarkAreaItemSnapshot,TCYM.UI.Chart.Data.ChartValue)`

从一个规范化 markArea 项创建不可变 formatter 负载。

| 参数 | 说明 |
| --- | --- |
| `item` | 当前规范化区域项。 |
| `value` | Label、Tooltip 与事件使用的最终主值。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataIndex` | 获取该项在 markArea data 中的原始索引。 |
| `DataIndexInside` | 获取模型规范化阶段冻结的 insideIndex；布局过滤后允许存在空洞。 |
| `Id` | 获取可选业务 ID。 |
| `Key` | 获取带 Area 命名空间的 Mark 稳定键。 |
| `Name` | 获取 start/end 合并后的可选显示名称。 |
| `Shape` | 获取固定的 Area 数据形状。 |
| `SourceLineages` | 获取参与统计或坐标定位的真实宿主数据 lineage。 |
| `Value` | 获取已经隔离的最终主值。 |
