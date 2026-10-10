# UICascader

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView, IKeyboardFocusable, IDisposable, IUIElementDisposalPreflight`

## 概述

Semi Design 风格的级联选择器。触发器负责值回填、搜索和弹层生命周期， 弹层按当前路径逐级渲染选项列，支持单选、多选、ChangeOnSelect、悬停展开与路径搜索。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `RootClassName` | `string` | 根元素建议使用的语义 CSS 类名。 |
| `TriggerClassName` | `string` | 触发器正文的语义 CSS 类名。 |
| `PopupClassName` | `string` | 弹出面板的语义 CSS 类名。 |
| `SearchClassName` | `string` | 搜索区域的语义 CSS 类名。 |
| `ColumnsClassName` | `string` | 选项列宿主的语义 CSS 类名。 |
| `ColumnClassName` | `string` | 单个选项列的语义 CSS 类名。 |
| `OptionClassName` | `string` | 单个选项行的语义 CSS 类名。 |
| `TagClassName` | `string` | 多选回填标签的语义 CSS 类名。 |
| `EmptyClassName` | `string` | 无匹配数据区域的语义 CSS 类名。 |
| `Style` | `UIStyle?` | 元素样式。赋值 <see cref="UpdateUIStyle"/> 时在当前 Cascader 样式上增量合并。 |
| `Data` | `IList<TreeNode>` | 级联数据；每个节点的 <see cref="TreeNode.Value"/> 在整棵树中必须唯一。 |
| `Value` | `string?` |  |
| `Values` | `string[]` |  |
| `Paths` | `string[][]` | 当前选中路径列表（每条路径为根到叶的 Value 序列）。程序化赋值不会触发 OnChange。 |
| `DefaultValue` | `string?` | 调用方未显式设置 Value/Values 时使用的单个初始值。 |
| `DefaultValues` | `string[]` | 调用方未显式设置 Value/Values 时使用的初始值列表。 |
| `Multiple` | `bool` | 是否允许多选；多选模式下弹层选项带 Checkbox，触发器回填为标签。 |
| `ChangeOnSelect` | `bool` | 是否允许选中非叶子节点；true 时点击含子级的节点直接提交其路径。 |
| `ExpandTrigger` | `CascaderExpandTrigger` | 含子级选项展开下一列的触发方式。 |
| `ShowPath` | `bool` | 触发器与搜索结果中是否显示完整路径（如 "浙江省 / 杭州市 / 西湖区"）。 |
| `ShowSearch` | `bool` | 是否显示搜索输入框。 |
| `SearchValue` | `string` |  |
| `FilterCascaderOption` | `Func<string, TreeNode, bool>?` | 自定义节点过滤器；为空时匹配 Label 或 Value，忽略大小写。 |
| `AllowClear` | `bool` | 是否显示清除按钮。 |
| `Disabled` | `bool` | 是否禁用全部交互。 |
| `Size` | `CascaderSize` | 触发器尺寸。 |
| `Variant` | `CascaderVariant` | 触发器视觉变体。 |
| `Status` | `CascaderStatus` | 触发器校验状态。 |
| `Placement` | `CascaderPlacement` | 面板弹出位置。 |
| `Placeholder` | `string` | 没有选中值时显示的占位文本。 |
| `PlaceholderColor` | `SKColor` | 占位文本颜色。 |
| `SearchPlaceholder` | `string` | 搜索输入框占位文本。 |
| `NotFoundContent` | `string` | 搜索无匹配结果或数据为空时显示的文本。 |
| `SuffixIcon` | `string` | 触发器后缀图标内容。 |
| `MaxTagCount` | `int?` | 最多显示的回填标签数量；null 表示不限制。 |
| `MaxTagTextLength` | `int?` | 单个回填标签的最大文本长度；null 表示不截断。 |
| `TagRender` | `Func<TreeNode[], UICascader, UIElement>?` | 自定义多选回填标签；参数为该路径上的全部节点。 |
| `Open` | `bool` |  |
| `DefaultOpen` | `bool` | 调用方未显式设置 Open 时使用的初始打开状态。 |
| `PopupWidth` | `float?` | 显式弹层总宽度（逻辑像素，含边框和内边距）；null 时按列宽及盒模型占用计算。 |
| `PopupHeight` | `float` | 弹层高度（逻辑像素）。 |
| `ColumnWidth` | `float` | 单个选项列的期望宽度（逻辑像素），随可用弹层空间伸缩。 |
| `PopupStyle` | `UIStyle?` | 弹层附加样式。 |
| `SearchInputStyle` | `UIStyle?` | 搜索输入框附加样式。 |
| `OnChange` | `Action<string[], TreeNode[][]>?` | 选择结果变化时触发；参数为全部叶子值和对应的完整路径节点。 |
| `OnChangeAsync` | `Func<string[], TreeNode[][], Task>?` | 选择结果变化时触发的异步回调。 |
| `OnSelect` | `Action<string[], TreeNode[]>?` | 用户提交一条选中路径时触发；参数为该路径的值序列与节点序列。 |
| `OnSelectAsync` | `Func<string[], TreeNode[], Task>?` | 用户提交一条选中路径时触发的异步回调。 |
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
| `OnPopupScroll` | `Action<float, float>?` | 弹层选项列滚动时触发。 |
| `OnPopupScrollAsync` | `Func<float, float, Task>?` | 弹层选项列滚动时触发的异步回调。 |

## 方法

### Focus()

```csharp
void Focus()
```

使级联选择器获得焦点。

### Blur()

```csharp
void Blur()
```

使级联选择器失去焦点并关闭面板。

### Clear()

```csharp
void Clear()
```

清空当前选择。

### Refresh()

```csharp
void Refresh()
```

重新读取 Data、刷新弹层选项列和触发器回填。

### GetSelectedPaths()

```csharp
string[][] GetSelectedPaths()
```

按 Data 顺序返回当前全部选中路径（根到叶的值序列）。

### GetSelectedPathNodes()

```csharp
TreeNode[][] GetSelectedPathNodes()
```

按 Data 顺序返回当前全部选中路径的节点序列；未知值以同名占位节点表示。

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

无副作用地验证挂载在 Root 上的级联面板子树允许拥有型释放。

### Dispose()

```csharp
void Dispose()
```

## 相关类型

### CascaderExpandTrigger

> **类型**：枚举

含子级选项的展开触发方式。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Click` | - | 点击选项展开下一级（默认）。 |
| `Hover` | - | 悬停选项即展开下一级。 |

### CascaderPlacement

> **类型**：枚举

级联面板相对触发器的弹出位置。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `BottomLeft` | - | 面板位于触发器下方并左对齐。 |
| `BottomRight` | - | 面板位于触发器下方并右对齐。 |
| `TopLeft` | - | 面板位于触发器上方并左对齐。 |
| `TopRight` | - | 面板位于触发器上方并右对齐。 |

### CascaderSize

> **类型**：枚举

级联选择框尺寸。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Small` | - | 小尺寸，高度 24px。 |
| `Medium` | - | 中等尺寸，高度 32px。 |
| `Large` | - | 大尺寸，高度 40px。 |

### CascaderStatus

> **类型**：枚举

级联选择框校验状态。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `None` | - | 普通状态。 |
| `Error` | - | 错误状态。 |
| `Warning` | - | 警告状态。 |

### CascaderVariant

> **类型**：枚举

级联选择框视觉变体。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Outlined` | - | 带完整边框的默认样式。 |
| `Borderless` | - | 无边框样式。 |
| `Filled` | - | 填充背景样式。 |
| `Underlined` | - | 仅显示下边框。 |

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


---

# UICascader

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

## 概述

UICascader 的弹层与交互部分：触发器回填、选项列渲染、选择/联动逻辑、 弹层生命周期与定位。与 <see cref="UICascader"/> 共同组成完整组件。
