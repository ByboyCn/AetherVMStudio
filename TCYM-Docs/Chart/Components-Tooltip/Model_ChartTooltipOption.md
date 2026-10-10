# ChartTooltipOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 6.1 Tooltip 顶层配置。空实例不提交任何自有 presence；每个 setter（包括显式
`null`）都只覆盖对应字段。DOM/HTML/CSS 专属字段不进入该原生公开契约。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Align` | 获取或设置浮层相对于已解析 X 坐标的水平对齐。 |
| `AlwaysShowContent` | 获取或设置内容是否在离开触发区域后保持显示。 |
| `AsyncFormatter` | 获取或设置带稳定 ticket 与取消令牌的异步 formatter。 |
| `AxisPointer` | 获取或设置 Tooltip axisPointer 便捷配置。 |
| `BackgroundColor` | 获取或设置 Tooltip 背景画刷。 |
| `BorderColor` | 获取或设置显式边框画刷；空值允许 item 使用数据色、axis 使用默认边框色。 |
| `BorderRadius` | 获取或设置有限非负统一圆角半径。 |
| `BorderWidth` | 获取或设置有限非负边框宽度。 |
| `ComponentType` | 获取组件注册与合并所使用的类型名。 |
| `Confine` | 获取或设置是否把浮层最终位置夹紧到图表视口。 |
| `DisplayTransition` | 获取或设置是否启用显示与隐藏淡入淡出。 |
| `Enterable` | 获取或设置指针是否可以进入原生 Tooltip 场景节点并与其交互。 |
| `Formatter` | 获取或设置 ECharts a/b/c/d/e 字符串模板。 |
| `FormatterCallback` | 获取或设置同步强类型 formatter。存在时优先于 `Formatter`；若同时配置<br />`AsyncFormatter`，同步结果作为异步完成前的占位内容。 |
| `HideDelay` | 获取或设置隐藏延迟，单位毫秒。 |
| `Order` | 获取或设置多系列结构化内容排序方式。 |
| `Padding` | 获取或设置四侧内边距；显式空值恢复 renderMode 默认，原生模式为 [8,10,8,10]。 |
| `Position` | 获取或设置 point、keyword、box 或 callback 位置表达式。 |
| `RenderMode` | 获取或设置原生渲染模式。TCYM.UI.Chart 不创建 DOM，因而没有 Html、appendTo、className 或<br />extraCssText 的伪兼容值。 |
| `Rich` | 获取 Tooltip 原生 rich run 的 presence-aware 样式字典。 |
| `RichInheritPlainStyle` | 获取或设置 rich run 是否继承普通文本的字体、颜色、行高、对齐和透明度。 |
| `Shadow` | 获取或设置不可变阴影；显式空值恢复 ECharts 6.1 默认阴影。 |
| `ShowContent` | 获取或设置是否绘制 Tooltip 浮层；为 false 时 axisPointer 仍可工作。 |
| `ShowDelay` | 获取或设置显示延迟，单位毫秒。 |
| `TextStyle` | 获取或设置 Tooltip 普通文本样式；整块赋值优先于字段补丁。 |
| `TransitionDuration` | 获取或设置移动及显示过渡时间，单位秒。 |
| `Trigger` | 获取或设置 item、axis 或 none 坐标系触发类型。 |
| `TriggerOn` | 获取或设置 mousemove、click、mousewheel 的位组合；`None`<br />表示只接受手动控制。 |
| `ValueFormatter` | 获取或设置默认 markup 的值 formatter；配置任一完整 formatter 时该回调按 ECharts 语义忽略。 |
| `VerticalAlign` | 获取或设置浮层相对于已解析 Y 坐标的垂直对齐。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。

### `Reset`

保留 Id/Name 供 canonical 匹配，并把显示、层级、box 与全部 Tooltip 自有字段显式恢复默认。
