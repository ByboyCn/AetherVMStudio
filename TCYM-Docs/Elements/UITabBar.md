# UITabBar

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

Tab 标签栏组件，显示可点击的标签头部。 负责渲染底部指示线动画和标签切换交互。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `IndicatorColor` | `SKColor` | 底部指示线颜色。 |
| `IndicatorHeight` | `float` | 底部指示线高度（像素）。 |
| `AnimationDuration` | `float` | Tab 切换动画时长（秒）。 |
| `BaseLineColor` | `SKColor` | 底部基线颜色。 |
| `ShowBaseLine` | `bool` | 是否显示底部基线。 |
| `ShowIndicator` | `bool` | 是否显示底部指示线。 |
| `TabTextColor` | `SKColor` | Tab 默认文本颜色。 |
| `ActiveTextColor` | `SKColor` | Tab 选中文本颜色。 |
| `DisabledTextColor` | `SKColor` | Tab 禁用文本颜色。 |
| `HoverTextColor` | `SKColor` | Tab 悬停文本颜色。 |
| `BadgeColor` | `SKColor` | 角标背景颜色。 |
| `BadgeTextColor` | `SKColor` | 角标文本颜色。 |
| `TabGap` | `float` | Tab 标签之间的间距。 |
| `TabPadding` | `float` | Tab 内边距（每个标签的左右内边距）。 |
| `IconFontFamily` | `SKTypeface?` | 全局图标字体（可选）。TabItem 未设置 IconFontFamily 时使用此值。 |
| `TabPosition` | `TabPosition` | 标签栏方向（由 UITabs 传入）。 |
| `ActiveKey` | `object?` | 当前选中 Tab 的 Key。 |
| `Items` | `List<TabItem>` | Tab 项列表。 |
| `OnTabClick` | `Action<TabItem>?` | Tab 被点击时触发，参数为被点击的 TabItem。 |
| `OnTabClickAsync` | `Func<TabItem, Task>?` | 标签页被点击时触发的异步回调。 |

## 方法

### Update(float)

```csharp
void Update(float deltaSeconds)
```

在子节点样式刷新后重放组件默认色，缓存的来源判断不会逐帧重新匹配选择器。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` |  |

### Layout(float, float, float, float)

```csharp
void Layout(float x, float y, float width, float height)
```

布局完成后更新指示线位置。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |
| `width` | `float` |  |
| `height` | `float` |  |

### HasActiveAnimation()

```csharp
bool HasActiveAnimation()
```

指示条是组件自定义动画，必须显式参与主循环的活动动画判断。

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
