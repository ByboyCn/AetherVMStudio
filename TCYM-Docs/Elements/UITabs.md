# UITabs

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

Tabs 标签页组件，支持多标签切换并展示对应内容。 设计参考 Ant Design Tabs 核心交互：可配置标签栏位置、切换动画、角标等。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Items` | `List<TabItem>` | Tab 页签项列表。设置后自动重建标签栏和内容区域。 |
| `DefaultActiveKey` | `object?` | 默认选中的 Tab Key（仅初始化时使用）。 |
| `ActiveKey` | `object?` |  |
| `TabPosition` | `TabPosition` | 标签栏位置。 |
| `AnimationDuration` | `float` | Tab 切换动画时长（秒），传递给 UITabBar。 |
| `IndicatorColor` | `SKColor` | 底部指示线颜色，传递给 UITabBar。 |
| `IndicatorHeight` | `float` | 底部指示线高度（像素），传递给 UITabBar。 |
| `BaseLineColor` | `SKColor` | 底部基线颜色，传递给 UITabBar。 |
| `ShowBaseLine` | `bool` | 是否显示底部基线，传递给 UITabBar。 |
| `ShowIndicator` | `bool` | 是否显示底部指示线，传递给 UITabBar。 |
| `TabTextColor` | `SKColor` | Tab 默认文本颜色，传递给 UITabBar。 |
| `ActiveTextColor` | `SKColor` | Tab 选中文本颜色，传递给 UITabBar。 |
| `DisabledTextColor` | `SKColor` | Tab 禁用文本颜色，传递给 UITabBar。 |
| `HoverTextColor` | `SKColor` | Tab 悬停文本颜色，传递给 UITabBar。 |
| `TabGap` | `float` | Tab 标签之间的间距，传递给 UITabBar。 |
| `TabPadding` | `float` | Tab 内边距（每个标签的左右内边距），传递给 UITabBar。 |
| `BadgeColor` | `SKColor` | 角标背景颜色，传递给 UITabBar。 |
| `BadgeTextColor` | `SKColor` | 角标文本颜色，传递给 UITabBar。 |
| `IconFontFamily` | `SKTypeface?` | 全局图标字体，传递给 UITabBar。TabItem 未设置 IconFontFamily 时使用此值。 |
| `ContentStyle` | `UIStyle?` | 内容区域样式（合并到默认样式上，不会丢失 FlexGrow/Overflow 等布局属性）。 |
| `TabBarStyle` | `UIStyle?` | 标签栏样式（合并到默认样式上，不会丢失 Display/FlexDirection 等布局属性）。 |
| `Style` | `UIStyle?` | 元素样式。设置时会合并到默认样式上，保留 Display/FlexDirection/Overflow 等关键布局属性。 |
| `OnTabChanged` | `Action<TabItem>?` | Tab 切换后触发，参数为新激活的 TabItem。 |
| `OnTabChangedAsync` | `Func<TabItem, Task>?` | 当前标签页变化时触发的异步回调。 |
| `OnTabClick` | `Action<TabItem>?` | Tab 被点击时触发（无论是否切换），参数为被点击的 TabItem。 |
| `OnTabClickAsync` | `Func<TabItem, Task>?` | 标签页被点击时触发的异步回调。 |

## 方法

### SwitchTo(object)

```csharp
void SwitchTo(object key)
```

通过 Key 切换到指定 Tab。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `key` | `object` | 要激活的 Tab Key。 |

### GetActiveItem()

```csharp
TabItem? GetActiveItem()
```

获取当前激活的 TabItem。

**返回：** 当前激活的 TabItem，未找到返回 null。

## 相关类型

### TabItem

> **类型**：类

Tab 标签页数据模型，描述一个标签页的基础信息。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Key` | `object` | Tab 唯一标识。 |
| `Label` | `string` | Tab 标题文本。 |
| `IconContent` | `string?` | Tab 图标 Unicode 或字体图标类名内容（可选）。 |
| `IconFontFamily` | `SKTypeface?` | Tab 图标字体（可选）。 |
| `Icon` | `UIIcon?` | Tab 自定义图标元素（可选）。若同时设置了 IconContent，优先使用 Icon。 |
| `Content` | `UIElement?` | Tab 对应的内容元素。 |
| `IsShow` | `bool` | 是否显示该 Tab，默认 true。 |
| `Disabled` | `bool` | 是否禁用该 Tab。 |
| `Badge` | `int?` | Tab 角标数字（可选，null 表示不显示）。 |
| `Sort` | `int` | 自定义排序值，值越小越靠前。 |
| `Tag` | `object?` | 附加的自定义数据。 |

### TabPosition

> **类型**：枚举

Tab 标签栏位置枚举。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Top` | - | 标签栏在内容区上方（默认）。 |
| `Bottom` | - | 标签栏在内容区下方。 |
| `Left` | - | 标签栏在内容区左侧。 |
| `Right` | - | 标签栏在内容区右侧。 |
