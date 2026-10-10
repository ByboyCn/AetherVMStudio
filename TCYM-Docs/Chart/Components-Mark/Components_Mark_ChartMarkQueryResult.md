# ChartMarkQueryResult

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存一次成功 Mark 查询返回的宿主系列身份和强类型不可变 item。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ComponentType` | 获取 ECharts 风格组件类型；命中 Point、Line、Area 时分别返回<br />markPoint、markLine、markArea，默认结果为空。 |
| `DataIndex` | 获取命中 Mark 自身 dataIndex；默认结果为 -1。 |
| `HasValue` | 获取当前结果是否包含一个成功命中的 item。 |
| `InsideIndex` | 获取命中 Mark 连续 insideIndex；默认结果为 -1。 |
| `Item` | 获取命中的查询自有强类型 item；默认结果为空。 |
| `Key` | 获取命中 Mark 复合稳定键；默认结果为无效默认键。 |
| `Kind` | 获取命中 Mark 类型；默认结果为 Point，调用方应先检查 Item。 |
| `SeriesId` | 获取宿主系列可选 ID。 |
| `SeriesIndex` | 获取宿主系列索引；默认结果为 0，调用方应先检查 Item。 |
| `SeriesName` | 获取宿主系列可选名称。 |
| `SeriesRuntimeUid` | 获取宿主系列 canonical RuntimeUid；默认结果为 0。 |
| `SeriesType` | 获取宿主系列类型；默认结果为空。 |
| `Visible` | 获取宿主系列在发布该查询时是否可见。 |
