# ChartSeriesMarkerGeometryArtifacts

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

集中定义系列最终 Marker 几何制品键与公共 Mark 布局消费顺序。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ArtifactName` | 按规范系列身份发布最终 Marker 几何的稳定制品名称。 |
| `MarkAreaLayoutOrder` | markArea 在 markLine 之后消费最终几何的阶段内顺序。 |
| `MarkLineLayoutOrder` | markLine 在 markPoint 之后消费最终几何的阶段内顺序。 |
| `MarkPointLayoutOrder` | markPoint 在具体系列 Layout 完成后消费最终几何的阶段内顺序。 |

## 方法

### `ForSeries(TCYM.UI.Chart.Model.ChartSeriesOption)`

为一个规范系列取得不随重排变化的最终 Marker 几何制品键。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效 option 中的系列。 |

**返回：** 按系列运行时身份作用域化的强类型制品键。
