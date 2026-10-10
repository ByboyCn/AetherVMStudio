# ChartDataSourceTraits

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

描述普通拓扑和维度无法表达的数据源解释语义；未实现
`IChartDataSourceTraitsProvider` 的来源等价于 `None`。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `ImplicitRawIndexFallback` | 一维 inline 数据在没有 category 轴时仍使用 `rawIndex/value` 默认坐标；<br />多维数据、dataset 与显式 encode 不消费此标记。 |
| `None` | 不声明额外的数据源解释语义。 |
