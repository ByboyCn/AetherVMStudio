# ChartLineStyleOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 line、graph edge 与其他路径系列可复用的描边样式补丁；每个字段独立记录 presence。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Cap` | 获取或设置开放路径端点的线帽样式。 |
| `Color` | 获取或设置描边画刷；显式赋空恢复系列视觉颜色。 |
| `DashOffset` | 获取或设置虚线图案沿路径方向的有限偏移。 |
| `Join` | 获取或设置线段连接样式。 |
| `MiterLimit` | 获取或设置大于零的有限斜接限制。 |
| `Opacity` | 获取或设置 0～1 的整体不透明度。 |
| `ShadowBlur` | 获取或设置非负有限阴影模糊半径。 |
| `ShadowColor` | 获取或设置阴影画刷。 |
| `ShadowOffsetX` | 获取或设置有限水平阴影偏移。 |
| `ShadowOffsetY` | 获取或设置有限垂直阴影偏移。 |
| `Type` | 获取或设置预定义关键字、非负有限数值或非空数值数组形式的描边线型。<br />自定义数组在赋值时会被深度捕获。 |
| `Width` | 获取或设置非负像素宽度或 emphasis 相对加粗值；`bolder` 出现在非 emphasis<br />位置时由 Line validator 报告作用域错误。 |

## 方法

### `Clone`

创建画刷、字段值与 presence 日志均隔离的副本。

**返回：** 内容等价的新描边样式。

### `Reset`

显式清除整块描边样式，使每个字段恢复系列默认或继承值。
