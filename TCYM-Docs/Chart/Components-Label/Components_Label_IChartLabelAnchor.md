# IChartLabelAnchor

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Components.Label`　**Chart 版本**：`0.1.1.25`

## 概述

由 future series 提交的不可变标签几何锚点。

## 说明

锚点只负责几何和边界投影，不执行 formatter、文本测量或重叠处理。所有输入都必须是图表本地坐标。

## 方法

### `TryProjectBoundary(SkiaSharp.SKPoint,SkiaSharp.SKPoint@)`

沿几何中心指向目标点的射线，把标签线起点投影到几何边界。

| 参数 | 说明 |
| --- | --- |
| `targetPoint` | 最终标签折点或标签中心的有限图表坐标。 |
| `point` | 成功时返回边界点。 |

**返回：** 目标点和几何能够形成确定边界交点时为 `true`。

### `TryResolve(TCYM.UI.Chart.Components.Label.ChartLabelPosition,Single,TCYM.UI.Chart.Components.Label.ChartLabelPlacement@)`

按公共位置和距离解析标签原点。

| 参数 | 说明 |
| --- | --- |
| `position` | 公共位置语义。 |
| `distance` | 有限非负像素距离。 |
| `placement` | 成功时返回标签原点和自动对齐。 |

**返回：** 当前锚点支持该位置且几何有效时为 `true`。
