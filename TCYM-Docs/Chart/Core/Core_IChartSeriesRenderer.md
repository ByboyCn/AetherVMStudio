# IChartSeriesRenderer

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

表示兼容旧式、一次性系列渲染器的契约。

## 属性

| 名称 | 说明 |
| --- | --- |
| `SeriesType` | 获取该渲染器支持的系列子类型。 |

## 方法

### `Render(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Model.ChartSeriesOption,Int32)`

把一个系列实例渲染到当前回调的渲染目标。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前构建上下文。 |
| `option` | 系列的有效配置快照。 |
| `seriesIndex` | 系列在有效配置中的索引。 |
