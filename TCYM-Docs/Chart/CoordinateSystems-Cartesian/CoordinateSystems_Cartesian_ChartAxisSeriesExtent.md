# ChartAxisSeriesExtent

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

保存所有可见系列对一根轴合并后的不可变数据域。

## 构造函数

### `ChartAxisSeriesExtent(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,TCYM.UI.Chart.Model.ChartAxisType,TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleExtent,Int32,Int32,Boolean)`

创建带有可见系列几何起点需求的聚合轴范围。

| 参数 | 说明 |
| --- | --- |
| `axis` | 目标轴身份。 |
| `axisType` | 连续轴类型。 |
| `extent` | 全部可见系列的联合域。 |
| `validCount` | 联合域包含的有效值数量。 |
| `seriesCount` | 绑定到该轴并发布贡献的可见系列数量，包括仅含空值的系列。 |
| `requiresStartValue` | 至少一个可见系列是否要求该轴提供并容纳几何起点。 |

### `ChartAxisSeriesExtent(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,TCYM.UI.Chart.Model.ChartAxisType,TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleExtent,Int32,Int32)`

创建聚合后的轴范围。

| 参数 | 说明 |
| --- | --- |
| `axis` | 目标轴身份。 |
| `axisType` | 连续轴类型。 |
| `extent` | 全部可见系列的联合域。 |
| `validCount` | 联合域包含的有效值数量。 |
| `seriesCount` | 绑定到该轴并发布贡献的可见系列数量，包括仅含空值的系列。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Axis` | 获取目标轴身份。 |
| `AxisType` | 获取连续轴类型。 |
| `Extent` | 获取全部可见系列的联合原始域。 |
| `RequiresStartValue` | 获取至少一个可见系列是否要求该连续轴发布并容纳几何起点。 |
| `SeriesCount` | 获取绑定到该轴并发布贡献的可见系列数量，包括仅含空值的系列。 |
| `ValidCount` | 获取全部有效值数量。 |

## 方法

### `ToScaleValues`

创建供现有 ScaleBuilder 消费的最小端点序列。空域不产生值，单点域只产生一个值。

**返回：** 以规范数值表示的零至两个端点。
