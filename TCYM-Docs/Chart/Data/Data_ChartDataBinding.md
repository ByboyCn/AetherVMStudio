# ChartDataBinding

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

描述一个系列解析后的数据源绑定。

## 属性

| 名称 | 说明 |
| --- | --- |
| `DatasetId` | 获取请求或解析到的 dataset ID。 |
| `DatasetIndex` | 获取解析后的 dataset 索引；非 dataset 绑定或按 ID 未解析时可为空。 |
| `IsDatasetBound` | 获取当前绑定是否来自 dataset。 |
| `IsResolved` | 获取引用的 dataset 或 inline source 是否成功解析。 |
| `Kind` | 获取绑定来源类型。 |
| `SeriesLayoutBy` | 获取运行时系列布局契约。布局属于系列绑定而非共享 raw dataset，因此不同系列可用不同方向<br />解释同一个物理来源，而不会把系列语义写回 dataset。 |
