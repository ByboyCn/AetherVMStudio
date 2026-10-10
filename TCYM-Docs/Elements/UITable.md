# UITable

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView, ITableFilterHost, ITableColumnHost`

## 概述

基于 Canvas 绘制的实验性表格原型。 当前覆盖固定表头、固定列、分页、汇总行、虚拟绘制、本地排序、筛选下拉、 可见区内的 Render/TitleRender 宿主、横纵滚动与省略 Tooltip。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Columns` | `List<TableColumn>` | 表格列配置。当前原型只支持纯文本列内容。 |
| `DataSource` | `object?` |  |
| `Loading` | `bool` | 是否显示加载状态。 |
| `Bordered` | `bool` | 是否展示外边框和列边框。 |
| `RowKey` | `string` | 表格行 key 的取值字段名。 |
| `SelectedRowKeys` | `List<string>?` |  |
| `RowSelection` | `RowSelectionConfig?` | 行选择配置。 |
| `DefaultSelectedRow` | `List<string>?` | 默认选中行。 |
| `RowHoverable` | `bool` | 行是否可 hover。 |
| `Expandable` | `ExpandableConfig?` | 树形展开配置。 |
| `Scroll` | `ScrollConfig?` | 滚动配置。 |
| `Pagination` | `TablePaginationConfig?` | 分页配置，设为 null 时禁用分页。 |
| `DefaultPageSize` | `int` | 默认每页条数。 |
| `Toolbar` | `TableToolbar?` | 表格工具栏配置。 |
| `ShowHeader` | `bool` | 是否显示表头。 |
| `Total` | `int` | 数据总数，用于远程分页场景。 |
| `HeaderHeightPx` | `float` | 表头高度（像素）。 |
| `TreeTableLine` | `bool` | 树形表格是否绘制连接线。 |
| `TreeLineStyle` | `string` | 树形连接线样式，支持 solid / dashed。 |
| `TreeLineColor` | `SKColor` | 树形连接线颜色。 |
| `TreeLineStrokeWidth` | `float` | 树形连接线宽度。 |
| `ExpandIconContent` | `string` | 未展开时的图标内容（字体图标编码），默认与 UITable 保持一致。 |
| `CollapseIconContent` | `string` | 展开时的图标内容（字体图标编码），默认与 UITable 保持一致。 |
| `Size` | `TableSize` | 表格尺寸。默认与 UITable 一致为 Middle。 |
| `RowHeightPx` | `float` | 行高（像素）。 |
| `CurrentSorter` | `SorterInfo?` | 当前排序信息。未排序时返回 null。 |
| `OnSortChange` | `Action<SorterInfo?>?` | 排序变化回调。仅在点击可排序表头时触发。 |
| `OnSortChangeAsync` | `Func<SorterInfo?, Task>?` | 排序变化异步回调。 |
| `OnRowClick` | `Action<object, int>?` | 行点击回调。 |
| `OnRowClickAsync` | `Func<object, int, Task>?` | 行点击异步回调。 |
| `OnRowDoubleClick` | `Action<object, int>?` | 行双击回调。 |
| `OnRowDoubleClickAsync` | `Func<object, int, Task>?` | 行双击异步回调。 |
| `RowClassName` | `Func<object, int, string>?` | 行样式类名回调。 |
| `OnPageSizeChange` | `Action<int, int>?` | 分页变化回调。 |
| `OnPageSizeChangeAsync` | `Func<int, int, Task>?` | 分页变化异步回调。 |
| `OnTableChange` | `Action<TablePaginationConfig, Dictionary<string, List<object>>, SorterInfo?>?` | 分页、排序或筛选变化时触发。 |
| `OnTableChangeAsync` | `Func<TablePaginationConfig, Dictionary<string, List<object>>, SorterInfo?, Task>?` | 分页、排序或筛选变化异步回调。 |
| `SearchHighlightColor` | `SKColor` | 默认搜索筛选命中文本的高亮颜色。 |

## 方法

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

测量组件尺寸并在宽度变化时重新解析列宽。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` | 可用宽度。 |
| `availableHeight` | `float` | 可用高度。 |

### Update(float)

```csharp
void Update(float deltaSeconds)
```

每帧更新悬停 Tooltip 状态。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` | 距离上一帧的时间增量（秒）。 |

### Layout(float, float, float, float)

```csharp
void Layout(float x, float y, float width, float height)
```

布局原型表格：固定表头高度，并将剩余空间分配给 body scrollview 作为滚动视口。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` | X 坐标。 |
| `y` | `float` | Y 坐标。 |
| `width` | `float` | 宽度。 |
| `height` | `float` | 高度。 |

## 相关类型

### ColumnAlign

> **类型**：枚举

列对齐方式

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Left` | - | 左对齐（默认） |
| `Center` | - | 居中对齐 |
| `Right` | - | 右对齐 |

### ColumnFixed

> **类型**：枚举

列固定位置

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `None` | - | 不固定 |
| `Left` | - | 固定在左侧 |
| `Right` | - | 固定在右侧 |

### ExpandableConfig

> **类型**：类

展开功能配置

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `ChildrenColumnName` | `string` | 指定树形结构的列名，默认 "children" |
| `DefaultExpandAllRows` | `bool` | 默认展开所有行 |
| `DefaultExpandedRowKeys` | `List<string>?` | 默认展开的行 key 集合 |
| `ExpandedRowRender` | `Func<object, int, int, bool, UIElement?>?` | 自定义展开行内容渲染 record: 当前行数据 index: 行索引 indent: 缩进层级 expanded: 是否已展开 |
| `RowExpandable` | `Func<object, bool>?` | 判断行是否可以展开 |
| `ExpandIcon` | `Func<bool, UIElement?>?` | 自定义展开图标渲染 |

### FilterItem

> **类型**：类

筛选项

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Text` | `string` | 筛选项显示文本 |
| `Value` | `object?` | 筛选项对应值 |
| `Children` | `List<FilterItem>?` | 子筛选项（用于树形筛选） |

### FilterMode

> **类型**：枚举

筛选菜单模式

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Menu` | - | 菜单模式 |
| `Tree` | - | 树形模式 |

### ITableColumnHost

> **类型**：接口

表格列宿主接口。 用于为列设置等辅助组件提供当前列定义读取与变更应用能力。

### ITableFilterHost

> **类型**：接口

### RowSelectionConfig

> **类型**：类

行选择配置

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `OnChange` | `Action<List<string>, List<object>>?` | 选中项发生变化时的回调 selectedRowKeys: 选中行的 key 列表 selectedRows: 选中的行数据列表 |
| `OnChangeAsync` | `Func<List<string>, List<object>, Task>?` | 选中项发生变化时的异步回调。 |
| `SelectedRowKeys` | `List<string>?` | 选中的行的 key 数组（受控模式） |
| `DefaultSelectedRowKeys` | `List<string>?` | 多选框的默认选中项 |
| `Type` | `SelectionType` | 选择框类型 |
| `Fixed` | `bool` | 是否固定选择列 |
| `ColumnWidth` | `float` | 选择列宽度 |
| `GetCheckboxProps` | `Func<object, bool>?` | 行是否可选择的判定函数 |

### ScrollConfig

> **类型**：类

滚动配置

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `X` | `float` | 水平滚动宽度，0 表示不限制 |
| `Y` | `float` | 垂直滚动高度 |
| `ScrollToFirstRowOnChange` | `bool` | 翻页时是否滚动到第一行 |

### SelectionType

> **类型**：枚举

行选择类型

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Checkbox` | - | 复选框 |
| `Radio` | - | 单选框 |

### SetColumnConfig

> **类型**：类

列设置配置

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Show` | `bool` | 是否显示列设置 |
| `FixedEnabled` | `bool` | 是否可以固定列 |
| `HideColumn` | `bool` | 是否可以隐藏列 |
| `Draggable` | `bool` | 是否可以拖拽排序 |
| `OnChange` | `Action<List<TableColumn>>?` | 列变更的回调。如果设置了此回调，需要自行更新 columns |
| `OnChangeAsync` | `Func<List<TableColumn>, Task>?` | 列设置变化时的异步回调。 |

### SorterInfo

> **类型**：类

排序信息

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Field` | `string` | 排序的列 DataIndex |
| `Order` | `SortOrder` | 排序方向 |

### SortOrder

> **类型**：枚举

排序方向

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `None` | - | 不排序 |
| `Ascend` | - | 升序 |
| `Descend` | - | 降序 |

### TableColumn

> **类型**：类

表格列定义，对应 Ant Design Column 接口

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Title` | `string` | 列头显示文字 |
| `TitleRender` | `Func<TableColumn, UIElement>?` | 自定义列头渲染 |
| `DataIndex` | `string` | 列数据在数据项中对应的 key（支持嵌套路径，如 "user.name"） |
| `Align` | `ColumnAlign` | 设置列的对齐方式，默认左对齐 |
| `Fixed` | `ColumnFixed` | 列是否固定及固定方向 |
| `Width` | `float` | 列的宽度（像素） |
| `MinWidth` | `float` | 最小列宽度，只在 TableLayout="Auto" 时有效 |
| `ClassName` | `string?` | 列样式类名 |
| `Ellipsis` | `bool?` | 超过宽度将自动省略。ShowTitle 控制是否显示 Tooltip |
| `IsDefaultFilterDropdown` | `bool` | 是否开启默认搜索框 |
| `IsFilterRemote` | `bool` | 筛选是否后端处理 |
| `RemoteCustomizeDataIndex` | `Func<string, string>?` | 后端如需要自定义筛选参数 |
| `Filters` | `List<FilterItem>?` | 表头的筛选菜单项 |
| `FilterMode` | `FilterMode` | 指定筛选菜单的用户界面模式 |
| `FilterSearch` | `bool` | 筛选菜单项是否可搜索 |
| `DefaultSortOrder` | `SortOrder` | 默认排序顺序 |
| `Filtered` | `bool` | 标识数据是否经过过滤，筛选图标会高亮 |
| `Sorter` | `Func<object, object, int>?` | 排序函数，本地排序使用。返回负数、零、正数 |
| `SorterMultiple` | `int` | 是否支持多列排序，数字越小优先级越高 |
| `Hidden` | `bool` | 隐藏列 |
| `Render` | `Func<object?, object, int, UIElement?>?` | 自定义渲染列内容 text: 当前单元格的值 record: 当前行的数据 index: 当前行的索引 返回 UIElement 用于渲染该单元格 |
| `Summary` | `Func<IList<object>, UIElement?>?` | 自定义渲染汇总行 |
| `OnFilter` | `Func<object, object, bool>?` | 本地数据筛选函数 |
| `OnHeaderCell` | `Action<UIElement>?` | 设置头部单元格属性回调 |
| `OnCell` | `Action<UIElement, object, int>?` | 设置单元格属性回调 |
| `Children` | `List<TableColumn>?` | 子列（用于表头分组） |

### TablePaginationConfig

> **类型**：类

分页配置

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `PageSize` | `int` | 每页条数 |
| `Current` | `int` | 当前页码 |
| `Total` | `int` | 数据总数 |
| `PageSizeOptions` | `List<int>` | 每页条数可选项 |
| `ShowSizeChanger` | `bool` | 是否显示 PageSize 切换器 |
| `ShowQuickJumper` | `bool` | 是否显示快速跳转 |

### TableSize

> **类型**：枚举

表格大小

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Middle` | - | 中等（默认） |
| `Small` | - | 紧凑 |
| `Large` | - | 宽松 |

### TableToolbar

> **类型**：类

工具栏配置

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Show` | `bool` | 是否显示工具栏 |
| `Align` | `ToolbarAlign` | 对齐方式 |
| `Add` | `ToolbarActionConfig?` | 新增按钮配置 |
| `Edit` | `ToolbarActionConfig?` | 编辑按钮配置 |
| `Delete` | `ToolbarActionConfig?` | 删除按钮配置 |
| `Refresh` | `ToolbarActionConfig?` | 刷新按钮配置 |
| `Export` | `ToolbarActionConfig?` | 导出按钮配置 |
| `Import` | `ToolbarActionConfig?` | 导入按钮配置 |
| `DownloadTemplate` | `ToolbarActionConfig?` | 下载模板按钮配置 |
| `SetColumn` | `SetColumnConfig?` | 列设置配置 |
| `CustomToolbarRight` | `UIElement?` | 自定义工具栏右侧元素 |
| `CustomToolbarLeft` | `UIElement?` | 自定义工具栏左侧元素 |
| `CustomToolbar` | `UIElement?` | 自定义工具栏元素（兼容旧接口） |
| `IsShowCustomDefault` | `bool` | 是否同时显示自定义和默认工具栏 |

### ToolbarActionConfig

> **类型**：类

工具栏按钮配置

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Show` | `bool` | 是否显示 |
| `Dom` | `UIElement?` | 自定义渲染元素 |
| `ClassName` | `string?` | 工具按钮样式类名，多个类名可用空格分隔 |
| `Style` | `UIStyle?` | 工具按钮样式 |
| `Events` | `UIEventBindings?` | 工具按钮事件绑定 |

### ToolbarAlign

> **类型**：枚举

工具栏对齐方式

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Left` | - | 左对齐（默认） |
| `Right` | - | 右对齐 |
| `Center` | - | 居中对齐 |
| `SpaceBetween` | - |  |
