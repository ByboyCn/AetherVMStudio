# UIFloatButton

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

参考 Ant Design 的悬浮按钮。 复用 Tooltip、Badge 和 UIButton 组合实现，支持 fixed 定位、描述型按钮和按钮组搭配使用。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Click` | `Action?` | 点击按钮时执行。 由于内部使用组合控件，此属性是最直接的点击入口。 |
| `ClickAsync` | `Func<Task>?` | 浮动按钮被点击时触发的异步回调。 |
| `Icon` | `string` | 图标内容，支持图标字体编码或普通文本。 |
| `IconFont` | `SKTypeface?` | 图标字体。未设置时会自动在图标字体和默认字体之间选择。 |
| `Description` | `string` | 描述文字。设置后按钮自动切换为方形说明模式。 |
| `Tooltip` | `string?` | Tooltip 文本。 |
| `TooltipPlacement` | `TooltipPlacement` | Tooltip 位置。 |
| `Shape` | `FloatButtonShape` | 按钮形状。设置了 Description 时会自动按方形渲染。 |
| `ButtonStyle` | `UIStyle?` | 按钮样式覆盖。 会在内置默认样式之上进行合并，用于自定义背景、边框、文字颜色和 Hover 效果。 |
| `Fixed` | `bool` | 是否使用 fixed 定位。 |
| `OffsetRight` | `float` | fixed 模式下距右侧的偏移量。 |
| `OffsetBottom` | `float` | fixed 模式下距底部的偏移量。 |
| `Disabled` | `bool` | 是否禁用。 |
| `BadgeCount` | `int?` | 徽标计数。 |
| `BadgeText` | `string?` | 徽标文本。 |
| `BadgeDot` | `bool` | 是否显示徽标红点。 |
| `BadgeShowZero` | `bool` | Count=0 时是否仍显示徽标。 |
| `BadgeColor` | `SKColor?` | 徽标颜色。 |
| `BadgeOffsetX` | `float` | 徽标水平偏移。 |
| `BadgeOffsetY` | `float` | 徽标垂直偏移。 |
| `TooltipElement` | `UITooltip` | 内部 Tooltip 容器，便于高级定制。 |
| `BadgeElement` | `UIBadge` | 内部 Badge 容器，便于高级定制。 |
| `ButtonElement` | `UIButton` | 实际承载交互的按钮元素。 |

## 相关类型

### FloatButtonShape

> **类型**：枚举

悬浮按钮形状。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Circle` | - | 圆形按钮。 |
| `Square` | - | 方形按钮。 |

### TooltipPlacement

> **类型**：枚举

Tooltip 弹层位置。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Top` | - | 上方居中。 |
| `TopLeft` | - | 上方左对齐。 |
| `TopRight` | - | 上方右对齐。 |
| `Bottom` | - | 下方居中。 |
| `BottomLeft` | - | 下方左对齐。 |
| `BottomRight` | - | 下方右对齐。 |
| `Left` | - | 左侧居中。 |
| `LeftTop` | - | 左侧顶部对齐。 |
| `LeftBottom` | - | 左侧底部对齐。 |
| `Right` | - | 右侧居中。 |
| `RightTop` | - | 右侧顶部对齐。 |
| `RightBottom` | - | 右侧底部对齐。 |
