# ChartPolarArtifacts

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

集中定义 Polar 布局、查询、坐标映射和每系列绑定的稳定制品键。

## 属性

| 名称 | 说明 |
| --- | --- |
| `CoordinateSystemMap` | 获取 Polar 组件到独立坐标快照的映射。 |
| `Layout` | 获取当前 Layout 候选的 Polar 布局集合。 |
| `Query` | 获取当前 Layout 候选的 Polar 查询索引。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `CoordinateSystemMapArtifactName` | 获取 Polar 坐标映射制品名称。 |
| `LayoutArtifactName` | 获取 Polar 布局集合制品名称。 |
| `QueryArtifactName` | 获取 Polar 点查询制品名称。 |
| `SeriesBindingArtifactName` | 获取 Polar 系列绑定制品名称。 |

## 方法

### `BindingFor(TCYM.UI.Chart.Model.ChartSeriesOption)`

按系列规范身份创建最终 Polar 绑定键。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前 effective 系列。 |

**返回：** 稳定的每系列制品键。
