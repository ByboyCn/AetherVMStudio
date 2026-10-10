# ChartLegendOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 6.1 风格 Legend 配置。构造函数不写入任何默认 presence；默认值由后续
Normalize/Visual 阶段解析，保证局部 `SetOption` 不覆盖既有字段。

## 构造函数

### `ChartLegendOption`

创建一个尚未提交任何 Legend presence 字段的空补丁。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Align` | 获取或设置图标与文字的相对对齐。 |
| `AnimationDurationUpdate` | 获取或设置 scroll 页切换更新动画时长（毫秒）。 |
| `BackgroundColor` | 获取或设置 Legend 背景画刷。 |
| `BorderColor` | 获取或设置 Legend 外框边框画刷。 |
| `BorderRadius` | 获取或设置 Legend 外框有限非负统一圆角。 |
| `BorderWidth` | 获取或设置 Legend 外框有限非负边框宽度。 |
| `ComponentType` | 获取组件注册与合并所使用的类型名。 |
| `Data` | 获取显式 Legend data；任一写操作表示整组替换。 |
| `EmphasisSelectorLabel` | 获取或设置 selector emphasis 状态文字样式。 |
| `EmphasisSelectorLabelRich` | 获取 selector emphasis 状态 rich 样式补丁字典。 |
| `Formatter` | 获取或设置 ECharts `{name}` 模板字符串。 |
| `FormatterCallback` | 获取或设置同步强类型 Legend formatter；异常由后续公共文本边界回退。 |
| `Icon` | 获取或设置顶层内置 symbol、`path://` 或继承图标声明。 |
| `InactiveBorderColor` | 获取或设置未选中图标边框画刷。 |
| `InactiveBorderWidth` | 获取或设置未选中图标有限非负边框宽度；空值表示 auto。 |
| `InactiveColor` | 获取或设置未选中文字与图标画刷。 |
| `ItemGap` | 获取或设置相邻 Legend 项的有限非负间距。 |
| `ItemHeight` | 获取或设置图标有限非负高度。 |
| `ItemStyle` | 获取或设置顶层图标样式；显式整块赋值优先于字段补丁。 |
| `ItemWidth` | 获取或设置图标有限非负宽度。 |
| `LineStyle` | 获取或设置顶层线条图标样式；显式整块赋值优先于字段补丁。 |
| `Orient` | 获取或设置项目排列方向。 |
| `Padding` | 获取或设置 Legend 背景框内边距。 |
| `PageButtonGap` | 获取或设置分页控制组与 Legend 项之间的有限非负间距；空值回退 itemGap。 |
| `PageButtonItemGap` | 获取或设置翻页按钮与页信息文字之间的有限非负间距。 |
| `PageButtonPosition` | 获取或设置分页控制组位置；仅允许 start/end。 |
| `PageFormatter` | 获取或设置 `{current}/{total}` 风格页信息模板。 |
| `PageFormatterCallback` | 获取或设置同步强类型页信息 formatter。 |
| `PageIconColor` | 获取或设置可用翻页按钮画刷。 |
| `PageIconInactiveColor` | 获取或设置不可用翻页按钮画刷。 |
| `PageIcons` | 获取或设置滚动翻页图标；显式整块赋值优先于字段补丁。 |
| `PageIconSize` | 获取或设置翻页图标有限非负宽高。 |
| `PageRichInheritPlainStyle` | 获取或设置页信息 rich run 是否继承普通文字字段。 |
| `PageTextRich` | 获取页信息 rich 样式补丁字典。 |
| `PageTextStyle` | 获取或设置页信息文字样式；显式整块赋值优先于字段补丁。 |
| `RichInheritPlainStyle` | 获取或设置 Legend 项 rich run 是否继承普通文字字段。 |
| `ScrollDataIndex` | 获取或设置 scroll Legend 左上首个可见 data 索引；显式赋值推进 scroll option 代次。 |
| `Selected` | 获取初始选择状态补丁。未出现的名称默认选中；任一 set/add/clear/remove 都推进 selection option 代次。 |
| `SelectedMode` | 获取或设置用户交互选择模式；显式赋值会推进 selection option 代次。 |
| `Selector` | 获取 selector 按钮列表；空列表表示默认不显示，任一写操作表示整组替换。 |
| `SelectorButtonGap` | 获取或设置 selector 组与 Legend 主内容之间的有限非负间距。 |
| `SelectorItemGap` | 获取或设置 selector 按钮之间的有限非负间距。 |
| `SelectorLabel` | 获取或设置 selector 普通状态文字样式。 |
| `SelectorLabelRich` | 获取 selector 普通状态 rich 样式补丁字典。 |
| `SelectorPosition` | 获取或设置 selector 控制组位置。 |
| `SelectorRichInheritPlainStyle` | 获取或设置 selector rich run 是否继承普通文字字段。 |
| `Shadow` | 获取或设置 Legend 外框不可变阴影。 |
| `SymbolKeepAspect` | 获取或设置 path 图标是否保持原始宽高比。 |
| `SymbolRotate` | 获取或设置图标顺时针旋转角度。 |
| `TextRich` | 获取 Legend 项文字 rich 样式补丁字典。 |
| `TextStyle` | 获取或设置 Legend 项文字样式；显式整块赋值优先于字段补丁。 |
| `TooltipShow` | 获取或设置是否发布供 M1.6 Tooltip 消费的 Legend tooltip metadata。 |
| `TriggerEvent` | 获取或设置是否为 Legend 图元发布组件事件 metadata。 |
| `Type` | 获取或设置 Legend 类型。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。

### `Reset`

保留 Id/Name 以继续匹配旧节点，并把基类显示、层级、静默、box 及全部 Legend 字段显式恢复默认。
