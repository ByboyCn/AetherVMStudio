# IChartPolarQuery

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

定义基于已发布 Polar 布局执行无分配点查询的只读契约。

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
