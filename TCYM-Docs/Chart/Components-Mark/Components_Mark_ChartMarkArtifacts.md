# ChartMarkArtifacts

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

集中定义公共 Mark 规范化、查询和 model-only 组件制品键。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ImplicitComponents` | 获取全局 model-only 隐式 Mark 组件制品键。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ArtifactName` | 每宿主系列规范化 Mark 制品使用的稳定名称。 |
| `ImplicitComponentsArtifactName` | 全局 model-only 隐式组件快照使用的稳定名称。 |
| `QueryArtifactName` | 每宿主系列公共 Mark query 制品使用的稳定名称。 |

## 方法

### `ForSeries(TCYM.UI.Chart.Model.ChartSeriesOption)`

按 canonical RuntimeUid 创建不受系列重排影响的规范化 Mark 制品键。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前 effective 宿主系列。 |

**返回：** 每系列规范化 Mark 制品键。

### `QueryForSeries(TCYM.UI.Chart.Model.ChartSeriesOption)`

按 canonical RuntimeUid 创建不受系列重排影响的公共 Mark query 制品键。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前 effective 宿主系列。 |

**返回：** 每系列 Mark query 接口制品键。
