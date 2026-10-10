# ChartLineSampling

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

指定大数据折线使用的降采样算法。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `Average` | 使用采样桶平均值。 |
| `Lttb` | 使用 Largest-Triangle-Three-Buckets 算法。 |
| `Maximum` | 使用采样桶最大值。 |
| `Minimum` | 使用采样桶最小值。 |
| `MinMax` | 同时保留采样桶最小值和最大值。 |
| `None` | 不进行降采样。 |
| `Sum` | 使用采样桶总和。 |
