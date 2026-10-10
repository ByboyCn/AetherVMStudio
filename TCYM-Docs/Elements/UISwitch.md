# UISwitch

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIElement`

## 概述

UISwitch 开关组件（类似 antd Switch）。 - 支持 Checked/DefaultChecked - 支持 CheckedChildren / UnCheckedChildren（string 或 UIElement） - 支持 CheckedStyle/CheckedClass 与 UnCheckedStyle/UnCheckedClass - 支持 CheckedElement/UnCheckedElement（自定义工厂） - 支持 OnChange 回调

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `SwitchContent` | `struct` | 内容类型：支持 string 或 UIElement（类似 UnitValue 的 struct 形式）。 |
| `Checked` | `bool` |  |
| `DefaultChecked` | `bool` | 初始是否选中。 |
| `Disabled` | `bool` | 是否禁用（禁用时不可交互并置灰）。 |
| `CheckedChildren` | `SwitchContent` | 选中时内容（string 或 UIElement）。 |
| `UnCheckedChildren` | `SwitchContent` | 未选中时内容（string 或 UIElement）。 |
| `RenderChildrenContent` | `bool` | 是否绘制 CheckedChildren/UnCheckedChildren 内容。 |
| `CheckedStyle` | `DefaultUIStyle?` | 选中时样式（优先于 CheckedClass）。 |
| `CheckedClass` | `string?` | 选中时 Class 样式（被 CheckedStyle 覆盖）。 |
| `UnCheckedStyle` | `DefaultUIStyle?` | 未选中时样式（优先于 UnCheckedClass）。 |
| `UnCheckedClass` | `string?` | 未选中时 Class 样式（被 UnCheckedStyle 覆盖）。 |
| `CheckedElement` | `Func<UIElement?>?` | 选中时自定义元素工厂（优先于 CheckedChildren）。 |
| `UnCheckedElement` | `Func<UIElement?>?` | 未选中时自定义元素工厂（优先于 UnCheckedChildren）。 |
| `Changed` | `event Action<bool>?` | 变化事件。 |
| `ChangedAsync` | `event Func<bool, Task>?` | 开关状态变化时触发的异步回调。 |
| `OnChange` | `Action<bool>?` | 变化回调（初始化器中直接设置）。 |
| `OnChangeAsync` | `Func<bool, Task>?` | 开关状态变化时触发的异步回调。 |
| `TrackWidth` | `float` | 轨道宽度。 |
| `TrackHeight` | `float` | 轨道高度。 |
| `ThumbPadding` | `float` | 滑块内边距。 |
| `ThumbColor` | `SKColor` | 滑块颜色。 |
| `ThumbBackgroundColor` | `SKColor` | 白色圆颜色（滑块背景色）。 |
| `TrackColorUnchecked` | `SKColor` | 未选中轨道颜色（默认）。 |
| `TrackColorChecked` | `SKColor` | 选中轨道颜色（默认）。 |
| `ContentPadding` | `float` | 内容左右间距（绘制 CheckedChildren/UnCheckedChildren 时）。 |

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

鼠标事件：点击切换。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIMouseEvent` |  |

### Toggle()

```csharp
void Toggle()
```

切换选中状态。

### SetChecked(bool, bool)

```csharp
void SetChecked(bool value, bool triggerEvent = true)
```

设置选中状态。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `bool` |  |
| `triggerEvent` | `bool` |  |

### Render(SKCanvas)

```csharp
void Render(SKCanvas canvas)
```

渲染入口（应用状态样式后交由基类绘制）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `canvas` | `SKCanvas` |  |
