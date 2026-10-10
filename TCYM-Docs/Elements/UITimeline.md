# UITimeline

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

时间轴组件。支持纵向与横向排列、Start/End/Alternate 模式、反向排序、 标题双栏、自定义颜色、加载状态和自定义节点。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `RootClassName` | `string` | 根元素建议使用的语义 CSS 类名。 |
| `ItemClassName` | `string` | 单个项目根元素的语义 CSS 类名。 |
| `ItemTitleClassName` | `string` | 项目标题插槽的语义 CSS 类名。 |
| `ItemContentClassName` | `string` | 项目内容插槽的语义 CSS 类名。 |
| `ItemIconClassName` | `string` | 自定义节点插槽的语义 CSS 类名。 |
| `Items` | `List<TimelineItem>` | 时间轴数据。修改现有 List 后请重新设置该属性，或调用 <see cref="Refresh"/> 刷新视图。 |
| `Mode` | `TimelineMode` | 内容排列模式，默认为 Start。 |
| `Orientation` | `TimelineOrientation` | 时间轴方向，默认为 Vertical。 |
| `Variant` | `TimelineVariant` | 默认节点的视觉变体，默认为 Outlined。 |
| `Reverse` | `bool` | 是否按相反顺序显示 Items。 |
| `TitleSpan` | `float` | 纵向标题双栏中，从起始侧到节点中心所占的 24 栅格份数，范围 1 到 23，默认 12。 Mode=End 时会自动镜像；Alternate 始终保持居中。 |
| `DotSize` | `float` | 默认圆点直径，单位为逻辑像素，默认为 10。 |
| `DotBorderWidth` | `float` | 空心圆点边框宽度，单位为逻辑像素，默认为 2。 |
| `RailWidth` | `float` | 连接轨道宽度，单位为逻辑像素，默认为 2。 |
| `ItemPaddingBottom` | `float` | 纵向项目之间的底部间距，单位为逻辑像素，默认为 20。 |
| `ContentGap` | `float` | 节点中心与标题/内容之间的最小间距，单位为逻辑像素，默认为 16。 |
| `PrimaryColor` | `SKColor` | 未单独指定颜色的节点所使用的主色。 |
| `RailColor` | `SKColor` | 项目之间连接轨道的颜色。 |
| `DotBackground` | `SKColor` | Outlined 节点和加载节点内部的背景色。 |

## 方法

### Refresh()

```csharp
void Refresh()
```

在原地重新读取 Items，并刷新显示顺序和内部元素。

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` |  |
| `availableHeight` | `float` |  |

### Layout(float, float, float, float)

```csharp
void Layout(float x, float y, float width, float height)
```

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

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` |  |

### HasActiveAnimation()

```csharp
bool HasActiveAnimation()
```

## 相关类型

### TimelineItem

> **类型**：类

<see cref="UITimeline"/> 中的一项。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Key` | `string?` | 可选稳定键，用于标识业务数据和预览热更新签名。 |
| `Title` | `TimelineNode` | 时间、日期或阶段标题，可使用文本或任意 UIElement。 |
| `Content` | `TimelineNode` | 项目主体内容，可使用文本或任意 UIElement。 |
| `Icon` | `UIElement?` | 自定义时间轴节点。为空时绘制默认圆点；Loading=true 时绘制加载节点。 |
| `Color` | `SKColor?` | 当前节点颜色；为空时使用 <see cref="UITimeline.PrimaryColor"/>。 |
| `Loading` | `bool` | 是否显示加载状态。设置了 Icon 时优先显示自定义节点。 |
| `Placement` | `TimelineItemPlacement?` | 覆盖当前项目在双侧布局中的位置。为空时由 Timeline.Mode 和显示顺序决定。 |
| `ClassName` | `UIElement.UIClassNameCollection` | 追加到项目根元素的 CSS 类名。 |

### TimelineItemPlacement

> **类型**：枚举

单个时间轴项目在双侧布局中的位置。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Start` | - | 标题位于起始侧，内容位于结束侧。 |
| `End` | - | 标题位于结束侧，内容位于起始侧。 |

### TimelineMode

> **类型**：枚举

时间轴内容的排列模式。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Start` | - | 时间轴位于起始侧；存在标题时，标题位于起始侧、内容位于结束侧。 |
| `End` | - | 时间轴位于结束侧；存在标题时，标题位于结束侧、内容位于起始侧。 |
| `Alternate` | - | 内容在时间轴两侧交替排列。 |

### TimelineNode

> **类型**：结构体

Timeline 的文本或自定义元素节点。可直接从 <see cref="string"/> 或 <see cref="UIElement"/> 隐式转换。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Text` | `string?` | 纯文本内容；使用自定义元素时为空。 |
| `Element` | `UIElement?` | 自定义元素；使用纯文本时为空。 |
| `IsEmpty` | `bool` | 当前节点是否没有任何可显示内容。 |

### TimelineOrientation

> **类型**：枚举

时间轴方向。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Vertical` | - | 从上到下排列。 |
| `Horizontal` | - | 从左到右排列。 |

### TimelineVariant

> **类型**：枚举

时间轴节点的视觉变体。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Outlined` | - | 空心节点，使用项目颜色绘制边框。 |
| `Filled` | - | 实心节点，使用项目颜色填充。 |
