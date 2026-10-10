# ChartAxisScaleBuilder

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

把轴值、端点策略和刻度约束解析为统一不可变比例尺的纯数学构建器。

## 方法

### `Build(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisScaleBuildRequest)`

构建 category、value、time 或 log 有效比例尺。

| 参数 | 说明 |
| --- | --- |
| `request` | 已经完成输入快照和静态参数验证的请求。 |

**返回：** 包含原始域、有效域和有限只读主刻度的不可变结果。
