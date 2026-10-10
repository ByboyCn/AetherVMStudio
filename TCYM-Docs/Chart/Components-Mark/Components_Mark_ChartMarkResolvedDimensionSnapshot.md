# ChartMarkResolvedDimensionSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存规范化位置中的一个坐标维。普通值和统计值共用该类型；统计分支额外携带
`Statistic`，真实数据点来源则由可选 `SourceLineage` 表示。

## 构造函数

### `ChartMarkResolvedDimensionSnapshot(Int32,String,TCYM.UI.Chart.Data.ChartValue,Nullable{TCYM.UI.Chart.Data.ChartSeriesCoordinateSource},TCYM.UI.Chart.Components.Mark.ChartMarkDimensionStatisticSnapshot,TCYM.UI.Chart.Components.Mark.ChartMarkSourceLineage)`

创建一个已经按 schema/encode 解析的坐标维快照。

| 参数 | 说明 |
| --- | --- |
| `coordinateDimensionIndex` | 二维坐标中的规范序号，只能为 0 或 1。 |
| `channel` | 规范 encode 通道，例如 x、y、radius 或 angle。 |
| `value` | 最终数据域值。 |
| `source` | 可选 schema 数据来源；显式坐标值可以为空。 |
| `statistic` | 可选逐维统计元数据。 |
| `sourceLineage` | 可选真实宿主数据项 lineage。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Channel` | 获取规范 encode 通道。 |
| `CoordinateDimensionIndex` | 获取当前维在二维坐标中的规范序号。 |
| `IsStatistic` | 获取当前维是否来自统计计算。 |
| `Source` | 获取可选 schema 数据来源。 |
| `SourceLineage` | 获取可选真实宿主数据项 lineage。 |
| `Statistic` | 获取可选逐维统计元数据。 |
| `Value` | 获取经过 payload 隔离的最终数据域值。 |
