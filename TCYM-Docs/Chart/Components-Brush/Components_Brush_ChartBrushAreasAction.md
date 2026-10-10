# ChartBrushAreasAction

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Components.Brush`　**Chart 版本**：`0.1.1.25`

## 概述

为携带可选 areas 替换意图的 Brush action 提供深冻结公共负载。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Areas` | 获取 areas 深副本；空值表示保留现有区域，空集合表示清除。 |
| `HasAreas` | 获取 action 是否显式携带 areas；空集合与未携带保持不同。 |
| `Selector` | 获取目标 Brush 组件选择器。 |
