# ChartTreeSeriesOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

具有稳定节点身份、折叠状态及独立像素布局的 Tree 系列。

## 构造函数

### `ChartTreeSeriesOption`

创建空 Tree presence 补丁并安装精确状态类型。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AnimationThreshold` | 动画允许的最大可见节点并集数量，默认 2000；超过上限立即应用最终布局，0 关闭 Tree 动画。 |
| `Blur` | Tree 淡化状态及连接线样式。 |
| `Bottom` | 布局底部约束，默认 12%。 |
| `DefaultCoordinateSystemType` | 获取当前具体系列在 `CoordinateSystem` 未指定时采用的坐标系类型；<br />默认返回空，具体 line、bar、scatter 等系列应覆盖为自身真实默认值。 |
| `EdgeForkPosition` | 正交折线沿深度轴的分叉位置，默认 50%；支持非负像素或 0～100% 的比例。 |
| `EdgeShape` | 连接线形状，默认 Curve。 |
| `Emphasis` | Tree 强调状态、聚焦范围及连接线样式。 |
| `ExpandAndCollapse` | 允许节点点击折叠/展开，默认 true；false 也禁用初始深度折叠。 |
| `Height` | 布局高度，支持有限非负像素、百分比或 auto。 |
| `InitialTreeDepth` | 初始展开的最大深度；根为 0，默认 2，-1 表示全部展开。 |
| `Layout` | 布局，默认 Orthogonal；null 恢复默认。 |
| `Leaves` | 叶子节点及折叠分支的样式补丁；空块恢复默认。 |
| `Left` | 布局左侧约束，默认 12%。 |
| `LegendHoverLink` | 图例悬停联动开关，默认 true。 |
| `LineStyle` | 父子连接线样式；空块恢复默认。 |
| `Orient` | 正交布局方向，默认 LR。 |
| `Right` | 布局右侧约束，默认 12%。 |
| `Roam` | 允许平移、Ctrl+滚轮及双指缩放，默认 false；普通滚轮保留给页面滚动。 |
| `Select` | Tree 选择状态及连接线样式。 |
| `SeriesType` | 获取系列注册表使用的类型名，例如 `line` 或 `bar`。 |
| `Symbol` | 默认节点符号，默认 emptyCircle。 |
| `SymbolRotate` | 默认符号旋转角度。 |
| `SymbolSize` | 默认节点逻辑像素尺寸，默认 7。 |
| `Tooltip` | 系列 item Tooltip；不支持 axis Tooltip。 |
| `Top` | 布局顶部约束，默认 12%。 |
| `Width` | 布局宽度，支持有限非负像素、百分比或 auto。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
