# UISlider

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIElement`

## 概述

UISlider 滑动输入条组件（参考 Ant Design Slider）。 支持： - 单值/范围（Range）模式 - 刻度标记（Marks）与刻度点（Dots） - 步长（Step）、最小值（Min）、最大值（Max） - 拖拽时的数值气泡（Tooltip） - 禁用状态（Disabled） - 垂直模式（Vertical） - 反向（Reverse） - 动画过渡

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Value` | `float` |  |
| `DefaultValue` | `float` | 默认值（首次测量时应用）。 |
| `Range` | `bool` | 是否为范围选择模式。 |
| `RangeStart` | `float` |  |
| `RangeEnd` | `float` |  |
| `DefaultRange` | `float[]?` | 默认范围值 [start, end]。 |
| `Min` | `float` | 最小值。 |
| `Max` | `float` | 最大值。 |
| `Step` | `float?` | 步长，null 表示只能选择 Marks 标记位置。 |
| `Disabled` | `bool` | 是否禁用。 |
| `Vertical` | `bool` | 是否垂直方向。 |
| `Reverse` | `bool` | 反向坐标轴。 |
| `Included` | `bool` | marks 不为空对象时有效，值为 true 时表示值为包含关系（默认）， false 表示并列关系（不高亮区间）。 |
| `Dots` | `bool` | 是否只能拖拽到刻度上（当 Marks 非空时）。 |
| `TooltipVisible` | `bool?` | 是否显示 Tooltip。null 表示仅拖拽时显示。 |
| `TipFormatter` | `Func<float, string>?` | Tooltip 格式化函数。null 则隐藏 Tooltip。 |
| `Marks` | `Dictionary<float, string>?` | 刻度标记。key 为值，value 为显示文本。 |
| `RailColor` | `SKColor` | 轨道背景色。 |
| `RailHoverColor` | `SKColor` | 轨道背景色（悬浮）。 |
| `TrackColor` | `SKColor` | 已选区域颜色。 |
| `TrackHoverColor` | `SKColor` | 已选区域颜色（悬浮）。 |
| `HandleColor` | `SKColor` | 滑块颜色（填充）。 |
| `HandleBorderColor` | `SKColor` | 滑块边框颜色。 |
| `HandleActiveColor` | `SKColor` | 滑块激活态边框色。 |
| `HandleDisabledColor` | `SKColor` | 滑块禁用态颜色。 |
| `DotBorderColor` | `SKColor` | 刻度点边框色。 |
| `DotActiveBorderColor` | `SKColor` | 刻度点激活边框色。 |
| `TrackDisabledColor` | `SKColor` | 禁用时轨道背景色。 |
| `MarkTextColor` | `SKColor` | 标记文本颜色。 |
| `MarkTextActiveColor` | `SKColor` | 标记文本激活颜色。 |
| `TooltipBgColor` | `SKColor` | Tooltip 背景色。 |
| `TooltipTextColor` | `SKColor` | Tooltip 文本颜色。 |
| `TrackGradientColors` | `SKColor[]?` | 已选区域渐变色数组（沿轨道方向）。设置后优先于 TrackColor。 |
| `TrackGradientPositions` | `float[]?` | 已选区域渐变色位置（0~1），与 TrackGradientColors 等长。为 null 则均匀分布。 |
| `TrackHoverGradientColors` | `SKColor[]?` | 已选区域悬浮渐变色数组。设置后优先于 TrackHoverColor。 |
| `TrackHoverGradientPositions` | `float[]?` | 已选区域悬浮渐变色位置。 |
| `RailGradientColors` | `SKColor[]?` | 轨道背景渐变色数组（沿轨道方向）。设置后优先于 RailColor。 |
| `RailGradientPositions` | `float[]?` | 轨道背景渐变色位置。 |
| `RailSize` | `float` | 轨道高度/宽度。 |
| `RailRadius` | `float` | 轨道圆角半径。-1 表示自动（RailSize/2 全圆角），0 为直角。 |
| `HandleSize` | `float` | 滑块尺寸（直径）。 |
| `HandleSizeHover` | `float` | 滑块悬浮尺寸。 |
| `HandleBorderWidth` | `float` | 滑块边框宽度。 |
| `HandleShape` | `string` | 手柄形状："circle"（默认）或 "rect"（矩形带握纹）。 矩形手柄仅在垂直模式下生效。 |
| `HandleRectWidth` | `float` | 矩形手柄宽度（垂直模式下水平方向尺寸）。 |
| `HandleRectHeight` | `float` | 矩形手柄高度（垂直模式下垂直方向尺寸）。 |
| `HandleRectRadius` | `float` | 矩形手柄圆角。 |
| `HandleGripLines` | `int` | 矩形手柄握纹线数量。 |
| `HandleGripColor` | `SKColor` | 握纹线颜色。 |
| `DotSize` | `float` | 刻度点尺寸。 |
| `MarkFontSize` | `float` | 刻度文本字号。 |
| `TooltipFontSize` | `float` | Tooltip 字号。 |
| `TooltipRadius` | `float` | Tooltip 圆角。 |
| `TooltipPaddingH` | `float` | Tooltip 内边距水平。 |
| `TooltipPaddingV` | `float` | Tooltip 内边距垂直。 |
| `ShowRuler` | `bool` | 是否显示刻度尺（主/次刻度线 + 主刻度数字 + 当前值高亮）。 |
| `RulerMajorStep` | `float` | 刻度尺主刻度间隔。小于等于 0 时自动计算。 |
| `RulerMinorStep` | `float` | 刻度尺次刻度间隔。小于等于 0 时自动计算。 |
| `RulerMajorTickLength` | `float` | 主刻度线长度。 |
| `RulerMinorTickLength` | `float` | 次刻度线长度。 |
| `RulerTickColor` | `SKColor` | 刻度线颜色。 |
| `RulerTextColor` | `SKColor` | 刻度数字颜色。 |
| `RulerTextActiveColor` | `SKColor` | 当前值附近主刻度数字高亮色。 |
| `RulerFontSize` | `float` | 刻度数字字号。 |
| `RulerActiveScale` | `float` | 当前值附近主刻度文本放大倍率。 |
| `RulerGap` | `float` | 刻度尺与轨道之间的间距。 |
| `RulerPosition` | `string?` | 刻度尺显示在轨道的哪一侧 ("left" / "right" / "top" / "bottom")。 为 null 时自动选择：Vertical 模式默认 "left"，水平模式默认 "bottom"。 |
| `Changed` | `event Action<float>?` | 值改变时触发（拖拽过程中持续触发）。 |
| `ChangedAsync` | `event Func<float, Task>?` | 滑块值变化时触发的异步回调。 |
| `OnChange` | `Action<float>?` | 值改变回调（初始化器设置用）。 |
| `OnChangeAsync` | `Func<float, Task>?` | 滑块值变化时触发的异步回调。 |
| `RangeChanged` | `event Action<float, float>?` | 范围值改变时触发。 |
| `RangeChangedAsync` | `event Func<float, float, Task>?` | 范围滑块值变化时触发的异步回调。 |
| `OnRangeChange` | `Action<float, float>?` | 范围值改变回调。 |
| `OnRangeChangeAsync` | `Func<float, float, Task>?` | 范围滑块值变化时触发的异步回调。 |
| `ChangeCompleted` | `event Action<float>?` | 鼠标释放/键盘抬起时触发（最终提交值）。 |
| `ChangeCompletedAsync` | `event Func<float, Task>?` | 滑块值修改完成时触发的异步回调。 |
| `OnChangeComplete` | `Action<float>?` | 最终提交回调。 |
| `OnChangeCompleteAsync` | `Func<float, Task>?` | 滑块值修改完成时触发的异步回调。 |

## 方法

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

测量尺寸。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` |  |
| `availableHeight` | `float` |  |

### Update(float)

```csharp
void Update(float deltaSeconds)
```

更新动画。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` |  |

### OnMouseEvent(UIMouseEvent)

```csharp
void OnMouseEvent(UIMouseEvent e)
```

鼠标事件处理。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIMouseEvent` |  |

### OnTouchEvent(UITouchEvent)

```csharp
void OnTouchEvent(UITouchEvent e)
```

触摸事件处理：拖拽时标记 Handled 阻止父级 ScrollView 滚动。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UITouchEvent` |  |

### Render(SKCanvas)

```csharp
void Render(SKCanvas canvas)
```

渲染入口。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `canvas` | `SKCanvas` |  |


---

# UISlider

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`
