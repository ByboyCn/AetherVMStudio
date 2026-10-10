# ChartSeriesView&lt;T1&gt;

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

为强类型系列配置提供类型检查和根节点所有权的持久视图基类。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Root` | 获取由此视图拥有的持久根组。 |

## 方法

### `Dispose`

释放视图拥有的根组及其子图元。

### `Remove(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Core.ChartViewUpdate)`

声明移除策略；默认使用引擎提供的退出处理。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前构建上下文。 |
| `update` | 触发移除的更新信息。 |

**返回：** 视图移除策略。

### `Update(TCYM.UI.Chart.Core.ChartBuildContext,,Int32,TCYM.UI.Chart.Core.ChartViewUpdate)`

由派生类更新强类型系列视图。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前构建上下文。 |
| `option` | 已验证类型的系列配置。 |
| `seriesIndex` | 系列在有效配置中的索引。 |
| `update` | 本次更新信息。 |

### `Update(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Model.ChartSeriesOption,Int32,TCYM.UI.Chart.Core.ChartViewUpdate)`

验证配置类型后转发到强类型更新方法。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前构建上下文。 |
| `option` | 系列配置。 |
| `seriesIndex` | 系列在有效配置中的索引。 |
| `update` | 本次更新信息。 |
