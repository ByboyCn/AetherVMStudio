# ChartSeriesContainQuery

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

描述一次系列像素包含查询。已提供的索引、ID、名称和类型按交集匹配；未提供的字段不参与过滤。

## 构造函数

### `ChartSeriesContainQuery(Nullable{Int32},String,String,String)`

创建至少包含一个系列选择条件的查询。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | 可选系列声明索引。 |
| `seriesId` | 可选系列显式 ID。 |
| `seriesName` | 可选系列名称。 |
| `seriesType` | 可选系列类型，例如 `pie`。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `HasSelector` | 获取查询是否含至少一个有效系列选择条件。 |
| `SeriesId` | 获取可选系列显式 ID。 |
| `SeriesIndex` | 获取可选系列声明索引。 |
| `SeriesName` | 获取可选系列名称。 |
| `SeriesType` | 获取可选系列类型。 |
