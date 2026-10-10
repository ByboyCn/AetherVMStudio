# ChartDataWindowAxisRange

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Extensions`　**Chart 版本**：`0.1.1.25`

## 概述

描述一个已解析连续轴窗口对最终轴域端点的可选覆盖。空端点表示 dataZoom 仍位于完整域对应侧，
布局应继续采用轴自身的 min/max 自动或显式语义。

## 构造函数

### `ChartDataWindowAxisRange(TCYM.UI.Chart.Extensions.ChartDataWindowTarget,Nullable{Double},Nullable{Double},Boolean)`

创建携带单点闭区间语义的连续轴窗口端点投影。

| 参数 | 说明 |
| --- | --- |
| `target` | 目标连续轴。 |
| `minimum` | 窗口裁剪最小端；空值保留原轴最小端语义。 |
| `maximum` | 窗口裁剪最大端；空值保留原轴最大端语义。 |
| `isSinglePoint` | 实际窗口交集是否为单点闭区间；即使完整域一侧继续采用轴自身 dataMin/dataMax，<br />布局也可据此安全扩展相等端点。 |

### `ChartDataWindowAxisRange(TCYM.UI.Chart.Extensions.ChartDataWindowTarget,Nullable{Double},Nullable{Double})`

创建连续轴窗口端点投影。

| 参数 | 说明 |
| --- | --- |
| `target` | 目标连续轴。 |
| `minimum` | 窗口裁剪最小端；空值保留原轴最小端语义。 |
| `maximum` | 窗口裁剪最大端；空值保留原轴最大端语义。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `IsSinglePoint` | 获取一个或多个已解析窗口的实际交集是否为需要保留等值数据的单点闭区间。 |
| `Maximum` | 获取可选的窗口最大端。 |
| `Minimum` | 获取可选的窗口最小端。 |
| `Target` | 获取目标连续轴。 |
