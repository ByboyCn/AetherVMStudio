# UITree

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIScrollView`

## 概述

树形组件，类似 Ant Design Tree

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `TreeData` | `IList<TreeNode>` |  |
| `AutoExpandParent` | `bool` | 是否自动展开父节点 |
| `Checkable` | `bool` | 节点前添加复选框 |
| `DisableCheckbox` | `bool` | 是否禁用整个树的 Checkbox（显示但不可点击）。 与节点级 `TreeNode.DisableCheckbox` 不同：本属性对所有节点生效。 |
| `CheckboxLinked` | `bool` | Checkbox 是否父子联动。 - true: 勾选父节点会同步勾选/取消所有子节点；子节点勾选状态会反向汇总到父节点（全选/半选）。 - false: 父子互不影响，仅记录当前节点的选中。 |
| `DefaultValues` | `string[]?` | 默认选中复选框的节点（Value 值） |
| `DefaultExpandAll` | `bool` | 默认展开所有树节点 |
| `DefaultExpanded` | `string[]?` | 默认展开指定的节点（Value 值） |
| `DefaultSelected` | `string[]?` | 默认选中的节点（Value 值） |
| `Disabled` | `bool` | 是否禁用整个树 |
| `Multiple` | `bool` | 是否支持多选 |
| `ShowLine` | `bool` | 是否显示连接线 |
| `TitleRender` | `Func<TreeNode, UITree, UIElement>?` | 自定义渲染节点标题 参数：(TreeNode 节点数据, UITree 树实例) => 自定义 UI 元素 |
| `SwitcherIcon` | `Func<TreeNode, bool, UIIcon>?` | 自定义展开/折叠图标 参数：(TreeNode 节点数据, bool 是否展开) => 自定义 UIIcon |
| `Values` | `string[]` | 当前选中的值 |
| `IndentSize` | `float` | 节点缩进大小（像素） |
| `NodeHeight` | `float` | 节点行高（像素） |
| `LineColor` | `SKColor` | 连接线颜色 |
| `LineStyle` | `string` | 连接线样式：solid / dashed / dotted |
| `LineWidth` | `float` | 连接线线宽（像素） |
| `TitleDefaultStyle` | `UIStyle` | 默认节点的样式 |
| `TitleSelectStyle` | `UIStyle` | 节点选中的样式 |
| `Style` | `UIStyle?` | 重写样式属性，设置默认样式 |
| `OnExpand` | `Action<string[], TreeNode, bool>?` | 展开/收起节点时触发 参数：(展开的节点 Value 列表, TreeNode 节点数据, bool 是否展开) |
| `OnExpandAsync` | `Func<string[], TreeNode, bool, Task>?` | 展开或收起节点时触发的异步回调。 |
| `OnSelect` | `Action<string[], TreeNode>?` | 点击树节点触发 参数：(选中的节点 Value 列表, TreeNode 节点数据) |
| `OnSelectAsync` | `Func<string[], TreeNode, Task>?` | 点击树节点时触发的异步回调。 |
| `OnCheck` | `Action<string[], TreeNode, bool>?` | 复选框状态变化时触发 参数：(选中的节点 Value 列表, TreeNode 节点数据, bool 是否选中) |
| `OnCheckAsync` | `Func<string[], TreeNode, bool, Task>?` | 复选框状态变化时触发的异步回调。 |

## 方法

### ExpandAll()

```csharp
void ExpandAll()
```

展开所有节点

### CollapseAll()

```csharp
void CollapseAll()
```

折叠所有节点

### Expand(string)

```csharp
void Expand(string value)
```

展开指定节点

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `string` | 节点 Value |

### Collapse(string)

```csharp
void Collapse(string value)
```

折叠指定节点

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `string` | 节点 Value |

### Select(string)

```csharp
void Select(string value)
```

选中指定节点

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `string` | 节点 Value |

### Deselect(string)

```csharp
void Deselect(string value)
```

取消选中指定节点

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `string` | 节点 Value |

### FindNode(string)

```csharp
UITreeNode? FindNode(string value)
```

查找节点

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `string` | 节点 Value |

**返回：** 找到的节点，未找到返回 null

### GetSelectedNodes()

```csharp
List<TreeNode> GetSelectedNodes()
```

获取所有选中的节点数据

### GetCheckedNodes()

```csharp
List<TreeNode> GetCheckedNodes()
```

获取所有选中复选框的节点数据

### GetExpandedNodes()

```csharp
List<TreeNode> GetExpandedNodes()
```

获取所有展开的节点数据

### SetChecked(string, bool)

```csharp
void SetChecked(string value, bool isChecked)
```

设置复选框选中状态

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `value` | `string` | 节点 Value |
| `isChecked` | `bool` | 是否选中 |

### SetCheckedValues(string[], bool)

```csharp
void SetCheckedValues(string[] values, bool isChecked)
```

批量设置复选框选中状态

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `values` | `string[]` | 节点 Value 列表 |
| `isChecked` | `bool` | 是否选中 |

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

### UITreeNode

> **类型**：类

树节点 UI 元素

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Data` | `TreeNode` | 节点数据 |
| `ParentNode` | `UITreeNode?` | 逻辑父节点（用于 checkbox 联动汇总）。 注意：UIElement.Parent 在树结构中会指向内部容器（如 childrenContainer），不能用于寻找树节点父级。 |
| `IsExpanded` | `bool` | 是否展开 |
| `IsSelected` | `bool` | 是否选中 |
| `IsChecked` | `bool` | 复选框是否选中 |
| `IsIndeterminate` | `bool` | 复选框是否半选（不确定态） |
| `ChildNodes` | `List<UITreeNode>` | 子节点 UI 元素列表 |
| `IsLastChild` | `bool` | 是否是最后一个子节点 |
| `Depth` | `int` | 节点深度 |
| `isLastChild` | `UITreeNode(UITree owner, TreeNode data, int depth, bool` | 创建树节点 UI 元素 |
