# ChartSeriesAttachmentView&lt;T1&gt;

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

为强类型宿主系列提供类型检查、稳定 Root 和默认移除/释放行为。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Root` | 获取由此 attachment View 独占的稳定根组。 |

## 方法

### `Dispose`

释放 attachment View 拥有的 Root 及其全部子图元。

### `Remove(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Core.ChartViewUpdate)`

声明移除策略；默认使用 Engine 的统一退出处理。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前 Remove 回调的隔离上下文。 |
| `update` | 触发移除的更新信息。 |

**返回：** 默认退出策略。

### `Update(TCYM.UI.Chart.Core.ChartBuildContext,,Int32,TCYM.UI.Chart.Core.ChartViewUpdate)`

由派生类更新强类型宿主系列的 attachment 内容。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前 View 回调的隔离上下文。 |
| `series` | 已经验证类型的宿主系列。 |
| `seriesIndex` | 系列全局索引。 |
| `update` | 本次更新信息。 |

### `Update(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Model.ChartSeriesOption,Int32,TCYM.UI.Chart.Core.ChartViewUpdate)`

验证宿主系列类型后转发到强类型更新实现。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前 View 回调的隔离上下文。 |
| `series` | 当前宿主系列。 |
| `seriesIndex` | 系列全局索引。 |
| `update` | 本次更新信息。 |
