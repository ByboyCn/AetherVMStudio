# ChartSeriesPresentationArtifacts

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Visual`　**Chart 版本**：`0.1.1.25`

## 概述

集中定义每系列 presentation 制品键和 Legend Visual 消费顺序约束。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ArtifactName` | 每个系列 presentation 使用的稳定制品名称。 |
| `LegendConsumerOrder` | Legend Visual 消费器的固定顺序。所有 presentation 生产处理器的<br />`Order` 必须严格小于该值。 |
| `ProducerOrderExclusiveUpperBound` | presentation 生产者允许使用的 Visual Order 排他上界。 |

## 方法

### `ForSeries(TCYM.UI.Chart.Model.ChartSeriesOption)`

为当前系列的规范运行时身份创建稳定 presentation 制品键。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效系列或保留同一身份的快照。 |

**返回：** 不会因系列索引变化而改变的每系列制品键。
