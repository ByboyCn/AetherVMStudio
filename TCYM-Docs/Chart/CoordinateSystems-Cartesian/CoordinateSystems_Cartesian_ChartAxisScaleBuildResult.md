# ChartAxisScaleBuildResult

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

表示一次有效域解析和比例尺构建的不可变结果。

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataExtent` | 获取过滤无效数据后、应用边界策略前的原始连续域。 |
| `EffectiveExtent` | 获取 nice/align 后的最终刻度有效域；分类轴为空。 |
| `EffectiveInterval` | 获取最终数值间隔；自动日历 time 和 category 返回 null。 |
| `EffectiveStartValue` | 获取具体系列几何使用的有效连续轴起点；显式 min 存在时返回其解析值，<br />否则使用 startValue 或系列请求的轴类型默认值；没有任何来源时为空。 |
| `MaximumIsFixed` | 获取最大端是否由轴边界约束或并域起点锁定。 |
| `MinimumIsFixed` | 获取最小端是否由轴边界约束或并域起点锁定。 |
| `Request` | 获取用于产生该结果的不可变请求。 |
| `Scale` | 获取包含统一有效域和只读主刻度的比例尺。 |
