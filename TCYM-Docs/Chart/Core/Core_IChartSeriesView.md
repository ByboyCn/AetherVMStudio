# IChartSeriesView

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

一个系列实例对应的持久渲染视图。Engine 在候选创建时只读取并验证一次 Root；
首次 `Update` 成功前 Root 保持脱离，成功后才由 Engine 挂接到场景。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Root` | 获取由视图拥有且在整个 View 生命周期内身份稳定、由 Engine 挂接到场景中的根组。 |

## 方法

### `Remove(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Core.ChartViewUpdate)`

在系列离开有效配置时启动或声明退出过程。

| 参数 | 说明 |
| --- | --- |
| `context` | 仅在本次移除回调期间有效的构建上下文。 |
| `update` | 触发移除的更新信息。 |

**返回：** 退出动画由引擎处理还是由视图自行处理。

### `Update(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Model.ChartSeriesOption,Int32,TCYM.UI.Chart.Core.ChartViewUpdate)`

根据最新有效配置和数据更新持久视图。

| 参数 | 说明 |
| --- | --- |
| `context` | 仅在本次视图回调期间有效的构建上下文。 |
| `option` | 当前系列的有效配置快照。 |
| `seriesIndex` | 系列在有效配置中的索引。 |
| `update` | 本次更新的范围和版本信息。 |
