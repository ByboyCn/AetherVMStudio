# ChartDataZoomViewFactory

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.DataZoom`　**Chart 版本**：`0.1.1.25`

## 概述

为每个 dataZoom 配置实例创建持久组件视图。

## 说明

inside dataZoom 保持空内容；slider dataZoom 从同轮不可变布局创建可见且可交互的控件。
两种 subtype 都遵循组件 View 的创建、复用、事务提交和释放生命周期。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ComponentType` | 获取该工厂支持的组件子类型。 |

## 方法

### `CreateView`

为一个组件实例创建全新的持久视图。

**返回：** Root 非空、未释放、尚未附加到其他场景，且 Root getter 后续保持同一身份的独占视图。
