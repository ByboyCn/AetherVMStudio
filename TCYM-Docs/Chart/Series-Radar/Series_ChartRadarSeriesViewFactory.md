# ChartRadarSeriesViewFactory

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

为每个 Radar 系列创建独占、可回滚的持久 View。

## 属性

| 名称 | 说明 |
| --- | --- |
| `SeriesType` | 获取该工厂支持的系列子类型。 |

## 方法

### `CreateView`

为一个系列实例创建全新的持久视图。

**返回：** Root 非空、未释放、尚未附加到其他场景，且 Root getter 后续保持同一身份的独占视图。
