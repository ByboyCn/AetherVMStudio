# ChartMarkTooltipOption

> **类型**：class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示系列或 Mark 数据块、单个数据项可复用的原生 CommonTooltip presence-aware 子配置。
它覆盖通用 Tooltip 的显示、触发、定位、延迟、formatter、画刷与文本样式字段，
但不公开 DOM/HTML/CSS 专属选项。类型名保留 Mark 前缀以维持既有公开 API 兼容。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Align` | 获取或设置浮层相对于已解析 X 坐标的水平对齐。 |
| `AlwaysShowContent` | 获取或设置内容是否在离开触发区域后保持显示。 |
| `AsyncFormatter` | 获取或设置带稳定 ticket 与取消令牌的异步 formatter。 |
| `BackgroundColor` | 获取或设置 Tooltip 背景画刷；写入时立即创建隔离快照。 |
| `BorderColor` | 获取或设置显式边框画刷；写入时立即创建隔离快照。 |
| `BorderRadius` | 获取或设置有限非负统一圆角半径。 |
| `BorderWidth` | 获取或设置有限非负边框宽度。 |
| `Confine` | 获取或设置是否把浮层最终位置夹紧到图表视口。 |
| `DisplayTransition` | 获取或设置是否启用显示与隐藏过渡。 |
| `Enterable` | 获取或设置指针是否可以进入原生 Tooltip 场景节点并与其交互。 |
| `Formatter` | 获取或设置 ECharts a/b/c/d/e 模板。 |
| `FormatterCallback` | 获取或设置强类型同步 formatter。 |
| `HideDelay` | 获取或设置隐藏延迟，单位毫秒。 |
| `Order` | 获取或设置多系列结构化内容排序方式。 |
| `Padding` | 获取或设置四侧内边距；显式空值恢复通用 Tooltip 默认值。 |
| `Position` | 获取或设置 point、keyword、box 或 callback 位置表达式。 |
| `RenderMode` | 获取或设置原生渲染模式。TCYM.UI.Chart 不创建 DOM，因而不公开 Html、appendTo、className<br />或 extraCssText。 |
| `Rich` | 获取 Tooltip 原生 rich run 的 presence-aware 样式字典。 |
| `RichInheritPlainStyle` | 获取或设置 rich run 是否继承普通文本的字体、颜色、行高、对齐和透明度。 |
| `Shadow` | 获取或设置不可变阴影；写入时对阴影画刷执行快照隔离。 |
| `Show` | 获取或设置当前嵌套 Tooltip 是否启用。 |
| `ShowContent` | 获取或设置是否绘制 Tooltip 内容浮层。 |
| `ShowDelay` | 获取或设置显示延迟，单位毫秒。 |
| `TextStyle` | 获取或设置 Tooltip 普通文本样式；整块赋值优先于字段补丁。 |
| `TransitionDuration` | 获取或设置移动及显示过渡时间，单位秒。 |
| `Trigger` | 获取或设置 item、axis、none 或布尔兼容触发值。 |
| `TriggerOn` | 获取或设置 mousemove、click、mousewheel 的位组合；`None`<br />表示只接受手动控制。 |
| `ValueFormatter` | 获取或设置默认 Tooltip markup 的值 formatter。 |
| `VerticalAlign` | 获取或设置浮层相对于已解析 Y 坐标的垂直对齐。 |

## 方法

### `Clone`

创建值、委托、画刷、文本样式、rich 字典和 presence 日志均隔离的副本。

**返回：** 内容等价的新 Tooltip option。

### `Reset`

显式清除嵌套 Tooltip 的全部标量、委托、样式、rich 字典与 presence。
