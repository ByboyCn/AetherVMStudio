# ChartBarSampling

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

指定 Bar 降采样使用的 ECharts 6.1 内置算法。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `Average` | 使用采样桶平均值。 |
| `Lttb` | 使用 Largest-Triangle-Three-Buckets 算法。 |
| `Maximum` | 使用采样桶最大值。 |
| `Minimum` | 使用采样桶最小值。 |
| `MinMax` | 同时保留采样桶最小值和最大值。 |
| `None` | 关闭降采样并保留全部处理后数据项。 |
| `Sum` | 使用采样桶总和。 |
