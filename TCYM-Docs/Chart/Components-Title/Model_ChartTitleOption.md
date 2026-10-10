# ChartTitleOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 风格 title 组件配置。构造函数不写入任何默认 presence；默认值只在有效配置
Normalize/Layout 阶段解析，保证局部 `SetOption` 补丁不会覆盖既有字段。

## 属性

| 名称 | 说明 |
| --- | --- |
| `BackgroundColor` | 获取或设置共享标题外框背景画刷；赋值时按图表画刷契约快照。 |
| `BorderColor` | 获取或设置共享标题外框边框画刷；赋值时按图表画刷契约快照。 |
| `BorderRadius` | 获取或设置共享标题外框有限非负统一圆角半径。 |
| `BorderWidth` | 获取或设置共享标题外框有限非负边框宽度。 |
| `ComponentType` | 获取组件注册与合并所使用的类型名。 |
| `ItemGap` | 获取或设置主标题实测高度与副标题之间的有限像素间距；允许负值形成显式重叠。 |
| `Link` | 获取或设置主标题链接；图表只产生导航请求，不会自行打开外部地址。 |
| `Padding` | 获取或设置共享标题外框的四侧内边距；空值恢复 5px 默认值。 |
| `Shadow` | 获取或设置共享标题外框不可变阴影；空值恢复无阴影。 |
| `SubLink` | 获取或设置副标题链接；图表只产生导航请求，不会自行打开外部地址。 |
| `SubTarget` | 获取或设置副标题链接目标；空值恢复 `Blank`。 |
| `Subtext` | 获取或设置副标题字面文本；空值或空字符串不会创建副标题图元。 |
| `SubtextFormatter` | 获取或设置副标题同步强类型 formatter 扩展；异常会诊断并回退字面 `Subtext`。 |
| `SubtextRich` | 获取副标题 rich 样式补丁字典；支持单项新增、删除、清空和深度样式补丁。 |
| `SubtextRichInheritPlainStyle` | 获取或设置副标题 rich run 是否继承普通文字字体、颜色、行高和透明度。 |
| `SubtextStyle` | 获取或设置副标题文本样式；赋空或未修改实例表示整块恢复默认。 |
| `Target` | 获取或设置主标题链接目标；空值恢复 `Blank`。 |
| `Text` | 获取或设置主标题字面文本；支持换行和已声明 rich 样式的标记。 |
| `TextAlign` | 获取或设置主、副标题共享的水平文字对齐。空值根据 box 位置自动推导；自然宽度时显式值<br />采用 ECharts 文字锚点语义，显式组件宽度时采用内容区内对齐扩展。 |
| `TextFormatter` | 获取或设置主标题同步强类型 formatter 扩展。ECharts 原生 title 文本没有 formatter；<br />本扩展仅在显式赋值时运行，异常会诊断并回退字面 `Text`。 |
| `TextRich` | 获取主标题 rich 样式补丁字典；支持单项新增、删除、清空和深度样式补丁。 |
| `TextRichInheritPlainStyle` | 获取或设置主标题 rich run 是否继承普通文字字体、颜色、行高和透明度。 |
| `TextStyle` | 获取或设置主标题文本样式；赋空或未修改实例表示整块恢复默认。 |
| `TextVerticalAlign` | 获取或设置主、副标题共享的垂直文字对齐。空值根据 box 位置自动推导；自然高度时显式值<br />采用 ECharts 文字锚点语义，显式组件高度时采用内容区内对齐扩展。 |
| `TriggerEvent` | 获取或设置无链接文字是否仍暴露 title 组件事件 metadata。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。

### `Reset`

保留 Id/Name 以继续匹配旧节点，并把显示、层级、静默、box 与全部 title 自有字段显式恢复默认。
