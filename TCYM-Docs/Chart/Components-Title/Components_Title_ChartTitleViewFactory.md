# ChartTitleViewFactory

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Title`　**Chart 版本**：`0.1.1.25`

## 概述

为每个 Title 组件实例创建独立持久 View。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ComponentType` | 获取该工厂支持的组件子类型。 |

## 方法

### `CreateView`

为一个组件实例创建全新的持久视图。

**返回：** Root 非空、未释放、尚未附加到其他场景，且 Root getter 后续保持同一身份的独占视图。
