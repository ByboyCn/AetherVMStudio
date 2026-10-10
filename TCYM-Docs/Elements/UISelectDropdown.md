# UISelectDropdown

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

UISelect 的下拉面板组件。 支持虚拟滚动、搜索过滤、动态数据源、选中状态管理和滚动回调。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `VirtualScroll` | `bool` | 是否启用虚拟滚动。 当选项数量很多时，开启虚拟滚动可以显著提升性能。 默认为 true。 |
| `DefaultItemStyle` | `UpdateUIStyle?` | 默认选项样式（应用到未选中的选项）。 由 UISelect 注入。 |
| `SelectedItemStyle` | `UpdateUIStyle?` | 选中项样式（应用到已选中的选项）。 由 UISelect 注入。 |
| `SearchInputStyle` | `UIStyle?` | search 输入框样式。 |
| `OptionRender` | `Func<SelectOption, UISelect, UIElement>?` | 自定义选项渲染函数。 用于自定义每个选项的显示方式。 参数：(选项数据, UISelect实例) => 自定义UI元素 |
| `Owner` | `UISelect?` | 所属的 UISelect 组件引用。 用于获取配置信息和触发事件。 |
| `DropdownScrollbarWidth` | `float` | 滚动条厚度（像素），既用于垂直滚动条宽度，也用于水平滚动条高度。 |
| `DropdownScrollbarTrackColor` | `SKColor` | 滚动条轨道颜色（背景条）。 |
| `DropdownScrollbarThumbColor` | `SKColor` | 滚动条滑块颜色（前景条）。 |
| `DropdownScrollbarRadius` | `float` | 滚动条圆角半径（像素）。 |
| `OnSearchTextChanged` | `event Action<string>?` | 搜索文本变化时触发。 由 UISelect 监听并处理选项过滤。 参数：当前搜索文本 |
| `OnSearchTextChangedAsync` | `event Func<string, Task>?` | 搜索文本变化时触发的异步事件。 |
| `OnPopupScroll` | `event Action<float, float>?` | 下拉面板滚动时触发。 参数：(scrollY, scrollX) |
| `OnPopupScrollAsync` | `event Func<float, float, Task>?` | 下拉面板滚动时触发的异步事件。 |
| `OnSelect` | `event Action<SelectOption>?` | 选项被点击选中时触发。 参数：被选中的选项 |
| `OnSelectAsync` | `event Func<SelectOption, Task>?` | 选中选项时触发的异步事件。 |
| `OptionItemHeight` | `float?` | 自定义选项高度（像素），用于 OptionRender 场景。 如果为 null，则使用默认高度 22px。 |
| `MaxCountReached` | `bool` | 是否已达到最大可选数量。 为 true 时，未选中的选项会显示为不可选状态（NotAllowed 光标）。 |

## 方法

### SetShowSearch(bool)

```csharp
void SetShowSearch(bool show)
```

设置是否显示搜索框。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `show` | `bool` | true=显示，false=隐藏 |

### SetSearchText(string?)

```csharp
void SetSearchText(string? text)
```

设置搜索框的文本内容。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `text` | `string?` | 搜索文本 |

### SetOptions(IEnumerable<SelectOption>?)

```csharp
void SetOptions(IEnumerable<SelectOption>? options)
```

设置选项列表数据。 会触发完整的重建流程。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `options` | `IEnumerable<SelectOption>?` | 选项列表，可以为 null |

### SetSelectedValues(IEnumerable<object?>?)

```csharp
void SetSelectedValues(IEnumerable<object?>? values)
```

设置当前选中的值集合。 用于更新选项的选中状态样式。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `values` | `IEnumerable<object?>?` | 选中值的集合，可以为 null |

### Rebuild()

```csharp
void Rebuild()
```

重建下拉面板内容。 根据 VirtualScroll 属性决定使用虚拟滚动还是普通渲染模式。

## 相关类型

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
