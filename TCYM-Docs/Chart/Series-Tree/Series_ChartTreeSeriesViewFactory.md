# ChartTreeSeriesViewFactory

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

为每个 Tree 系列创建独立的保留式场景 View。

## 构造函数

### `ChartTreeSeriesViewFactory`

创建没有额外场景装饰的原生 Tree 工厂。

### `ChartTreeSeriesViewFactory(Action{TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Model.ChartTreeSeriesOption,TCYM.UI.Chart.Rendering.ChartGroup})`

创建在原生场景成功发布后调用 UI 线程装饰器的 Tree 工厂。

| 参数 | 说明 |
| --- | --- |
| `decorate` | 向 Root 添加自有图元；不得保存构建上下文或改写原生节点。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `SeriesType` | 获取该工厂支持的系列子类型。 |

## 方法

### `CreateView`

为一个系列实例创建全新的持久视图。

**返回：** Root 非空、未释放、尚未附加到其他场景，且 Root getter 后续保持同一身份的独占视图。
