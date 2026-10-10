# UISegmented

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

Segmented 分段选择器。 参考 Ant Design Segmented 的交互模型， 支持字符串或自定义 UIElement 作为选项内容。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Change` | `event Action<object?>?` | 当前值变化时触发。 |
| `ChangeAsync` | `event Func<object?, Task>?` | 分段控件值变化时触发的异步回调。 |
| `SelectionChanged` | `event Action<int, UISegmentedOption>?` | 当前选项变化时触发，参数依次为索引和选项对象。 |
| `SelectionChangedAsync` | `event Func<int, UISegmentedOption, Task>?` | 分段选中项变化时触发的异步回调。 |
| `Style` | `UIStyle?` | 容器样式。外部赋值时会保留 Segmented 所需的默认 flex 布局， 避免仅设置宽度等属性时把内部轨道布局覆盖成普通 block 容器。 |
| `Options` | `List<object?>` | 选项列表。 支持 string、UIElement 或 UISegmentedOption。 |
| `DefaultValue` | `object?` | 默认选中值。仅在 Value 为空时参与初始选择。 |
| `Value` | `object?` |  |
| `SelectedIndex` | `int` | 当前选中项索引，未选中时为 -1。 |
| `SelectedOption` | `UISegmentedOption?` | 当前选中项。 |
| `Block` | `bool` | 是否启用 block 模式。 打开后每个分段会均分剩余宽度。 |
| `Disabled` | `bool` | 是否禁用整个组件。 |
| `TrackPadding` | `float` | 轨道内边距。 |
| `SegmentGap` | `float` | 分段之间的间距。 |
| `ItemHeight` | `float` | 单个分段高度。 |
| `ItemHorizontalPadding` | `float` | 分段左右内边距。 |
| `ItemVerticalPadding` | `float` | 分段上下内边距。 |
| `FontSize` | `float` | 分段文本字号。 |
| `SelectionAnimationDuration` | `float` | 选中滑块滑动动画时长，单位为秒；设置为 0 时禁用动画并直接切换。 |
| `SelectionAnimationTimingFunction` | `string` | 选中滑块滑动动画的缓动函数名称，支持 linear、ease-out、ease-in-out、ease-out-cubic 等。 |
| `ItemStyle` | `UpdateUIStyle?` | 所有分段共用的常规态增量样式。 |
| `SelectedItemStyle` | `UpdateUIStyle?` | 所有分段共用的选中态增量样式。 |
| `OnChange` | `Action<object?>?` | 便捷订阅 Change 事件。 |
| `OnChangeAsync` | `Func<object?, Task>?` | 分段控件值变化时触发的异步回调。 |
| `OnSelectionChanged` | `Action<int, UISegmentedOption>?` | 便捷订阅 SelectionChanged 事件。 |
| `OnSelectionChangedAsync` | `Func<int, UISegmentedOption, Task>?` | 分段选中项变化时触发的异步回调。 |

## 方法

### SelectIndex(int)

```csharp
void SelectIndex(int index)
```

按索引切换选中项。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `index` | `int` |  |

### Update(float)

```csharp
void Update(float deltaSeconds)
```

推进选中滑块动画，再更新基类及其子元素状态。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` |  |

### HasActiveAnimation()

```csharp
bool HasActiveAnimation()
```

滑块过渡是自定义动画状态，需要让框架"活动动画"机制感知， 否则主循环可能在最后几帧停止唤醒，导致动画停在收尾位置。

### Layout(float, float, float, float)

```csharp
void Layout(float x, float y, float width, float height)
```

布局完成后同步选中滑块的目标位置，首次布局直接到位，后续选择切换时执行滑动动画。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |
| `width` | `float` |  |
| `height` | `float` |  |
