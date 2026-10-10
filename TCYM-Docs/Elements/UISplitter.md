# UISplitter

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

Splitter 分隔面板容器，参考 Ant Design Splitter 的交互能力。 支持水平/垂直布局、拖拽调整、懒更新、尺寸约束、可折叠和双击重置。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Orientation` | `SplitterOrientation?` | 布局方向。为 null 时使用 Vertical 作为兼容开关。 |
| `Vertical` | `bool` | 兼容 Ant Design 的 vertical 布尔开关。 当 Orientation 为 null 时生效。 |
| `Lazy` | `bool` | 是否开启懒更新模式。 开启后拖拽过程中仅显示预览线，松手时才真正更新面板尺寸。 |
| `SplitBarSize` | `float` | 可视分隔条厚度。 |
| `SplitTriggerSize` | `float` | 拖拽触发区域厚度。 |
| `SplitBarDraggableSize` | `float` | 中央操作把手的长轴尺寸。 |
| `DraggerCornerRadius` | `float` | 拖拽条圆角。 |
| `CollapseButtonSize` | `float` | 折叠按钮尺寸。 |
| `CollapseButtonHeight` | `float` | 折叠按钮高度。 对左右箭头场景会直接影响按钮的纵向尺寸。 |
| `GripDotRadius` | `float` | 拖拽握柄圆点半径。 |
| `ShowDraggerGrip` | `bool` | 是否绘制默认握柄。 |
| `SplitBarColor` | `SKColor` | 分隔条默认颜色。 |
| `SplitBarHoverColor` | `SKColor` | 分隔条悬浮颜色。 |
| `SplitBarActiveColor` | `SKColor` | 分隔条激活颜色。 |
| `DraggerHandleColor` | `SKColor` | 中央把手背景色。 |
| `DraggerHandleHoverColor` | `SKColor` | 中央把手悬浮背景色。 |
| `DraggerHandleActiveColor` | `SKColor` | 中央把手激活背景色。 |
| `DraggerIconColor` | `SKColor` | 折叠按钮和握柄图标颜色。 |
| `CollapseButtonHoverColor` | `SKColor` | 折叠按钮悬浮背景色。 |
| `LazyPreviewColor` | `SKColor` | 懒更新预览线颜色。 |
| `ResizeStarted` | `event Action<float[]>?` | 开始拖拽时触发。 |
| `ResizeStartedAsync` | `event Func<float[], Task>?` | 开始调整面板大小时触发的异步回调。 |
| `OnResizeStart` | `Action<float[]>?` | 开始拖拽回调。 |
| `OnResizeStartAsync` | `Func<float[], Task>?` | 开始调整面板大小时触发的异步回调。 |
| `ResizeChanged` | `event Action<float[]>?` | 面板尺寸发生变化时触发。 |
| `ResizeChangedAsync` | `event Func<float[], Task>?` | 调整面板大小时触发的异步回调。 |
| `OnResize` | `Action<float[]>?` | 尺寸变化回调。 |
| `OnResizeAsync` | `Func<float[], Task>?` | 调整面板大小时触发的异步回调。 |
| `ResizeEnded` | `event Action<float[]>?` | 拖拽结束时触发。 |
| `ResizeEndedAsync` | `event Func<float[], Task>?` | 结束调整面板大小时触发的异步回调。 |
| `OnResizeEnd` | `Action<float[]>?` | 拖拽结束回调。 |
| `OnResizeEndAsync` | `Func<float[], Task>?` | 结束调整面板大小时触发的异步回调。 |
| `CollapseChanged` | `event Action<bool[], float[]>?` | 面板折叠状态变化时触发。 |
| `CollapseChangedAsync` | `event Func<bool[], float[], Task>?` | 面板折叠状态变化时触发的异步回调。 |
| `OnCollapse` | `Action<bool[], float[]>?` | 折叠状态变化回调。 |
| `OnCollapseAsync` | `Func<bool[], float[], Task>?` | 面板折叠状态变化时触发的异步回调。 |
| `DraggerDoubleClicked` | `event Action<int>?` | 双击拖拽条时触发。 |
| `DraggerDoubleClickedAsync` | `event Func<int, Task>?` | 分隔条被双击时触发的异步回调。 |
| `OnDraggerDoubleClick` | `Action<int>?` | 双击拖拽条回调。 |
| `OnDraggerDoubleClickAsync` | `Func<int, Task>?` | 分隔条被双击时触发的异步回调。 |
| `Sizes` | `float[]` | 当前面板尺寸快照。 |
| `CollapsedStates` | `bool[]` | 当前折叠状态快照。 |

## 方法

### GetSizes()

```csharp
float[] GetSizes()
```

返回当前各面板尺寸快照。

### GetCollapsedStates()

```csharp
bool[] GetCollapsedStates()
```

返回当前折叠状态快照。

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

### OnPointerDown(float, float)

```csharp
void OnPointerDown(float x, float y)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnPointerMove(float, float)

```csharp
void OnPointerMove(float x, float y)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnPointerUp(float, float)

```csharp
void OnPointerUp(float x, float y)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnTouchEvent(UITouchEvent)

```csharp
void OnTouchEvent(UITouchEvent e)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UITouchEvent` |  |

## 相关类型

### SplitterOrientation

> **类型**：枚举

Splitter 的布局方向。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Horizontal` | - | 水平方向，面板从左到右排列。 |
| `Vertical` | - | 垂直方向，面板从上到下排列。 |
