# UIColorPicker

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView, IDisposable, IUIElementDisposalPreflight`

## 概述

Ant Design 风格的颜色选择器。支持单色、线性渐变、透明度、预设色和 HEX/RGB/HSB 三种颜色文本格式。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Value` | `SKColor?` |  |
| `DefaultValue` | `SKColor` | 未显式设置 Value 时使用的初始颜色。 |
| `Format` | `ColorPickerFormat` |  |
| `DefaultFormat` | `ColorPickerFormat` | 默认颜色格式。 |
| `Mode` | `ColorPickerMode` | 当前选择模式。 |
| `AllowedModes` | `ColorPickerMode[]` | 面板中允许切换的模式。包含两个模式时会显示模式切换按钮。 |
| `GradientStops` | `List<ColorGradientStop>` | 渐变停靠点集合。 |
| `SelectedGradientStopIndex` | `int` | 当前选中的渐变停靠点。 |
| `AllowClear` | `bool` | 是否允许清除颜色。 |
| `DisabledAlpha` | `bool` | 是否禁用透明度滑轨。 |
| `DisabledFormat` | `bool` | 是否禁用颜色格式切换。 |
| `Disabled` | `bool` | 是否禁用控件。 |
| `DestroyOnHidden` | `bool` | 关闭面板后是否销毁弹层内容。 |
| `Arrow` | `bool` | 是否绘制指向触发器的面板箭头。 |
| `DestroyTooltipOnHide` | `bool` |  |
| `ShowText` | `bool` | 是否显示颜色文本。 |
| `TextFormatter` | `Func<SKColor?, string>?` | 自定义触发器文本。 |
| `Size` | `ColorPickerSize` | 触发器尺寸。 |
| `Trigger` | `ColorPickerTrigger` | 触发面板的交互方式。 |
| `Placement` | `ColorPickerPlacement` | 面板弹出位置。 |
| `Presets` | `List<ColorPickerPreset>` | 预设颜色组。 |
| `TriggerContent` | `UIElement?` | 自定义触发器内容；设置后替换默认色块与文本。 |
| `PanelRender` | `Func<UIElement, UIElement>?` | 自定义面板内容渲染器，参数为默认面板。 |
| `PopupStyle` | `UIStyle?` | 面板根容器的附加样式。 |
| `Open` | `bool` | 当前面板是否打开。 |
| `CssValue` | `string` | 当前值的 CSS 表示。 |
| `Changed` | `event Action<SKColor?, string>?` | 颜色或渐变值实时变化时触发，并返回颜色与 CSS 表示。 |
| `ChangedAsync` | `event Func<SKColor?, string, Task>?` | 颜色值变化时触发的异步回调。 |
| `OnChange` | `Action<SKColor?, string>?` | 注册颜色实时变化回调的便捷属性。 |
| `OnChangeAsync` | `Func<SKColor?, string, Task>?` | 颜色值变化时触发的异步回调。 |
| `ChangeCompleted` | `event Action<SKColor?>?` | 一次鼠标或触摸调整完成时触发。 |
| `ChangeCompletedAsync` | `event Func<SKColor?, Task>?` | 颜色修改完成时触发的异步回调。 |
| `OnChangeComplete` | `Action<SKColor?>?` | 注册颜色调整完成回调的便捷属性。 |
| `OnChangeCompleteAsync` | `Func<SKColor?, Task>?` | 颜色修改完成时触发的异步回调。 |
| `FormatChanged` | `event Action<ColorPickerFormat>?` | 颜色文本格式发生变化时触发。 |
| `FormatChangedAsync` | `event Func<ColorPickerFormat, Task>?` | 颜色格式变化时触发的异步回调。 |
| `OnFormatChange` | `Action<ColorPickerFormat>?` | 注册格式变化回调的便捷属性。 |
| `OnFormatChangeAsync` | `Func<ColorPickerFormat, Task>?` | 颜色格式变化时触发的异步回调。 |
| `OpenChanged` | `event Action<bool>?` | 弹出面板打开状态发生变化时触发。 |
| `OpenChangedAsync` | `event Func<bool, Task>?` | 颜色选择面板打开状态变化时触发的异步回调。 |
| `OnOpenChange` | `Action<bool>?` | 注册面板打开状态变化回调的便捷属性。 |
| `OnOpenChangeAsync` | `Func<bool, Task>?` | 颜色选择面板打开状态变化时触发的异步回调。 |
| `Cleared` | `event Action?` | 用户清除当前颜色后触发。 |
| `ClearedAsync` | `event Func<Task>?` | 颜色值清除时触发的异步回调。 |
| `OnClear` | `Action?` | 注册颜色清除回调的便捷属性。 |
| `OnClearAsync` | `Func<Task>?` | 颜色值清除时触发的异步回调。 |

## 方法

### Update(float)

```csharp
void Update(float deltaTime)
```

更新悬停关闭计时，并在面板打开时持续同步弹层位置。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaTime` | `float` | 距上一帧经过的秒数。 |

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

测量触发器尺寸。布局阶段会把已经排版过的 auto 宽度临时写回元素， 因此每轮测量前需要重新释放它，确保 RGB、HSB 或自定义文本变化后宽度能继续自适应。 显式设置的数值宽度不受影响。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` |  |
| `availableHeight` | `float` |  |

### Clear()

```csharp
void Clear()
```

清除当前颜色。

### VerifyCanDispose()

```csharp
void VerifyCanDispose()
```

释放挂载到 Root 的颜色面板，并解除触发器事件和 UIManager 的闭包引用。
无副作用地验证挂载在 Root 上的颜色面板子树允许拥有型释放。

### Dispose()

```csharp
void Dispose()
```

## 相关类型

### ColorGradientStop

> **类型**：类

渐变色中的一个颜色停靠点。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Color` | `SKColor` | 停靠点颜色。 |
| `Position` | `float` | 停靠点位置，范围为 0 到 1。 |

### ColorPickerFormat

> **类型**：枚举

颜色选择器显示与输出的颜色格式。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Hex` | - | 十六进制颜色格式。 |
| `Rgb` | - | RGB 或 RGBA 颜色格式。 |
| `Hsb` | - | HSB 颜色格式。 |

### ColorPickerMode

> **类型**：枚举

颜色选择器的工作模式。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Single` | - | 选择单个颜色。 |
| `Gradient` | - | 编辑线性渐变及其颜色停靠点。 |

### ColorPickerPlacement

> **类型**：枚举

颜色面板相对触发器的位置。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `TopLeft` | - | 面板位于触发器上方并左对齐。 |
| `Top` | - | 面板位于触发器上方并居中。 |
| `TopRight` | - | 面板位于触发器上方并右对齐。 |
| `BottomLeft` | - | 面板位于触发器下方并左对齐。 |
| `Bottom` | - | 面板位于触发器下方并居中。 |
| `BottomRight` | - | 面板位于触发器下方并右对齐。 |

### ColorPickerPreset

> **类型**：类

一组可折叠展示的预设颜色。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Label` | `string` | 预设组标题。 |
| `DefaultOpen` | `bool` | 是否默认展开。 |
| `Key` | `string?` | 预设组的稳定键。 |
| `Colors` | `List<SKColor>` | 预设颜色。 |

### ColorPickerSize

> **类型**：枚举

颜色选择器触发器尺寸。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Small` | - | 小尺寸触发器。 |
| `Medium` | - | 中等尺寸触发器。 |
| `Large` | - | 大尺寸触发器。 |

### ColorPickerTrigger

> **类型**：枚举

打开颜色面板的触发方式。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Click` | - | 单击触发器时打开或关闭面板。 |
| `Hover` | - | 鼠标悬停时打开面板。 |
