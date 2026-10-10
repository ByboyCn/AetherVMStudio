# UIPagination

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

Pagination 分页组件。 交互与属性命名尽量贴近 Ant Design，视觉风格参考 Element Plus。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Total` | `int` | 数据总数。 |
| `Current` | `int` |  |
| `DefaultCurrent` | `int` | 默认当前页（非受控初始化值）。 |
| `PageSize` | `int` |  |
| `DefaultPageSize` | `int` | 默认每页条数（非受控初始化值）。 |
| `Disabled` | `bool` | 是否禁用整个分页。 |
| `ShowSizeChanger` | `bool` | 是否显示页大小切换器。 |
| `ShowQuickJumper` | `bool` | 是否显示快速跳页。 |
| `ShowLessItems` | `bool` | 是否使用更紧凑的页码折叠策略。 |
| `HideOnSinglePage` | `bool` | 只有一页时是否隐藏分页。 |
| `ShowPrevNextJumpers` | `bool` | 是否显示向前/向后跳页按钮。 |
| `ShowTitle` | `bool` | 是否展示提示标题。 当前版本保留为兼容属性。 |
| `Responsive` | `bool` | 是否启用响应式布局。 当前版本保留为兼容属性。 |
| `Size` | `PaginationSize` | 组件尺寸。 |
| `PageSizeOptions` | `List<int>` | 页大小可选项。 |
| `PageSizeSuffix` | `string` | 页大小后缀文本。 |
| `QuickJumperPrefix` | `string` | 快速跳页前缀文本。 |
| `QuickJumperSuffix` | `string` | 快速跳页后缀文本。 |
| `QuickJumperButtonText` | `string?` | 快速跳页确认按钮文本。当前默认使用 UIInput 提交，留空时通过回车/失焦跳页。 |
| `ShowTotal` | `Func<int, (int Start, int End), string>?` | 自定义总数展示。 参数：(total, (start, end)) => text。 |
| `OnChange` | `Action<int, int>?` | 页码或页大小变化时触发。 |
| `OnChangeAsync` | `Func<int, int, Task>?` | 当前页或每页条数变化时触发的异步回调。 |
| `OnShowSizeChange` | `Action<int, int>?` | 页大小变化时触发。 |
| `OnShowSizeChangeAsync` | `Func<int, int, Task>?` | 每页显示条数变化时触发的异步回调。 |
| `TotalPages` | `int` | 当前总页数。 |

## 相关类型

### PaginationSize

> **类型**：枚举

分页尺寸。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Default` | - | 默认尺寸。 |
| `Small` | - | 小尺寸。 |
