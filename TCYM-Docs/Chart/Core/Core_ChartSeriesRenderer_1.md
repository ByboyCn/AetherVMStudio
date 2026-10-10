# ChartSeriesRenderer&lt;T1&gt;

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

为旧式系列渲染器提供强类型配置检查的基类。

## 属性

| 名称 | 说明 |
| --- | --- |
| `SeriesType` | 获取渲染器支持的系列子类型。 |

## 方法

### `Render(TCYM.UI.Chart.Core.ChartBuildContext,,Int32)`

由派生类渲染强类型系列配置。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前构建上下文。 |
| `option` | 已验证类型的系列配置。 |
| `seriesIndex` | 系列在有效配置中的索引。 |

### `Render(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Model.ChartSeriesOption,Int32)`

验证配置类型后调用强类型渲染方法。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前构建上下文。 |
| `option` | 系列配置。 |
| `seriesIndex` | 系列在有效配置中的索引。 |
