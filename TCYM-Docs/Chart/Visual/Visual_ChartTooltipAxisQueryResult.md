# ChartTooltipAxisQueryResult

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Visual`　**Chart 版本**：`0.1.1.25`

## 概述

保存一次无分配 nearest 查询结果。结果通过 Count 与索引器暴露预建只读项，不公开内部数组。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取保留的最近匹配项数量。 |
| `Distance` | 获取查询坐标到最近轴投影坐标的绝对距离。 |
| `HasSingleCoordinate` | 获取该系列在同一轴上是否只有一个唯一有效投影坐标。 |
| `IsEquidistantTie` | 获取查询是否曾在两个相邻坐标等距时按较小数据值侧完成决胜。 |
| `Item(Int32)` | 按稳定顺序读取一个匹配项。 |
| `LowerPixelCoordinate` | 获取选中坐标，或发生等距决胜时的较小相邻轴投影坐标。 |
| `MinimumPositiveCoordinateGap` | 获取该系列在同一轴上的最小正投影间距；Angle 的单位为度，其余维度为像素。<br />唯一有效坐标不足两个时为空。 |
| `UpperPixelCoordinate` | 获取选中坐标，或发生等距决胜时的较大相邻轴投影坐标。 |
