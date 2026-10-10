# ChartMarkAreaItemSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个由严格 start/end 端点对组成的 markArea 数据项。

## 构造函数

### `ChartMarkAreaItemSnapshot(TCYM.UI.Chart.Components.Mark.ChartMarkItemKey,Int32,Int32,TCYM.UI.Chart.Components.Mark.ChartMarkResolvedPositionSnapshot,TCYM.UI.Chart.Components.Mark.ChartMarkResolvedPositionSnapshot,String,String,Nullable{TCYM.UI.Chart.Data.ChartValue})`

创建一个强类型 markArea 运行时快照。

| 参数 | 说明 |
| --- | --- |
| `key` | Area 类型稳定键。 |
| `dataIndex` | Mark option Data 中的原始 dataIndex。 |
| `insideIndex` | 过滤无效项后的连续 Area insideIndex。 |
| `start` | 区域第一端点。 |
| `end` | 区域对角端点。 |
| `id` | 可选业务 ID。 |
| `name` | 可选显示名称。 |
| `displayValue` | 可选显示值。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `End` | 获取区域对角端点。 |
| `Shape` | 获取数据形态。 |
| `Start` | 获取区域第一端点。 |
