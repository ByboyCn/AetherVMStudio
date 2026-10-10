# IChartSeriesMarkerPositionProvider

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

允许 Cartesian 系列为公共 markPoint 布局提供自定义像素定位；未实现该接口或返回失败时，
Mark 管线会使用最终 Cartesian X/Y 比例尺完成标准投影。Polar 有意不调用该旧接口，
以免把 `ChartCartesianSeriesBinding` 伪装成其他坐标类型，并直接执行公共 Polar 投影。

## 方法

### `TryGetMarkerPosition(TCYM.UI.Chart.Components.Mark.ChartSeriesMarkerPositionContext@,SkiaSharp.SKPoint@)`

尝试为一个已经规范化的 Cartesian markPoint 数据项解析未应用 x/y 覆盖的像素中心；
完整 x+y 会在调用该接口前短路，部分覆盖则在返回的基础点上逐维覆盖。

| 参数 | 说明 |
| --- | --- |
| `context` | 宿主系列、最终 Cartesian 绑定和当前 Mark 数据项。 |
| `position` | 成功时返回两个分量均有限的图表本地像素位置。 |

**返回：** 宿主能够处理该位置时返回 `true`；否则由公共投影继续解析。
