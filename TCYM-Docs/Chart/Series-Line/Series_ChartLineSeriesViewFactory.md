# ChartLineSeriesViewFactory

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

为每个生产 Line 系列实例创建独立的持久 View。

## 属性

| 名称 | 说明 |
| --- | --- |
| `SeriesType` | 获取工厂支持的系列类型。 |

## 方法

### `CreateView`

创建尚未附加到引擎场景的 Line 持久 View。

**返回：** 拥有稳定 Root 的全新 Line View。
