# ChartShadowStyle

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Common`　**Chart 版本**：`0.1.1.25`

## 概述

表示矩形组件的不可变投影样式。阴影不参与 box 尺寸计算，只会在绘制阶段扩展像素范围。

## 构造函数

### `ChartShadowStyle(TCYM.UI.Chart.Rendering.ChartBrush,Single,Single,Single)`

创建不可变阴影样式，并对颜色画刷执行快照隔离。

| 参数 | 说明 |
| --- | --- |
| `color` | 阴影颜色画刷；为空表示不绘制阴影。 |
| `blur` | 有限非负模糊半径。 |
| `offsetX` | 有限水平偏移。 |
| `offsetY` | 有限垂直偏移。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 获取阴影模糊半径。 |
| `Color` | 获取已经快照隔离的阴影颜色画刷。 |
| `IsVisible` | 获取当前样式是否可能产生阴影像素。 |
| `None` | 获取不产生阴影像素的共享空样式。 |
| `OffsetX` | 获取阴影水平偏移。 |
| `OffsetY` | 获取阴影垂直偏移。 |
