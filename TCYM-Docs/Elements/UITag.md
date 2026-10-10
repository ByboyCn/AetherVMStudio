# UITag

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UILabel`

## 概述

标签组件，基于 UILabel 实现。 类似 Ant Design 的 Tag 组件，支持多种变体和预设颜色。 功能： 1. 支持三种变体样式：Filled（填充）、Solid（实心）、Outlined（描边） 2. 支持 11 种预设颜色（Ant Design 风格） 3. 支持自定义图标及图标位置 4. 当未设置 ClassColor 时，使用 Style 中的 Color 进行样式计算

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Variant` | `TagVariant` | 标签变体样式。 Filled = 填充样式（浅色背景） Solid = 实心样式（白色文字） Outlined = 描边样式（带边框） 默认为 Filled。 |
| `ClassColor` | `TagClassColor?` | 预设颜色。 如果设置，将使用 Ant Design 风格的预设颜色。 如果为 null，则使用 Style 中的 Color 进行计算。 |
| `Icon` | `UIIcon?` | 标签图标。 如果图标未设置字体颜色，将自动使用标签的文字颜色。 |
| `IconPosition` | `TagIconPosition` | 图标位置。 Left = 图标在文本左侧 Right = 图标在文本右侧 默认为 Left。 |
| `IconGap` | `float` | 图标与文本之间的间距。 |

## 方法

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

测量标签尺寸，包含图标的空间。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` |  |
| `availableHeight` | `float` |  |

### Layout(float, float, float, float)

```csharp
void Layout(float x, float y, float width, float height)
```

布局阶段：确保图标在 Layout 后拥有正确的命中测试位置。 基类 Layout 处理绝对定位子元素时，由于 UIIcon 未设置 left/top， 会回退到内容区域起始位置（左上角），导致 HitTest 无法命中图标的实际视觉位置。 这里在 base.Layout 之后重新计算并设置图标的正确坐标。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |
| `width` | `float` |  |
| `height` | `float` |  |

## 相关类型

### TagClassColor

> **类型**：枚举

标签预设颜色枚举。 定义 UITag 支持的 Ant Design 风格预设颜色。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Magenta` | - | 洋红色 |
| `Red` | - | 红色 |
| `Volcano` | - | 火山色 |
| `Orange` | - | 橙色 |
| `Gold` | - | 金色 |
| `Lime` | - | 青柠色 |
| `Green` | - | 绿色 |
| `Cyan` | - | 青色 |
| `Blue` | - | 蓝色 |
| `GeekBlue` | - | 极客蓝 |
| `Purple` | - | 紫色 |

### TagIconPosition

> **类型**：枚举

图标位置枚举。 定义 UITag 中图标相对于文本的位置。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Left` | - | 图标在文本左侧 |
| `Right` | - | 图标在文本右侧 |

### TagVariant

> **类型**：枚举

标签变体类型枚举。 定义 UITag 的不同视觉样式变体。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Filled` | - | 填充样式：有颜色和背景色（浅色背景）。 |
| `Solid` | - | 实心样式：白色文字配实心背景色。 |
| `Outlined` | - | 描边样式：有颜色、背景色和边框。 |
