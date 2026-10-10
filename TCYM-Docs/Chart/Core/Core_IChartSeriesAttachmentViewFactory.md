# IChartSeriesAttachmentViewFactory

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

为一个宿主系列按需创建独立持久 attachment View 的无状态工厂。
attachment 与主 SeriesView 分别拥有 Root、标签批次和运行时 owner，适合公共 mark、辅助装饰层等
不应侵入具体系列 View 的跨系列能力。

## 说明

同一个工厂实例保存在共享 Registry 中，可能被多个 Engine 从不同线程调用；实现不得保存
Engine-local 可变状态。Engine 会在主 SeriesView 完成协调后，按 `Order`、
`AttachmentKey` 和系列顺序稳定调用该工厂。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AttachmentKey` | 获取在整个 Registry 中唯一、不会随系列类型或索引变化的 attachment 键。 |
| `Order` | 获取多个 attachment 在同一宿主系列上的稳定协调顺序。 |

## 方法

### `CreateView`

创建尚未附加到 Engine 场景的全新持久 attachment View。

**返回：** Root 非空、未释放、尚未附加到其他场景，且 Root getter 后续保持同一身份的独占 View。

### `ShouldAttach(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Model.ChartSeriesOption,Int32)`

判断当前宿主系列在本轮是否应拥有该 attachment。

| 参数 | 说明 |
| --- | --- |
| `context` | 与当前已发布候选一致的隔离只读上下文；本回调中没有 View 运行时 invocation，不能提交<br />Label、命令、动画或逐帧任务。 |
| `series` | 上下文内当前有效系列的隔离快照。 |
| `seriesIndex` | 系列在当前有效选项中的全局索引。 |

**返回：** 返回 `true` 时创建或更新 attachment；返回 `false` 时同帧调用
已有 attachment 的 Remove 并进入退休流程。数据块被清空时应返回 `false`。
