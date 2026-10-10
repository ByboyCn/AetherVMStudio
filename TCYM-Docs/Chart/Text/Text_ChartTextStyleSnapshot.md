# ChartTextStyleSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Text`　**Chart 版本**：`0.1.1.25`

## 概述

表示一次文本布局使用的完整不可变样式快照。快照保留借用的 `SKTypeface`，
并按图表画刷契约隔离所有可变画刷，因此可以安全用作布局缓存键的一部分。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Align` | 获取水平对齐方式。 |
| `BackgroundColor` | 获取已经快照隔离的文本框背景画刷。 |
| `BorderColor` | 获取已经快照隔离的文本框边框画刷。 |
| `BorderRadius` | 获取文本框统一圆角半径。 |
| `BorderWidth` | 获取文本框边框宽度。 |
| `BoxStyle` | 获取由当前字段组成的通用不可变 box 样式。 |
| `Color` | 获取已经快照隔离的文字颜色画刷。 |
| `ColorSource` | 获取颜色来源快照。组件应在通用文本布局前把 auto/inherit 解析为固定画刷；<br />该字段仍保留关键字，避免 rich 样式克隆丢失语义。 |
| `Ellipsis` | 获取截断时使用的省略文本。 |
| `FontSize` | 获取字号（像素）。 |
| `FontWeight` | 获取 CSS/ECharts 风格字重；600 及以上由当前后端以 synthetic embolden 绘制。 |
| `Height` | 获取可选内容高度约束；不包含 padding 与 border。 |
| `LineHeight` | 获取显式行高；非正值表示使用字体自然行高。 |
| `Opacity` | 获取文本和文本框共同使用的透明度。 |
| `Overflow` | 获取宽高溢出处理策略。 |
| `Padding` | 获取文本内容与文本框之间的内边距。 |
| `Shadow` | 获取不可变文本框阴影样式。 |
| `Typeface` | 获取已经解析显式字体或 TCYM.UI 默认字体回退的借用字体族；快照和布局引擎均不会释放该实例。 |
| `VerticalAlign` | 获取垂直对齐方式。 |
| `Width` | 获取可选内容宽度约束；不包含 padding 与 border。 |

## 方法

### `Capture(TCYM.UI.Chart.Rendering.ChartTextStyle)`

从公开可变文本样式捕获不可变快照。

| 参数 | 说明 |
| --- | --- |
| `style` | 待捕获的文本样式。 |

**返回：** 包含全部度量和绘制字段的不可变快照。

### `Equals(Object)`

### `Equals(TCYM.UI.Chart.Text.ChartTextStyleSnapshot)`

逐字段比较两个文本样式快照，包括所有会影响度量、绘制或命中的字段。

| 参数 | 说明 |
| --- | --- |
| `other` | 待比较快照。 |

**返回：** 全部字段相等时为 `true`。

### `GetHashCode`
