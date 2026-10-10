# ChartSeriesAxisExtentContribution

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个系列对一根连续轴的规范化数据域贡献。

## 构造函数

### `ChartSeriesAxisExtentContribution(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,TCYM.UI.Chart.Model.ChartAxisType,TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleExtent,Int32,Boolean)`

创建带有几何起点需求的轴范围贡献。

| 参数 | 说明 |
| --- | --- |
| `axis` | 目标轴的规范身份。 |
| `axisType` | 构建贡献时使用的 value、time 或 log 类型。 |
| `extent` | 已过滤无效值的数值域；time 使用 Unix 毫秒。 |
| `validCount` | 参与该域的有效值数量。 |
| `requiresStartValue` | 系列是否要求该轴提供并容纳几何起点。 |

### `ChartSeriesAxisExtentContribution(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,TCYM.UI.Chart.Model.ChartAxisType,TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleExtent,Int32)`

创建轴范围贡献。

| 参数 | 说明 |
| --- | --- |
| `axis` | 目标轴的规范身份。 |
| `axisType` | 构建贡献时使用的 value、time 或 log 类型。 |
| `extent` | 已过滤无效值的数值域；time 使用 Unix 毫秒。 |
| `validCount` | 参与该域的有效值数量。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Axis` | 获取目标轴身份。 |
| `AxisType` | 获取贡献采用的连续轴类型。 |
| `Extent` | 获取应用轴 min/max、boundaryGap 与 nice 之前的有效数据域。 |
| `RequiresStartValue` | 获取当前系列是否要求该连续轴发布并容纳几何起点。 |
| `ValidCount` | 获取参与数据域的有效值数量。 |
