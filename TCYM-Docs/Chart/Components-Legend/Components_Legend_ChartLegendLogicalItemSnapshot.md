# ChartLegendLogicalItemSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Legend`　**Chart 版本**：`0.1.1.25`

## 概述

保存不依赖当前页几何的 Legend 逻辑项，供 action、事件与 selection mask 共用。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Key` | 获取稳定图例项键。 |
| `Name` | 获取显示名及 selection 键。 |
| `Targets` | 获取此项共同控制的不可变目标集合。 |
