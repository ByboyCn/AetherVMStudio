# ChartMarkDimensionStatisticSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个坐标维统计请求的规范化计算元数据。

## 构造函数

### `ChartMarkDimensionStatisticSnapshot(TCYM.UI.Chart.Model.ChartMarkStatisticType,Double,Int32,Boolean)`

创建一个已经成功计算的逐维统计快照。

| 参数 | 说明 |
| --- | --- |
| `statistic` | min、max、average 或 median。 |
| `exactValue` | 尚未执行 Point 最近真实数据项吸附的精确统计值。 |
| `validSampleCount` | 实际参与统计的有效样本数。 |
| `usesStackResult` | 是否读取公共 stack 的 ResultValue。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `ExactValue` | 获取精确统计值；Point 的 resolved dimension 可以吸附到最近真实数据值，<br />但该字段始终保留吸附前的 average/median/min/max 结果。 |
| `Statistic` | 获取统计类型。 |
| `UsesStackResult` | 获取本维统计是否读取公共 stack 累计结果。 |
| `ValidSampleCount` | 获取实际参与统计的有效样本数。 |
