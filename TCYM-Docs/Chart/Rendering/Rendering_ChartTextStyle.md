# ChartTextStyle

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

文本节点和 rich run 的 presence-aware 可变样式。差异状态只需设置要覆盖的字段；
`Clone` 与 `MergeOnto` 始终创建独立副本。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Align` | 获取或设置相对于元素原点的水平对齐方式。 |
| `BackgroundColor` | 获取或设置文本框背景画刷；设置值会按画刷快照契约隔离。 |
| `BorderColor` | 获取或设置文本框边框画刷；设置值会按画刷快照契约隔离。 |
| `BorderRadius` | 获取或设置文本框统一圆角半径（像素）。 |
| `BorderWidth` | 获取或设置文本框边框宽度（像素）。 |
| `Color` | 获取或设置文本画刷；设置值会按画刷快照契约隔离。 |
| `ColorSource` | 获取或设置强类型文字颜色来源。与 `Color` 共享 presence，最后一次赋值生效；<br />通用文本布局只消费固定画刷，auto/inherit 应由组件在创建布局请求前解析。 |
| `Ellipsis` | 获取或设置 truncate 和高度裁剪使用的省略文本；空值会规范为空字符串。 |
| `FontSize` | 获取或设置字号（像素）；非正或非有限值不会由文本元素布局。 |
| `FontWeight` | 获取或设置 CSS/ECharts 风格字重。值域为 1 至 1000；当前 Skia 后端把 600 及以上映射为<br />synthetic embolden，从而不创建也不泄漏额外的 `SKTypeface`。 |
| `Height` | 获取或设置可选内容高度；不包含 padding 和 border，空值表示自然高度。 |
| `LineHeight` | 获取或设置多行基线间距；零值使用字体自然高度。 |
| `Opacity` | 获取或设置文字和文本框透明度；会与元素和场景继承透明度相乘。 |
| `Overflow` | 获取或设置宽高溢出处理策略。 |
| `Padding` | 获取或设置文本内容与背景框之间的四侧内边距。 |
| `Shadow` | 获取或设置不可变文本框阴影样式。 |
| `Typeface` | 获取或设置字体。字体按借用资源处理，样式、快照、布局和元素均不会释放该实例；调用方须保证<br />它在文本元素使用期间保持有效。 |
| `VerticalAlign` | 获取或设置相对于元素原点的垂直对齐方式。 |
| `Width` | 获取或设置可选内容宽度；不包含 padding 和 border，空值表示自然宽度。 |

## 方法

### `Clone`

创建保留显式字段语义的独立样式副本。

### `MergeOnto(TCYM.UI.Chart.Rendering.ChartTextStyle)`

把当前样式中显式赋值的字段覆盖到基础文本样式之上。

| 参数 | 说明 |
| --- | --- |
| `basis` | 提供未显式字段的基础样式。 |

**返回：** 合并后的完整新样式。
