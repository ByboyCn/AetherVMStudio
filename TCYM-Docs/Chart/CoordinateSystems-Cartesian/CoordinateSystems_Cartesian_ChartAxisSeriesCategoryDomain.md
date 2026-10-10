# ChartAxisSeriesCategoryDomain

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

保存当前 Layout 候选中一根 category 轴从可见系列数据聚合出的稳定分类域。

## 构造函数

### `ChartAxisSeriesCategoryDomain(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},Int32)`

创建一根轴的不可变系列分类域。

| 参数 | 说明 |
| --- | --- |
| `axis` | 目标 category 轴的规范身份。 |
| `categories` | 按系列和处理后数据顺序稳定去重的分类值。 |
| `seriesCount` | 参与当前轴分类域治理的可见系列数量，包括空数据系列。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Axis` | 获取目标 category 轴的规范身份。 |
| `Categories` | 获取按首次出现顺序冻结的分类值。 |
| `SeriesCount` | 获取参与当前分类域治理的可见系列数量，包括空数据系列。 |
