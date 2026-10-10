# ChartCartesianPipelineOrders

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

冻结 Cartesian 公共处理器的阶段内顺序，确保具体系列只消费最终布局与轴绑定，
不再从 option 私自推导 grid、轴身份或有效轴类型。

## 字段

| 名称 | 说明 |
| --- | --- |
| `Layout` | 标准 Cartesian grid、轴、查询索引与坐标系完成发布的 Layout order。 |
| `SeriesBinding` | 把最终布局解析为按系列作用域化绑定的 Layout order。 |
| `SeriesLayoutLowerBound` | 需要读取系列 Cartesian 绑定的具体系列可使用的最小 Layout order。 |
