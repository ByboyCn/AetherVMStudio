# ChartItemStyleOption

> **类型**：class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示图元填充、描边、阴影与透明度配置，采用 presence-aware 合并。

## 属性

| 名称 | 说明 |
| --- | --- |
| `BorderColor` | 获取或设置边框画刷。 |
| `BorderJoin` | 获取或设置边框线段连接样式；空值表示显式清除继承值。 |
| `BorderRadius` | 获取或设置左上、右上、右下、左下顺序的强类型四角半径；空值表示显式清除继承值。 |
| `BorderType` | 获取或设置边框线型关键字，例如 `solid` 或 `dashed`。 |
| `BorderWidth` | 获取或设置边框宽度。 |
| `Color` | 获取或设置填充画刷。 |
| `ColorCallback` | 获取或设置 Cartesian Bar、Pie、普通 Cartesian Scatter 或 Candlestick 系列 normal<br />作用域的逐项填充画刷回调；Candlestick 把结果应用到当前 positive/negative/doji 的活动<br />fill，随后仍允许逐项静态样式和 VisualMap 覆盖。Pie 只对当前 Legend-selected effective<br />项执行，隐藏项保留静态/调色板视觉供恢复。回调返回空值时保留静态填充或调色板值。<br />其他宿主或交互状态作用域当前不执行该回调。 |
| `ColorSource` | 获取或设置强类型填充颜色来源。与 `Color` 共享同一 presence，<br />因而两者同时赋值时最后一次 setter 生效；空值表示显式清除。 |
| `Opacity` | 获取或设置 0 到 1 的整体不透明度。 |
| `ShadowBlur` | 获取或设置非负有限的阴影模糊半径。 |
| `ShadowColor` | 获取或设置阴影画刷；赋值时会按画刷快照契约隔离。 |
| `ShadowOffsetX` | 获取或设置有限的水平阴影偏移。 |
| `ShadowOffsetY` | 获取或设置有限的垂直阴影偏移。 |

## 方法

### `Clone`

创建画刷、值与 presence 日志均独立的副本。

**返回：** 内容等价的新图元样式。

### `Reset`

在下一次合并时显式清除整个嵌套图元样式块。公开入口不可重写，避免外部派生类型改变
option backing 的重置语义。
