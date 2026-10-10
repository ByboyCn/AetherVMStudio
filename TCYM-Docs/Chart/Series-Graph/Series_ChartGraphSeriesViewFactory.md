# ChartGraphSeriesViewFactory

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

为每个 Graph 系列创建独立的保留式场景 View。

## 构造函数

### `ChartGraphSeriesViewFactory`

创建没有额外场景装饰的原生 Graph 工厂。

### `ChartGraphSeriesViewFactory(Action{TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Model.ChartGraphSeriesOption,TCYM.UI.Chart.Rendering.ChartGroup})`

创建在原生场景成功发布后调用装饰器的 Graph 工厂，保留内部 force/回滚生命周期。

| 参数 | 说明 |
| --- | --- |
| `decorate` | 在 UI 线程为 Root 添加自有图元或安排 owner 帧任务；不可保存构建上下文，不应改写原生节点。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `SeriesType` | 获取该工厂支持的系列子类型。 |

## 方法

### `CreateView`

为一个系列实例创建全新的持久视图。

**返回：** Root 非空、未释放、尚未附加到其他场景，且 Root getter 后续保持同一身份的独占视图。
