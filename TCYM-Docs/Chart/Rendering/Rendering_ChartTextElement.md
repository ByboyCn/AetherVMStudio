# ChartTextElement

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

场景树文本节点。formatter 产出的普通或 rich 内容、测量、绘制和命中共同消费
`ChartTextLayoutResult`，并保留旧 `Text` 字符串入口。

## 属性

| 名称 | 说明 |
| --- | --- |
| `BlurTextStyle` | 获取或设置弱化状态的文本差异样式。 |
| `Content` | 获取或设置 formatter 产出的不可变普通或 rich 文本内容。 |
| `EmphasisTextStyle` | 获取或设置强调状态的文本差异样式。 |
| `LayoutEngine` | 获取或设置负责即时布局的文本引擎。 |
| `PrecomputedLayout` | 获取或设置由中央 label pass 预先创建的布局结果。非空时元素不再自行解释当前内容和样式，<br />可保证 labelLayout、最终绘制与命中严格共享同一快照。 |
| `Rich` | 获取 `RichStyles` 的 ECharts 风格别名。 |
| `RichInheritPlainStyle` | 获取或设置 rich 字体相关字段是否继承普通样式；默认与 ECharts 6 一致。 |
| `RichStyles` | 获取可变 rich 样式字典。布局前会对全部条目生成不可变快照，因此原位修改字典或样式<br />不会使已有缓存错误复用。 |
| `SelectTextStyle` | 获取或设置选中状态的文本差异样式。 |
| `Text` | 获取或设置普通文本内容；设置后会清除先前的 rich runs。 |
| `TextStyle` | 获取或设置普通状态的基础文本样式。 |

## 方法

### `MeasureBounds`

测量当前交互状态下文本在元素局部坐标中的逻辑包围盒。

**返回：** 与实际绘制及命中使用同一布局结果的边界。

### `MeasureLayout`

获取当前状态下供绘制、测量和命中共同使用的布局结果。

**返回：** 预布局结果或按当前内容和样式创建并缓存的即时结果。
