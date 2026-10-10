# UICarousel

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

Carousel 走马灯组件，参考 Ant Design Carousel 的核心交互模型。 支持自动播放、箭头、指示点、拖拽、淡入淡出、无限循环以及自定义指示点模板。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Style` | `UIStyle?` | 容器样式。外部赋值时保留 Carousel 所需的定位和裁剪能力。 |
| `Items` | `List<UIElement>` | 轮播项内容集合。每一项可以是任意 UIElement。 |
| `DefaultActiveIndex` | `int` | 默认激活项索引，初始化或热更新时使用。 |
| `ActiveIndex` | `int` |  |
| `Arrows` | `bool` | 是否显示左右切换箭头。 |
| `ArrowAlwaysVisible` | `bool` | 箭头是否始终显示。为 false 时，仅当鼠标悬停在 Carousel 上才显示箭头。 |
| `Autoplay` | `bool` | 是否自动播放。 |
| `AutoPlay` | `bool` | 是否自动播放，兼容 TCYM 其他组件的 AutoPlay 命名。 |
| `AutoplaySpeed` | `int` | 自动播放间隔，单位毫秒。 |
| `DotDuration` | `bool` | 自动播放时是否在指示点上显示进度。 |
| `PauseOnHover` | `bool` | 鼠标悬停时是否暂停自动播放。 |
| `AdaptiveHeight` | `bool` | 是否根据当前轮播项高度自适应容器高度。 |
| `DotPlacement` | `CarouselDotPlacement` | 指示点面板显示位置。 |
| `DotPosition` | `CarouselDotPlacement` | 指示点位置别名，对齐 Ant Design 的 dotPosition 用法。 |
| `Dots` | `bool` | 是否显示指示点。 |
| `DotTemplate` | `Func<UICarouselDotContext, UIElement>?` | 自定义指示点模板。返回的 UIElement 会被包裹为可点击指示点。 |
| `DotColor` | `SKColor` | 默认指示点颜色。 |
| `ActiveDotColor` | `SKColor` | 激活指示点颜色。 |
| `DotWidth` | `float` | 默认指示点宽度。 |
| `ActiveDotWidth` | `float` | 激活指示点宽度。 |
| `DotHeight` | `float` | 指示点高度。 |
| `DotGap` | `float` | 指示点之间的间距。 |
| `DotOffset` | `float` | 指示点距离容器边缘的偏移。 |
| `Draggable` | `bool` | 是否允许拖拽切换。 |
| `Fade` | `bool` | 是否启用淡入淡出效果。 |
| `Infinite` | `bool` | 是否无限循环切换。 |
| `Speed` | `int` | 切换动画时长，单位毫秒。 |
| `Easing` | `string` | 切换缓动函数，支持 linear、ease、ease-in、ease-out、ease-in-out。 |
| `Effect` | `CarouselEffect` | 轮播切换效果。 |
| `CardWidthRatio` | `float` | 卡片模式下激活项宽度占 Carousel 可用宽度的比例。 |
| `CardHeightRatio` | `float` | 卡片模式下激活项高度占 Carousel 可用高度的比例。 |
| `CardInactiveOpacity` | `float` | 卡片模式下非激活项的透明度。 |
| `WaitForAnimate` | `bool` | 是否等待当前动画完成后再响应新的切换请求。 |
| `BeforeChange` | `Action<int, int>?` | 切换前触发，参数依次为当前索引和下一索引。 |
| `BeforeChangeAsync` | `Func<int, int, Task>?` | 轮播项切换前触发的异步回调。 |
| `AfterChange` | `Action<int>?` | 切换完成后触发，参数为新的激活索引。 |
| `AfterChangeAsync` | `Func<int, Task>?` | 轮播项切换后触发的异步回调。 |
| `OnBeforeChange` | `Action<int, int>?` | 切换前回调别名，符合 TCYM 其他组件的 OnXxx 初始化风格。 |
| `OnBeforeChangeAsync` | `Func<int, int, Task>?` | 轮播项切换前触发的异步回调。 |
| `OnAfterChange` | `Action<int>?` | 切换完成回调别名，符合 TCYM 其他组件的 OnXxx 初始化风格。 |
| `OnAfterChangeAsync` | `Func<int, Task>?` | 轮播项切换后触发的异步回调。 |

## 方法

### GoTo(int, bool)

```csharp
void GoTo(int slideNumber, bool dontAnimate = false)
```

跳转到指定轮播项。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `slideNumber` | `int` | 目标轮播项索引。 |
| `dontAnimate` | `bool` | 是否跳过动画。 |

### Next()

```csharp
void Next()
```

切换到下一项。

### Prev()

```csharp
void Prev()
```

切换到上一项。

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

测量 Carousel 尺寸，并在未设置高度时提供默认高度。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` | 可用宽度。 |
| `availableHeight` | `float` | 可用高度。 |

### Layout(float, float, float, float)

```csharp
void Layout(float x, float y, float width, float height)
```

布局 Carousel 内部视口、轮播页、指示点和箭头。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` | 局部 X。 |
| `y` | `float` | 局部 Y。 |
| `width` | `float` | 布局宽度。 |
| `height` | `float` | 布局高度。 |

### Update(float)

```csharp
void Update(float deltaSeconds)
```

推进轮播动画与自动播放计时。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` | 距离上一帧的时间，单位秒。 |

### HasActiveAnimation()

```csharp
bool HasActiveAnimation()
```

报告 Carousel 需要连续重绘的动画状态。

**返回：** 存在切换、拖拽或可见自动播放进度动画时返回 true。

### OnPointerDown(float, float)

```csharp
void OnPointerDown(float x, float y)
```

鼠标或触摸按下时记录拖拽起点。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` | 局部 X。 |
| `y` | `float` | 局部 Y。 |

### OnPointerMove(float, float)

```csharp
void OnPointerMove(float x, float y)
```

指针移动时更新拖拽偏移。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` | 局部 X。 |
| `y` | `float` | 局部 Y。 |

### OnPointerUp(float, float)

```csharp
void OnPointerUp(float x, float y)
```

指针抬起时根据拖拽距离决定是否切换。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` | 局部 X。 |
| `y` | `float` | 局部 Y。 |

### OnTouchEvent(TCYM.UI.Events.UITouchEvent)

```csharp
void OnTouchEvent(TCYM.UI.Events.UITouchEvent e)
```

触摸事件入口，用于在触摸拖拽时维持同一触点的移动链路。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `TCYM.UI.Events.UITouchEvent` | 触摸事件。 |

## 相关类型

### CarouselDotPlacement

> **类型**：枚举

Carousel 指示点面板的显示位置。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Top` | - | 指示点显示在轮播区域顶部。 |
| `Bottom` | - | 指示点显示在轮播区域底部。 |
| `Start` | - | 指示点显示在轮播区域起始侧，当前布局中对应左侧。 |
| `End` | - | 指示点显示在轮播区域结束侧，当前布局中对应右侧。 |

### CarouselEffect

> **类型**：枚举

Carousel 轮播切换效果。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `ScrollX` | - | 横向滑动切换。 |
| `Fade` | - | 淡入淡出切换。 |
| `Card` | - | 中间项突出、两侧相邻项露出的卡片化切换。 |
