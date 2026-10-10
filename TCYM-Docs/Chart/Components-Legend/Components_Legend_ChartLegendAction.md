# ChartLegendAction

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Components.Legend`　**Chart 版本**：`0.1.1.25`

## 概述

表示可按 Legend 的显式 Id、显式 Name 或同类索引查询目标组件的强类型 action。
交互控制器还会附带仅程序集内部可见的 RuntimeUid，以避免排队期间组件重排后误命中。

## 属性

| 名称 | 说明 |
| --- | --- |
| `LegendId` | 获取目标 Legend 的显式 Id 查询条件。 |
| `LegendIndex` | 获取目标 Legend 的同类索引查询条件。 |
| `LegendName` | 获取目标 Legend 的显式 Name 查询条件。 |
