# UISplitterPanel

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIContainer`

## 概述

Splitter.Panel 面板。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Size` | `UnitValue?` | 当前面板的受控尺寸。 支持像素、百分比或 calc 表达式。 |
| `DefaultSize` | `UnitValue?` | 当前面板的默认尺寸。 仅在首次参与布局或双击重置时作为参考值。 |
| `Min` | `UnitValue?` | 最小尺寸。 |
| `Max` | `UnitValue?` | 最大尺寸。 |
| `CollapsedSize` | `UnitValue` | 折叠后的尺寸，默认 0。 |
| `Resizable` | `bool` | 是否允许通过拖拽条调整尺寸。 |
| `Collapsible` | `bool` | 是否启用快捷折叠能力。 |
| `CollapsibleOptions` | `UISplitterPanelCollapsibleOptions` | 折叠细节配置。 |
| `IsCollapsed` | `bool` | 当前是否处于折叠状态。 由 Splitter 在布局过程中维护。 |
| `CollapsedToStart` | `bool?` | 当前折叠方向是否为起始侧。 null 表示未折叠。 |

## 相关类型

### SplitterCollapsibleIconVisibility

> **类型**：枚举

可折叠图标的显示策略。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Auto` | - | 自动模式，仅在拖拽条悬浮、激活或当前面板已折叠时显示。 |
| `Visible` | - | 始终显示。 |
| `Hidden` | - | 不显示。 |

### UISplitterPanelCollapsibleOptions

> **类型**：类

Splitter.Panel 的可折叠配置。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Start` | `bool` | 是否允许通过起始侧拖拽条折叠。 对于水平 Splitter 即向左折叠；垂直 Splitter 即向上折叠。 |
| `End` | `bool` | 是否允许通过结束侧拖拽条折叠。 对于水平 Splitter 即向右折叠；垂直 Splitter 即向下折叠。 |
| `ShowCollapsibleIcon` | `SplitterCollapsibleIconVisibility` | 折叠图标显示策略。 |
