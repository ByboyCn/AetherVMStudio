# UITreeSelect

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView, IKeyboardFocusable, IDisposable, IUIElementDisposalPreflight`

## 概述

Ant Design 风格的树选择器。触发器负责值回填、搜索和弹层生命周期， 弹层中的树形交互由同一个 <see cref="UITree"/> 实例提供。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `RootClassName` | `string` | 根元素建议使用的语义 CSS 类名。 |
| `TriggerClassName` | `string` | 触发器正文的语义 CSS 类名。 |
| `PopupClassName` | `string` | 弹出面板的语义 CSS 类名。 |
| `SearchClassName` | `string` | 搜索区域的语义 CSS 类名。 |
| `TreeClassName` | `string` | 弹层内 UITree 的语义 CSS 类名。 |
| `TagClassName` | `string` | 多选回填标签的语义 CSS 类名。 |
| `EmptyClassName` | `string` | 无匹配数据区域的语义 CSS 类名。 |
| `Style` | `UIStyle?` | 元素样式。赋值 <see cref="UpdateUIStyle"/> 时在当前 TreeSelect 样式上增量合并。 |
| `TreeData` | `IList<TreeNode>` | 树形数据；每个节点的 <see cref="TreeNode.Value"/> 在整棵树中必须唯一。 |
| `Tree` | `UITree` | 弹层中实际使用的 <see cref="UITree"/> 实例。 |
| `Value` | `string?` |  |
| `Values` | `string[]` |  |
| `DefaultValue` | `string?` | 调用方未显式设置 Value/Values 时使用的单个初始值。 |
| `DefaultValues` | `string[]` | 调用方未显式设置 Value/Values 时使用的初始值列表。 |
| `Multiple` | `bool` | 是否允许选择多个树节点。 |
| `TreeCheckable` | `bool` | 是否在树节点前显示 Checkbox；启用后自动进入多选模式。 |
| `TreeCheckStrictly` | `bool` | Checkbox 是否严格独立；true 时父子节点不联动。 |
| `ShowCheckedStrategy` | `TreeSelectShowCheckedStrategy` | 可勾选模式下，触发器中已选节点的回填方式。 |
| `TreeDefaultExpandAll` | `bool` | 树是否默认展开全部节点。 |
| `TreeDefaultExpandedKeys` | `string[]` | 调用方未显式设置 ExpandedKeys 时使用的初始展开节点。 |
| `ExpandedKeys` | `string[]` | 当前展开节点；程序化赋值不会触发 OnExpand。 |
| `TreeShowLine` | `bool` | 是否显示树连接线。 |
| `TreeIndentSize` | `float` | 树节点缩进大小（逻辑像素）。 |
| `TreeNodeHeight` | `float` | 树节点行高（逻辑像素）。 |
| `SwitcherIcon` | `Func<TreeNode, bool, UIIcon>?` | 自定义 UITree 展开/折叠图标。 |
| `ShowSearch` | `bool` | 是否显示搜索输入框；未显式设置时，多选/可勾选模式默认为 true。 |
| `SearchValue` | `string` |  |
| `FilterTreeNode` | `Func<string, TreeNode, bool>?` | 自定义节点过滤器；为空时匹配 Label 或 Value，忽略大小写。 |
| `AutoClearSearchValue` | `bool` | 多选后是否自动清空搜索文本。 |
| `AllowClear` | `bool` | 是否显示清除按钮。 |
| `Disabled` | `bool` | 是否禁用全部交互。 |
| `Size` | `TreeSelectSize` | 触发器尺寸。 |
| `Variant` | `TreeSelectVariant` | 触发器视觉变体。 |
| `Status` | `TreeSelectStatus` | 触发器校验状态。 |
| `Placement` | `TreeSelectPlacement` | 树面板弹出位置。 |
| `Placeholder` | `string` | 没有选中值时显示的占位文本。 |
| `PlaceholderColor` | `SKColor` | 占位文本颜色。 |
| `SearchPlaceholder` | `string` | 搜索输入框占位文本。 |
| `NotFoundContent` | `string` | 搜索无匹配节点时显示的文本。 |
| `SuffixIcon` | `string` | 触发器后缀图标内容。 |
| `MaxTagCount` | `int?` | 最多显示的回填标签数量；null 表示不限制。 |
| `MaxTagTextLength` | `int?` | 单个回填标签的最大文本长度；null 表示不截断。 |
| `TagRender` | `Func<TreeNode, UITreeSelect, UIElement>?` | 自定义多选回填标签。 |
| `Open` | `bool` |  |
| `DefaultOpen` | `bool` | 调用方未显式设置 Open 时使用的初始打开状态。 |
| `PopupMatchSelectWidth` | `bool` | 弹层是否与触发器等宽。 |
| `PopupWidth` | `float?` | 显式弹层宽度；null 时由 PopupMatchSelectWidth 决定。 |
| `PopupHeight` | `float` | 弹层高度（逻辑像素）。 |
| `PopupStyle` | `UIStyle?` | 弹层附加样式。 |
| `TreeStyle` | `UIStyle?` | 内置 UITree 的附加样式。 |
| `SearchInputStyle` | `UIStyle?` | 搜索输入框附加样式。 |
| `EffectiveMultiple` | `bool` | 是否处于多选语义；TreeCheckable=true 时始终为 true。 |
| `OnChange` | `Action<string[], TreeNode[]>?` | 选择结果变化时触发；参数为全部值和对应的原始树节点。 |
| `OnChangeAsync` | `Func<string[], TreeNode[], Task>?` | 选择结果变化时触发的异步回调。 |
| `OnSelect` | `Action<string, TreeNode>?` | 用户选中节点时触发。 |
| `OnSelectAsync` | `Func<string, TreeNode, Task>?` | 用户选中节点时触发的异步回调。 |
| `OnDeselect` | `Action<string, TreeNode>?` | 用户取消选中节点时触发。 |
| `OnDeselectAsync` | `Func<string, TreeNode, Task>?` | 用户取消选中节点时触发的异步回调。 |
| `OnSearch` | `Action<string>?` | 搜索文本变化时触发。 |
| `OnSearchAsync` | `Func<string, Task>?` | 搜索文本变化时触发的异步回调。 |
| `OnOpenChange` | `Action<bool>?` | 面板打开状态变化时触发。 |
| `OnOpenChangeAsync` | `Func<bool, Task>?` | 面板打开状态变化时触发的异步回调。 |
| `OnClear` | `Action?` | 用户清空选择时触发。 |
| `OnClearAsync` | `Func<Task>?` | 用户清空选择时触发的异步回调。 |
| `OnFocus` | `Action?` | 组件获得焦点时触发。 |
| `OnFocusAsync` | `Func<Task>?` | 组件获得焦点时触发的异步回调。 |
| `OnBlur` | `Action?` | 组件失去焦点时触发。 |
| `OnBlurAsync` | `Func<Task>?` | 组件失去焦点时触发的异步回调。 |
| `OnExpand` | `Action<string[], TreeNode, bool>?` | 树节点展开状态变化时触发。 |
| `OnExpandAsync` | `Func<string[], TreeNode, bool, Task>?` | 树节点展开状态变化时触发的异步回调。 |
| `OnPopupScroll` | `Action<float, float>?` | 树面板滚动时触发。 |
| `OnPopupScrollAsync` | `Func<float, float, Task>?` | 树面板滚动时触发的异步回调。 |

## 方法

### Focus()

```csharp
void Focus()
```

使树选择器获得焦点。

### Blur()

```csharp
void Blur()
```

使树选择器失去焦点并关闭面板。

### Clear()

```csharp
void Clear()
```

清空当前选择。

### Select(string)

```csharp
void Select(string value)
```

选中指定节点；在可勾选模式下等同于 SetChecked(value, true)。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `string` |  |

### Deselect(string)

```csharp
void Deselect(string value)
```

取消选中指定节点。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `string` |  |

### SetChecked(string, bool)

```csharp
void SetChecked(string value, bool isChecked)
```

设置指定节点的 Checkbox 状态。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `string` |  |
| `isChecked` | `bool` |  |

### ExpandAll()

```csharp
void ExpandAll()
```

展开全部树节点。

### CollapseAll()

```csharp
void CollapseAll()
```

折叠全部树节点。

### Refresh()

```csharp
void Refresh()
```

重新读取 TreeData、刷新过滤结果和触发器回填。

### GetSelectedNodes()

```csharp
TreeNode[] GetSelectedNodes()
```

按 TreeData 顺序返回当前全部选中节点。

### GetDisplayedNodes()

```csharp
TreeNode[] GetDisplayedNodes()
```

返回经过 ShowCheckedStrategy 处理后显示在触发器中的节点。

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

### Update(float)

```csharp
void Update(float deltaTime)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaTime` | `float` |  |

### VerifyCanDispose()

```csharp
void VerifyCanDispose()
```

无副作用地验证挂载在 Root 上的树面板子树允许拥有型释放。

### Dispose()

```csharp
void Dispose()
```

## 相关类型

### TreeNode

> **类型**：类

树节点数据模型

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Level` | `int` | 节点层级（根节点为 0）。 由 <see cref="UITree.TreeData"/> 在初始化/赋值时自动填充。 |
| `Value` | `string` | 节点唯一标识值 |
| `Label` | `string` | 节点显示标题 |
| `DisableCheckbox` | `bool` | 是否禁用复选框（仅在 Checkable 模式下有效） |
| `Disabled` | `bool` | 是否禁用节点（禁用后不可交互） |
| `Icon` | `UIIcon?` | 自定义图标（设置后显示在节点标题前） |
| `Selectable` | `bool` | 是否可被选中（默认为 true） |
| `Children` | `ObservableCollection<TreeNode>?` | 子节点列表 |
| `IsLeaf` | `bool` | 是否为叶子节点（无子节点） |

### TreeSelectPlacement

> **类型**：枚举

树面板相对触发器的弹出位置。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `BottomLeft` | - | 面板位于触发器下方并左对齐。 |
| `BottomRight` | - | 面板位于触发器下方并右对齐。 |
| `TopLeft` | - | 面板位于触发器上方并左对齐。 |
| `TopRight` | - | 面板位于触发器上方并右对齐。 |

### TreeSelectShowCheckedStrategy

> **类型**：枚举

可勾选模式下，触发器中已选节点的回填方式。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `ShowChild` | - | 只显示已勾选的叶子节点。 |
| `ShowParent` | - | 父节点完整勾选时只显示父节点。 |
| `ShowAll` | - | 显示所有已勾选节点，包括父节点。 |

### TreeSelectSize

> **类型**：枚举

树选择框尺寸。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Small` | - | 小尺寸，高度 24px。 |
| `Medium` | - | 中等尺寸，高度 32px。 |
| `Large` | - | 大尺寸，高度 40px。 |

### TreeSelectStatus

> **类型**：枚举

树选择框校验状态。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `None` | - | 普通状态。 |
| `Error` | - | 错误状态。 |
| `Warning` | - | 警告状态。 |

### TreeSelectVariant

> **类型**：枚举

树选择框视觉变体。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Outlined` | - | 带完整边框的默认样式。 |
| `Borderless` | - | 无边框样式。 |
| `Filled` | - | 填充背景样式。 |
| `Underlined` | - | 仅显示下边框。 |
