# UIAnchor

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

锚点导航组件。组件仅在自身存在 <see cref="UIScrollView"/> 父级或祖先级时生效， 并通过 <see cref="AnchorItem.ComponentId"/> 在当前窗口的元素注册表中定位目标。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `LinkClassName` | `string` | 所有锚点链接都会包含的基础 CSS 类名。 |
| `ActiveLinkClassName` | `string` | 当前活动锚点链接包含的 CSS 类名。 |
| `DisabledLinkClassName` | `string` | 禁用锚点链接包含的 CSS 类名。 |
| `Items` | `List<AnchorItem>` | 锚点项。修改现有 List 后需要重新设置该属性以刷新视图。 |
| `ActiveComponentId` | `string?` | 当前高亮锚点所对应的组件 Id。 |
| `Bounds` | `float` | 目标越过视口顶部多少像素后切换高亮。 |
| `TargetOffset` | `float` | 目标滚动完成后与滚动视口顶部保留的距离。 |
| `Affix` | `bool` | 是否在最近的祖先滚动视口内保持当前位置。该行为会抵消该层 UIScrollView 的滚动变换， 但仍会跟随更外层容器移动。 |
| `ItemHeight` | `float` | 单项高度。 |
| `ItemPaddingStart` | `float` | 一级锚点文字距左侧导轨的距离。 |
| `ItemIndent` | `float` | 每一级子锚点增加的缩进。 |
| `RailColor` | `SKColor` | 导轨颜色。 |
| `LinkColor` | `SKColor` | 普通锚点文字颜色。 |
| `ActiveColor` | `SKColor` | 激活锚点与指示器颜色。 |
| `DisabledColor` | `SKColor` | 禁用锚点文字颜色。 |
| `IndicatorWidth` | `float` | 活动指示器宽度。 |
| `IndicatorHeight` | `float` | 活动指示器高度。 |
| `OnItemClick` | `Action<AnchorItem>?` | 点击任意未禁用锚点时触发。 |
| `OnItemClickAsync` | `Func<AnchorItem, Task>?` | 点击锚点项时触发的异步回调。 |
| `OnChange` | `Action<string?>?` | 当前高亮组件 Id 改变时触发。 |
| `OnChangeAsync` | `Func<string?, Task>?` | 当前锚点变化时触发的异步回调。 |

## 方法

### ScrollTo(string)

```csharp
bool ScrollTo(string componentId)
```

滚动到指定 Id 对应的组件。若 Anchor 不在 UIScrollView 内、目标不存在， 或目标不属于任一 Anchor 祖先滚动容器，则返回 false 且不产生滚动。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `componentId` | `string` |  |

### ScrollTo(string, float)

```csharp
bool ScrollTo(string componentId, float targetOffset)
```

滚动到指定 Id 对应的组件，并为本次滚动指定顶部偏移。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `componentId` | `string` |  |
| `targetOffset` | `float` |  |

### Layout(float, float, float, float)

```csharp
void Layout(float x, float y, float width, float height)
```

布局同步 Affix，保证滚轮后的输入屏障无需额外 Update 就能绘制正确位置。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |
| `width` | `float` |  |
| `height` | `float` |  |

### Update(float)

```csharp
void Update(float deltaSeconds)
```

每帧更新活动锚点；保留独立调用 Update 时的 Affix 同步兜底。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` |  |

## 相关类型

### AnchorItem

> **类型**：类

<see cref="UIAnchor"/> 中的一项，通过 <see cref="ComponentId"/> 指向同一 UI 树中的目标元素。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `ComponentId` | `string` | 目标组件的 <see cref="Core.UIElement.Id"/>。 |
| `Title` | `string` | 锚点显示文字。 |
| `Disabled` | `bool` | 是否禁用该锚点。 |
| `TargetOffset` | `float?` | 该项单独使用的顶部偏移；未设置时使用 <see cref="UIAnchor.TargetOffset"/>。 |
| `ClassName` | `Core.UIElement.UIClassNameCollection` | 追加到该锚点链接元素的 CSS 类名。组件仍会保留 <see cref="UIAnchor.LinkClassName"/> 及活动、禁用状态类。 |
| `Children` | `List<AnchorItem>` | 子锚点项。 |
