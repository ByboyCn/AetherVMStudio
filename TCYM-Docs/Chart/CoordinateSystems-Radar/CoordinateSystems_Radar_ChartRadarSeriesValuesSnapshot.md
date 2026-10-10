# ChartRadarSeriesValuesSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Radar`　**Chart 版本**：`0.1.1.25`

## 概述

Data 阶段向 Radar 坐标层提交的中性、不可变多维数据。

## 构造函数

### `ChartRadarSeriesValuesSnapshot(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Radar.ChartRadarValuesItem},TCYM.UI.Chart.Data.ChartDataView)`

捕获一个系列的数据身份与独立项目列表。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Items` | 获取独立项目列表。 |
| `SeriesIndex` | 获取系列索引。 |
| `SourceData` | 获取该快照捕获的确切 Data 视图；坐标发布必须与当前运行时代次相同。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,TCYM.UI.Chart.Data.ChartDataView)`

同时验证系列身份、索引和当前 Data 视图引用；缺失数据来源不能通过验证。

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption,Int32)`

验证该快照属于指定 effective 系列及索引。
