# ChartSectorLabelAnchor

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Label`　**Chart 版本**：`0.1.1.25`

## 概述

以圆环扇区描述饼图、极坐标及仪表盘可复用的标签锚点。

## 构造函数

### `ChartSectorLabelAnchor(SkiaSharp.SKPoint,Single,Single,Single,Single)`

创建圆环扇区锚点。

| 参数 | 说明 |
| --- | --- |
| `center` | 有限圆心坐标。 |
| `innerRadius` | 有限非负内半径。 |
| `outerRadius` | 不小于内半径的有限外半径。 |
| `startAngle` | 有限起始角度，单位为度。 |
| `endAngle` | 有限终止角度，单位为度。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Center` | 获取扇区圆心。 |
| `EndAngle` | 获取终止角度（度）。 |
| `InnerRadius` | 获取扇区内半径。 |
| `OuterRadius` | 获取扇区外半径。 |
| `StartAngle` | 获取起始角度（度）。 |

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
