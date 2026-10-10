# UISelect

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView, IKeyboardFocusable, IDisposable, IUIElementDisposalPreflight`

## 概述

选择器组件，行为参考 Ant Design Select（简化版）。 支持：单选、multiple、tags，搜索，清除按钮，虚拟滚动，以及 OptionRender/tagRender。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Options` | `List<SelectOption>` |  |
| `OptionRender` | `Func<SelectOption, UISelect, UIElement>?` | 自定义选项渲染函数。 用于自定义每个选项的显示方式。 参数：(选项数据, UISelect实例) => 自定义UI元素 |
| `DefaultValue` | `object?` | 默认选中值。 仅在初始化时生效；如果后续需要动态更改，请设置 Value/Values 属性。 |
| `Value` | `object?` |  |
| `Values` | `List<object?>` |  |
| `Mode` | `SelectMode` | 选择器模式。 - Default: 单选模式 - Multiple: 多选模式 - Tags: 标签模式（允许输入自定义值） |
| `IsShowClose` | `bool` | 当Model 为 Multiple 或 Tags 时，是否在下拉菜单中显示关闭图标以移除选中项。 |
| `Disabled` | `bool` | 是否禁用选择器。 禁用时不可交互，样式变灰。 |
| `AllowClear` | `bool` | 是否显示清除按钮。 为 true 时，鼠标悬停且有选中值时会显示清除图标。 |
| `MaxCount` | `int?` | 最大可选数量（仅多选/标签模式有效）。 达到最大数量后无法再选择新的选项。 |
| `MaxTagCount` | `int?` | 最大显示标签数量（仅多选/标签模式有效）。 超过此数量的标签会显示为 "+N" 的形式。 |
| `VirtualScroll` | `bool` | 是否启用虚拟滚动。 当选项数量很多时，开启虚拟滚动可以提升性能。 |
| `ShowSearch` | `bool` | 是否显示搜索输入框。 开启后可以在下拉菜单中搜索过滤选项。 |
| `OptionBackgroundColor` | `SKColor` | 选项背景颜色。 |
| `DropdownScrollbarWidth` | `float` | 滚动条厚度（像素），既用于垂直滚动条宽度，也用于水平滚动条高度。 |
| `DropdownScrollbarTrackColor` | `SKColor` | 下拉框滚动条轨道颜色（背景条）。 |
| `DropdownScrollbarThumbColor` | `SKColor` | 下拉框滚动条滑块颜色（前景条）。 |
| `DropdownScrollbarRadius` | `float` | 下拉框滚动条圆角半径（像素）。 |
| `FocusSelectStyle` | `UpdateUIStyle` | 默认聚焦样式。 |
| `TagRender` | `Func<SelectOption, UISelect, UIElement>?` | 自定义标签渲染函数（仅多选/标签模式有效）。 用于自定义已选中项的标签显示方式。 参数：(选项数据, UISelect实例) => 自定义UI元素 |
| `Placeholder` | `string` | 占位符文本。 当没有选中值时显示此文本。 |
| `PlaceholderColor` | `SKColor` | 占位符文本颜色。 |
| `SelectedValue` | `object?` | 当前选中值（单选模式的便捷属性，等同于 Value）。 设置后会自动刷新UI。 |
| `SelectStyle` | `UpdateUIStyle?` | 选中条目的样式（应用到下拉菜单中的选中项）。 |
| `DefaultItemStyle` | `UpdateUIStyle?` | 默认条目的样式（应用到下拉菜单中的未选中项）。 |
| `DisabledSelectStyle` | `UpdateUIStyle` | 禁用状态的默认样式。 边框变灰，光标变为禁止符号。 |
| `SelectTagStyle` | `UIStyle?` | 多选时Multiple 选中样式。 都是UITag组件的样式。 |
| `SelectTagIconStyle` | `UIStyle?` | 多选时Multiple 选中图标样式。 都是UITag组件的图标样式。 |
| `DropdownStyle` | `UIStyle` | 下拉面板默认样式。 |
| `SearchInputStyle` | `UIStyle` | search 输入框样式。 |
| `Style` | `UIStyle?` | 元素样式。设置时会合并类名样式（如有）并应用到元素。 |
| `OnOpenChange` | `Action<bool>?` | 下拉菜单显示状态改变时触发。 参数：true=打开，false=关闭 |
| `OnOpenChangeAsync` | `Func<bool, Task>?` | 下拉面板打开状态变化时触发的异步回调。 |
| `OnFocus` | `Action?` | 获得焦点时触发。 |
| `OnFocusAsync` | `Func<Task>?` | 选择器获得焦点时触发的异步回调。 |
| `OnPopupScroll` | `Action<float, float>?` | 下拉菜单滚动时触发。 参数：(scrollY, scrollX) |
| `OnPopupScrollAsync` | `Func<float, float, Task>?` | 下拉面板滚动时触发的异步回调。 |
| `OnSelect` | `Action<SelectOption>?` | 选中选项时触发。 参数：被选中的选项 |
| `OnSelectAsync` | `Func<SelectOption, Task>?` | 选中选项时触发的异步回调。 |
| `DropdownMinHeight` | `float` | 获取或设置下拉框最小高度。 |
| `DropdownMaxHeight` | `float` | 获取或设置下拉框最大高度。 |
| `OptionItemHeight` | `float?` | 自定义选项高度（像素），用于 OptionRender 场景。 如果为 null，则使用默认高度 22px。 |

## 方法

### Focus()

```csharp
void Focus()
```

使选择器获得焦点。 会触发 OnFocus 事件并更新边框颜色为焦点状态。

### Blur()

```csharp
void Blur()
```

使选择器失去焦点。 会恢复边框颜色并关闭下拉菜单。

### VerifyCanDispose()

```csharp
void VerifyCanDispose()
```

释放挂载到 Root 的下拉弹层，并解除 UIManager 保存的命中测试闭包。
无副作用地验证挂载在 Root 上的下拉选项子树允许拥有型释放。

### Dispose()

```csharp
void Dispose()
```

## 相关类型

### SelectMode

> **类型**：枚举

Select 组件的模式枚举。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Default` | - | 默认单选模式。 |
| `Multiple` | - | 多选模式，允许选择多个选项。 |
| `Tags` | - | 标签模式，允许选择多个选项并以标签形式显示。 |

### SelectOption

> **类型**：类

选择器选项数据模型，类似 Ant Design Select 的 Option。 支持基础属性和自定义字段扩展。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Value` | `object?` | 选项的值，用于唯一标识和筛选。支持任意类型（int、string 等）。 |
| `Label` | `string` | 选项显示的标签文本。 |
| `Title` | `string?` | 鼠标悬停时显示的提示文本。 |
| `Disabled` | `bool` | 是否禁用该选项。禁用后不可选择。 |
| `CustomFields` | `Dictionary<string, object?>` | 自定义扩展字段字典，用于存储如 desc、iconstr 等额外数据。 |
