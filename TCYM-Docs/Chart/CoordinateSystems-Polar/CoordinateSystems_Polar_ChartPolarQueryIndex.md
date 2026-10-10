# ChartPolarQueryIndex

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

对 Polar 布局和坐标映射建立只读点查询索引。查询阶段只遍历固定数组并调用同一坐标快照的
Contains/PointToData，因此 containPixel、Tooltip 和后续 HitTest 不会各自推导 partial sector。

## 构造函数

### `ChartPolarQueryIndex(TCYM.UI.Chart.CoordinateSystems.Polar.ChartPolarLayoutCollectionSnapshot,TCYM.UI.Chart.CoordinateSystems.Polar.ChartPolarCoordinateSystemMap)`

从同一 Layout 候选的布局和坐标映射创建索引。

| 参数 | 说明 |
| --- | --- |
| `layout` | 最终 Polar 布局。 |
| `coordinates` | 工厂坐标快照映射。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取索引中的 Polar 数量。 |

## 方法

### `Query(TCYM.UI.Chart.CoordinateSystems.Polar.ChartPolarQueryRequest@,Span{TCYM.UI.Chart.CoordinateSystems.Polar.ChartPolarQueryResult})`

按稳定 Polar 顺序把全部匹配结果写入调用方缓冲区。

| 参数 | 说明 |
| --- | --- |
| `request` | 只读查询条件。 |
| `destination` | 允许为空的结果缓冲区。 |

**返回：** 实际写入数量；容量不足时只写前若干项。

### `TryQuery(TCYM.UI.Chart.CoordinateSystems.Polar.ChartPolarQueryRequest@,TCYM.UI.Chart.CoordinateSystems.Polar.ChartPolarQueryResult@)`

按稳定 Polar 顺序取得第一个满足过滤和扇区范围的结果。

| 参数 | 说明 |
| --- | --- |
| `request` | 只读查询条件。 |
| `result` | 成功时得到像素、数据坐标和 Polar 身份。 |

**返回：** 至少一个 Polar 可以完成查询时为 `true`。
