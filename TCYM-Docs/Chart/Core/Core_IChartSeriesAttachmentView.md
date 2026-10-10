# IChartSeriesAttachmentView

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

一个 attachment 工厂与一个宿主系列实例共同拥有的持久 View。
Engine 在首次 `Update` 完整成功前保持 Root 脱离，成功后按 Root 当前
`ZLevel` 挂接到全局图层。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Root` | 获取由此 View 独占且整个生命周期身份稳定的根组。View 应在每次成功更新中设置 Root 的<br />ZLevel、Z、Z2、Visible 与 Silent 最终值。 |

## 方法

### `Remove(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Core.ChartViewUpdate)`

在 attachment 不再适用或宿主系列离开有效配置时声明退出过程。

| 参数 | 说明 |
| --- | --- |
| `context` | 仅在本次 Remove 回调期间有效的隔离构建上下文。 |
| `update` | 触发移除的更新信息。 |

**返回：** 默认退出效果或由 View 自行安排的退出时长。

### `Update(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Model.ChartSeriesOption,Int32,TCYM.UI.Chart.Core.ChartViewUpdate)`

根据当前宿主系列和公共制品更新 attachment 内容。

| 参数 | 说明 |
| --- | --- |
| `context` | 仅在本次 View 回调期间有效的隔离构建上下文。 |
| `series` | 当前宿主系列的有效配置快照。 |
| `seriesIndex` | 系列在有效配置中的全局索引。 |
| `update` | 本次更新范围、版本和重激活状态。 |
