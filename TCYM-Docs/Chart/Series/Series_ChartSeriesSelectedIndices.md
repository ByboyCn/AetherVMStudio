# ChartSeriesSelectedIndices

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个系列在 `selectchanged` 事件中的选中原始索引。

## 构造函数

### `ChartSeriesSelectedIndices(Int32,String,String,TCYM.UI.Chart.Series.ChartSeriesDataType,Collections.Generic.IEnumerable{Int32})`

创建一个已经复制索引集合的系列选择快照。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | 系列在当前有效配置中的索引。 |
| `seriesId` | 系列显式 ID。 |
| `seriesName` | 系列显式名称。 |
| `dataType` | 索引所属的数据集合类型。 |
| `dataIndices` | 按升序排列的 lineage 根原始索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataIndices` | 获取按升序排列的 lineage 根原始索引。 |
| `DataType` | 获取索引所属的数据集合类型。 |
| `SeriesId` | 获取系列显式 ID。 |
| `SeriesIndex` | 获取系列在当前有效配置中的索引。 |
| `SeriesName` | 获取系列显式名称。 |
