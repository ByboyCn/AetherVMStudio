# ChartDataWindowArtifacts

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Extensions`　**Chart 版本**：`0.1.1.25`

## 概述

公开 dataZoom 请求与实际解析窗口的全局强类型制品键。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Requested` | 获取早期 Data processor 发布的请求窗口。<br />此快照只描述意图，不表示数据已经被筛选。 |
| `Resolved` | 获取中期 Data processor 发布的实际解析窗口。<br />数据变换只能依据此键决定是否筛选，不应把请求快照误认为已应用结果。 |
| `ResolvedAxisRanges` | 获取 dataZoom 对连续坐标轴实际端点的解析投影；没有窗口或窗口保持 0～100 时为空快照。 |
