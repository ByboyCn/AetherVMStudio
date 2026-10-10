# ChartLabelDescriptor

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Label`　**Chart 版本**：`0.1.1.25`

## 概述

描述 future series 或公共组件提交给中央 pass 的单个标签。提交时会把所有可变样式、字典、
metadata、anchor 和嵌套 option 转换为独立快照。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Align` | 获取或设置覆盖 anchor 自动结果的水平对齐；空值保留自动结果。 |
| `Anchor` | 获取或设置不可变或可快照的纯几何锚点。 |
| `Blur` | 获取或设置 blur 状态的完整公共标签差异补丁。 |
| `BlurTextStyle` | 获取或设置弱化状态文本差异样式。 |
| `ClipToViewport` | 获取或设置是否把完全位于图表视口外的标签隐藏。 |
| `DefaultContent` | 获取或设置 callback/template 缺失、返回空或失败时使用的不可变默认内容。 |
| `Distance` | 获取或设置 anchor 与标签之间的有限非负像素距离。 |
| `Emphasis` | 获取或设置 emphasis 状态的完整公共标签差异补丁。 |
| `EmphasisDisabled` | 获取或设置标签及其引导线是否禁止由指针悬停触发强调状态。 |
| `EmphasisTextStyle` | 获取或设置强调状态文本差异样式。 |
| `Formatter` | 获取或设置最高优先级的同步强类型 formatter。 |
| `FormatterParameters` | 获取或设置强类型 formatter 参数快照。 |
| `Id` | 获取或设置 owner 内非空稳定标识。 |
| `LabelLine` | 获取或设置最终位置确定后生成的引导线配置；赋空会恢复默认值。 |
| `Layout` | 获取或设置受控 labelLayout 和重叠配置；赋空会恢复默认值。 |
| `Metadata` | 获取或设置标签文本和引导线共用的事件元数据。 |
| `Offset` | 获取或设置 anchor 解析后应用的有限二维偏移。 |
| `Position` | 获取或设置公共位置语义。 |
| `PrecomputedLayout` | 获取或设置上游布局已产生的不可变结果。非空时中央 pass 不再执行 formatter 或测量，<br />供 axis outerBounds 与最终渲染复用同一对象。 |
| `Priority` | 获取或设置 hideOverlap 保留优先级；数值较大者先保留。 |
| `Rich` | 获取可变 rich 样式字典；descriptor 提交时会逐项深度复制。 |
| `RichInheritPlainStyle` | 获取或设置 ECharts 6 rich 字体字段是否继承普通文本样式。 |
| `Rotation` | 获取或设置标签顺时针旋转角度。 |
| `Select` | 获取或设置 select 状态的完整公共标签差异补丁。 |
| `SelectTextStyle` | 获取或设置选中状态文本差异样式。 |
| `Show` | 获取或设置 normal 状态是否显示标签；状态补丁可独立覆盖该值。 |
| `Silent` | 获取或设置标签是否忽略命中测试。 |
| `Template` | 获取或设置已经编译、可复用的字符串模板。 |
| `TextStyle` | 获取或设置普通状态文本样式；赋空会恢复新的默认样式。 |
| `VerticalAlign` | 获取或设置覆盖 anchor 自动结果的垂直对齐；空值保留自动结果。 |
| `Z` | 获取或设置同一全局层级内的主顺序。 |
| `Z2` | 获取或设置同一 Z 内的次级顺序。 |
| `ZLevel` | 获取或设置全局层级。 |
