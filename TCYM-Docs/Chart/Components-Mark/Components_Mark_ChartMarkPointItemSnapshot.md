# ChartMarkPointItemSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个规范化 markPoint 数据项。

## 构造函数

### `ChartMarkPointItemSnapshot(TCYM.UI.Chart.Components.Mark.ChartMarkItemKey,Int32,Int32,TCYM.UI.Chart.Components.Mark.ChartMarkResolvedPositionSnapshot,String,String,Nullable{TCYM.UI.Chart.Data.ChartValue})`

创建 markPoint 强类型运行时快照。

| 参数 | 说明 |
| --- | --- |
| `key` | Point 类型稳定键。 |
| `dataIndex` | Mark option Data 中的原始 dataIndex。 |
| `insideIndex` | 过滤无效项后的连续 Point insideIndex。 |
| `position` | 数据域位置与可选屏幕覆盖。 |
| `id` | 可选业务 ID。 |
| `name` | 可选显示名称。 |
| `displayValue` | 可选显示值。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Position` | 获取规范化 Point 位置。 |
| `Shape` | 获取数据形态。 |
