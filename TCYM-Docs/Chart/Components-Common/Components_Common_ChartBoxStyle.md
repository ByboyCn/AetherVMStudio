# ChartBoxStyle

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Common`　**Chart 版本**：`0.1.1.25`

## 概述

表示组件背景、边框、圆角、内边距与阴影的不可变通用样式。所有画刷在构造时按图表画刷
契约快照，布局和渲染可以安全共享该实例。

## 构造函数

### `ChartBoxStyle(TCYM.UI.Chart.Rendering.ChartBrush,TCYM.UI.Chart.Rendering.ChartBrush,Single,Single,TCYM.UI.Chart.Components.Common.ChartInsets,TCYM.UI.Chart.Components.Common.ChartShadowStyle)`

创建一个不可变通用矩形样式。

| 参数 | 说明 |
| --- | --- |
| `background` | 可选背景画刷。 |
| `borderColor` | 可选边框画刷。 |
| `borderWidth` | 有限非负边框宽度。 |
| `borderRadius` | 有限非负统一圆角半径。 |
| `padding` | 内容与边框内沿之间的四侧内边距。 |
| `shadow` | 可选不可变阴影样式；为空时使用 `None`。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Background` | 获取已经快照隔离的背景画刷。 |
| `BorderColor` | 获取已经快照隔离的边框画刷。 |
| `BorderRadius` | 获取统一圆角半径。 |
| `BorderWidth` | 获取边框宽度。 |
| `Empty` | 获取没有背景、边框、内边距和阴影的共享空样式。 |
| `Padding` | 获取内容内边距。 |
| `Shadow` | 获取不可变阴影样式。 |
