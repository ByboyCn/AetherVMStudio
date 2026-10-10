# ChartStackStrategy

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

指定同一 stack 分组中的正负值如何选择堆叠基线。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `All` | 不区分符号，把全部数值堆叠在一起。 |
| `Negative` | 只堆叠负数。 |
| `Positive` | 只堆叠正数。 |
| `SameSign` | 只把同符号数值堆叠在一起，对应 ECharts 的 `samesign`。 |
