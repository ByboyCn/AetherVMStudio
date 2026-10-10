# UIScrollView

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

滚动容器，支持垂直/水平滚动，以及两种模式： 1）普通容器模式：直接渲染 Children / 单一内部容器； 2）数据虚拟列表模式：通过 SetItems、items 按数据源虚拟化子项，仅创建可见区域的 UIElement。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `EnableDeferredChildLoading` | `bool` | 是否启用普通子集合的延迟挂载。 开启后会先保留少量首屏子项，其余子项在后续帧分批加入，降低启动时的同步压力。 |
| `InitialChildLoadCount` | `int` | 首次立即保留的子项数量。 只有超过该数量的剩余子项才会进入延迟挂载队列。 |
| `DeferredChildBatchSize` | `int` | 每批次补挂回滚动容器的子项数量。 数值越大，补全越快；数值越小，首屏更轻。 |
| `DeferredChildMinCount` | `int` | 启用延迟挂载所需的最小子项数。 当子项数低于该阈值时，仍按原方式一次性挂载。 |
| `DeferredChildMaxCount` | `int` | 启用延迟挂载允许的最大子项数。 超过该数量时，认为该滚动容器更像内容型控件而不是页面分区，改为一次性挂载。 |
| `DeferredChildLoadIntervalSeconds` | `float` | 延迟挂载批次之间的时间间隔（秒）。 |
| `DeferredChildViewportBufferRatio` | `float` | 首屏预计可见区域在交叉轴方向的预热缓冲比例。 例如 0.5 表示除了首屏可见区域外，再额外保留半屏高度（或宽度）的候选子项。 |
| `Items` | `Func<(IList<object> items,             Func<object, UIElement> factory,             Func<object, float> heightProvider,             Func<object, float>? widthProvider,             Func<object, UIElement, UIElement>? reuseFactory,             Func<object, UIElement, float>? realizedHeightProvider,             Func<object, UIElement, float>? realizedWidthProvider)>?` | 使用数据源启用虚拟列表模式。 启用后不再使用 UIView.Children 存储所有项，仅通过内部可见项映射渲染当前视口， 适合大数据量列表或表格。 |
| `ScrollY` | `float` | 当前垂直滚动偏移量（像素，向下为正）。 只读，请通过 <see cref="ScrollByY"/> / <see cref="ScrollBy(float)"/> / <see cref="OnWheel"/> 修改。 |
| `ScrollX` | `float` | 当前水平滚动偏移量（像素，向右为正）。 只读，请通过 <see cref="ScrollByX"/> / <see cref="OnWheel"/> 修改。 |
| `Deceleration` | `float` | 垂直方向惯性减速度（像素/秒^2）。 数值越大减速越快，滚动越硬；数值越小减速越慢，滚动越顺滑。 |
| `EnableTabletTouchScroll` | `bool` | 是否仅在平板设备上启用手指拖拽滚动。 |
| `TouchDragThreshold` | `float` | 手指拖拽判定阈值（像素）。 超过该阈值后开始接管为滚动手势。 |
| `MaxTouchInertiaVelocity` | `float` | 触摸释放后的最大惯性速度（像素/秒）。 |
| `TouchScrollSensitivity` | `float` | 手指拖拽滚动灵敏度。 1 表示手指移动与内容滚动一比一；小于 1 会减慢滚动速度。 |
| `EnableVirtualization` | `bool` | 是否启用容器模式的简单虚拟化（仅针对单一内部容器）， 只影响渲染区域裁剪，不涉及数据源级别的虚拟列表管理。 |
| `VirtualizeInnerContainer` | `bool` | 当为 true 且 Children 中仅有一个 <see cref="UIContainer"/> 子元素时， 仅对该内部容器的 <see cref="UIElement.Children"/> 做可见区域裁剪渲染。 |
| `EstimatedItemHeight` | `float` | 估算的单项高度（像素），用于容器模式虚拟化时的 Overscan 计算。 不要求与真实高度完全一致，只影响预渲染缓冲区大小。 |
| `Overscan` | `int` | 容器模式虚拟化时，在可见区域上下各额外预渲染的行数，用于避免快速滚动时的闪白。 |
| `ShowScrollbar` | `bool` | 是否绘制滚动条（水平/垂直）。关闭后仍然可以滚动，只是不显示滚动条。 |
| `AutoHideScrollbar` | `bool` | 是否自动隐藏滚动条。为 true 时，仅在交互或惯性滚动期间显示，空闲一段时间后自动隐藏。 |
| `AutoHideDelaySeconds` | `float` | 自动隐藏滚动条的延迟时间（秒）。在没有交互且速度较小时，倒计时结束后隐藏滚动条。 |
| `ScrollbarWidth` | `float` | 滚动条厚度（像素），既用于垂直滚动条宽度，也用于水平滚动条高度。 |
| `ScrollbarTrackColor` | `SKColor` | 滚动条轨道颜色（背景条）。 |
| `ScrollbarThumbColor` | `SKColor` | 滚动条滑块颜色（前景条）。 |
| `ScrollbarRadius` | `float` | 滚动条圆角半径（像素）。 |
| `ScrollbarEdgeInset` | `float` | 滚动条轨道与控件边框之间的间距（逻辑像素）。 默认保留 2 像素，避免细滚动条紧贴边框时看起来像局部加深的边框；设置为 0 可恢复贴边布局。 |
| `ScrollbarThumbMinSize` | `float` | 滚动条滑块最小长度（像素）。 内容很长时滑块会非常小，设置最小值便于点击/拖拽。 |
| `EnableScrollbarAutoResize` | `bool` | 是否启用滚动条自动缩放。 开启后，滚动条在未被指针接近时显示极细宽度，指针靠近时自动展开到正常宽度。 |
| `ScrollbarThinWidth` | `float` | 滚动条极细模式下的宽度（像素）。 仅在 <see cref="EnableScrollbarAutoResize"/> 为 true 时生效。 |
| `ScrollbarHoverProximity` | `float` | 指针距离滚动条边缘多少像素内触发展开（像素）。 |
| `ScrollbarResizeDuration` | `float` | 滚动条宽度变化的动画过渡时间（秒）。 |
| `OnScrollChanged` | `event Action<float, float>?` | 滚动偏移变化事件。在 <see cref="ScrollY"/> 或 <see cref="ScrollX"/> 发生变化时触发（包括拖拽、滚轮、惯性等）。 参数：(scrollY, scrollX) |
| `OnScrollChangedAsync` | `event Func<float, float, Task>?` | 滚动位置变化时触发的异步事件。 |

## 方法

### AddDeferredChildren(Func<UIElement>[])

```csharp
void AddDeferredChildren(Func<UIElement>[] factories)
```

按工厂函数延迟创建子元素。 与普通 Children 延迟挂载不同，这里不会先构建全部 UIElement 再拆下， 而是只立即创建少量首屏项，其余子项在后续帧按批次真正构建并加入滚动容器。 适合页面分区较多、单个子树构建成本较高的场景。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `factories` | `Func<UIElement>[]` | 子元素构建工厂集合。 |

### GetScrollOffsetRelativeToRoot()

```csharp
(float totalScrollX, float totalScrollY) GetScrollOffsetRelativeToRoot()
```

获取从当前元素到根元素路径上所有 UIScrollView 的累计滚动偏移量。 用于计算子元素在根坐标系中的实际可见位置。

**返回：** 累计滚动偏移量元组 (totalScrollX, totalScrollY)。 - totalScrollX: 所有祖先 UIScrollView 的 ScrollX 之和（包括自身） - totalScrollY: 所有祖先 UIScrollView 的 ScrollY 之和（包括自身）

### GetScrollOffsetRelativeToRoot(UIElement?)

```csharp
(float totalScrollX, float totalScrollY) GetScrollOffsetRelativeToRoot(UIElement? element)
```

获取指定元素相对于根元素的累计滚动偏移量。 静态方法，遍历从指定元素到根元素路径上的所有 UIScrollView。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `element` | `UIElement?` | 要计算滚动偏移的元素 |

**返回：** 累计滚动偏移量元组 (totalScrollX, totalScrollY)。 如果元素为 null，返回 (0, 0)。

### HitTestGlobal(float, float)

```csharp
bool HitTestGlobal(float screenX, float screenY)
```

重写 HitTestGlobal，确保嵌套 UIScrollView 场景下正确处理裁剪边界。 当外层 UIScrollView 滚动后，内部元素的全局位置会改变， 需要检查点是否在所有祖先 UIScrollView 的可视区域内。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `screenX` | `float` |  |
| `screenY` | `float` |  |

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

测量阶段：根据可用宽高计算自身尺寸。 - display:none 时不占空间（除非处于 hover 隐藏保留布局时）。 - 未显式宽/高时，可由子类或子元素在 Measure 中设置。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` | 可用宽度 |
| `availableHeight` | `float` | 可用高度 |

### SetItems(IList<T>, , UIElement>, , float>, , float>?, , , UIElement>?)

```csharp
void SetItems(IList<T> items,  Func<T, UIElement> factory,  Func<T, float> heightProvider,  Func<T, float>? widthProvider = null,  Func<T,  UIElement, UIElement>? reuseFactory = null)
```

使用数据源启用虚拟列表模式。 启用后不再使用 UIView.Children 存储所有项，仅通过内部可见项映射渲染当前视口， 适合大数据量列表或表格。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `items` | `IList<T>` | 数据源列表。 |
| `Func<T` | `` |  |
| `factory` | `UIElement>` | 根据数据项创建 <see cref="UIElement"/> 的工厂方法。 |
| `Func<T` | `` |  |
| `heightProvider` | `float>` | 根据数据项返回该行高度（像素）。 |
| `Func<T` | `` |  |
| `widthProvider` | `float>?` | 可选：根据数据项返回该行内容宽度（像素），用于计算水平滚动范围； 为空时默认使用当前视口宽度。 |
| `Func<T` | `` |  |
| `UIElement` | `` |  |
| `reuseFactory` | `UIElement>?` | 可选：复用工厂，有可回收元素时调用 (data, oldElement) 返回可复用的元素， 便于减少 GC 和提高性能。 |

### ClearItems()

```csharp
void ClearItems()
```

清空数据虚拟列表模式及其缓存，恢复为普通容器模式。

### ScrollByY(float)

```csharp
void ScrollByY(float dy)
```

垂直方向滚动指定偏移量（像素）。 正值通常表示向下滚动，负值表示向上滚动。 推荐用于按键控制、编程滚动到指定位置等场景。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `dy` | `float` |  |

### ScrollByX(float)

```csharp
void ScrollByX(float dx)
```

水平方向滚动指定偏移量（像素）。 正值通常表示向右滚动，负值表示向左滚动。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `dx` | `float` |  |

### ScrollBy(float)

```csharp
void ScrollBy(float dy)
```

垂直滚动的兼容接口，等价于 <see cref="ScrollByY"/>。 方便复用旧代码：旧代码调用 ScrollBy 不需要修改。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `dy` | `float` |  |

### CancelTouchScroll(long)

```csharp
bool CancelTouchScroll(long touchId)
```

仅取消指定触点在此容器中拥有的触摸滚动与惯性，不广播触摸事件或影响其他触点。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `touchId` | `long` | 需要释放滚动追踪的精确触点标识。 |

**返回：** 此容器确实正在追踪该触点且已完成取消时返回 true。

### IsTouchScrollActive(long)

```csharp
bool IsTouchScrollActive(long touchId)
```

查询指定触点是否已越过此容器的拖动阈值并拥有当前触摸滚动。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `touchId` | `long` | 需要查询的精确触点标识；其他触点不会匹配。 |

**返回：** 此容器正在为该触点执行触摸滚动时返回 true。

### OnTouchEvent(UITouchEvent)

```csharp
void OnTouchEvent(UITouchEvent e)
```

处理触摸事件。 在平板设备上支持手指拖拽滚动，并在抬手后延续惯性滚动。 当自身不可滚动或已到达边界时，将触摸事件/剩余滚动量冒泡到祖先 ScrollView。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UITouchEvent` | 触摸事件。 |

### OnPointerDown(float, float)

```csharp
void OnPointerDown(float x, float y)
```

处理指针按下（局部坐标）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnPointerMove(float, float)

```csharp
void OnPointerMove(float x, float y)
```

处理指针移动（局部坐标）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnPointerUp(float, float)

```csharp
void OnPointerUp(float x, float y)
```

处理指针抬起（局部坐标）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnWheel(float, float)

```csharp
void OnWheel(float deltaY, float deltaX = 0)
```

鼠标滚轮滚动接口。 通常 deltaY 来自垂直滚轮（向上为正/向下为负取决于输入设备）， deltaX 可用于支持水平滚动（如触控板水平滑动）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaY` | `float` | 垂直滚轮增量。 |
| `deltaX` | `float` | 水平滚轮增量，可选。 |

### Update(float)

```csharp
void Update(float deltaSeconds)
```

每帧更新：处理悬停清理延迟、启动/反转动画，推动子元素更新。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` | 距离上次更新的时间增量（秒）。 |


---

# UIScrollView

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`


---

# UIScrollView

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`
