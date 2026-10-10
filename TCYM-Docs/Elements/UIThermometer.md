# UIThermometer

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIElement`

## 概述

UIThermometer 温度计滑块组件。 仿 CodePen 温度计效果：深色胶囊容器、霓虹发光轨道、玻璃质感手柄、 左侧刻度尺（长/短刻度线 + 数字）、底部大号发光温度值显示。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Value` | `float` | 当前温度值。 |
| `DefaultValue` | `float` | 默认值。 |
| `Min` | `float` | 最小值。 |
| `Max` | `float` | 最大值。 |
| `Step` | `float` | 步长。 |
| `MajorStep` | `float` | 主刻度间隔（显示数字）。 |
| `MinorStep` | `float` | 次刻度间隔（短线）。 |
| `Disabled` | `bool` | 是否禁用。 |
| `Unit` | `string` | 温度单位后缀（如 "°" 或 "°F"）。 |
| `Formatter` | `Func<float, string>?` | 值格式化函数。 |
| `GlowColor` | `SKColor` | 发光色 / 轨道填充色（霓虹色）。 |
| `CapsuleColor` | `SKColor` | 容器外壳背景色。 |
| `CapsuleBorderColor` | `SKColor` | 容器外壳边框色。 |
| `TrackEmptyColor` | `SKColor` | 轨道空白区域色（胶囊内部未填充）。 |
| `TickColor` | `SKColor` | 刻度线颜色。 |
| `TickTextColor` | `SKColor` | 刻度文本颜色。 |
| `TickTextActiveColor` | `SKColor` | 当前值附近刻度文本高亮色。 |
| `ValueTextColor` | `SKColor` | 底部数值文本颜色（与 GlowColor 同色）。 |
| `CapsuleWidth` | `float` | 胶囊宽度。 |
| `HandleDiameter` | `float` | 手柄直径。 |
| `TrackWidth` | `float` | 轨道宽度（胶囊内部发光条）。 |
| `MajorTickLength` | `float` | 主刻度线长度。 |
| `MinorTickLength` | `float` | 次刻度线长度。 |
| `TickFontSize` | `float` | 刻度文本字号。 |
| `ValueFontSize` | `float` | 底部温度值字号。 |
| `ValueAreaHeight` | `float` | 底部温度值高度区域。 |
| `GlowRadius` | `float` | 发光模糊半径。 |
| `HandleGlowRadius` | `float` | 手柄发光半径。 |
| `Changed` | `event Action<float>?` | 值改变事件。 |
| `ChangedAsync` | `event Func<float, Task>?` | 温度计值变化时触发的异步回调。 |
| `OnChange` | `Action<float>?` | 值改变回调。 |
| `OnChangeAsync` | `Func<float, Task>?` | 温度计值变化时触发的异步回调。 |
| `ChangeCompleted` | `event Action<float>?` | 拖拽完成事件。 |
| `ChangeCompletedAsync` | `event Func<float, Task>?` | 温度计值修改完成时触发的异步回调。 |
| `OnChangeComplete` | `Action<float>?` | 拖拽完成回调。 |
| `OnChangeCompleteAsync` | `Func<float, Task>?` | 温度计值修改完成时触发的异步回调。 |

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

鼠标事件。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIMouseEvent` |  |

### Render(SKCanvas)

```csharp
void Render(SKCanvas canvas)
```

渲染入口。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `canvas` | `SKCanvas` |  |
