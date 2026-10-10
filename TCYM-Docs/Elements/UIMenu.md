# UIMenu

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

导航菜单组件（参考 antd Menu 的常用交互，简化版）。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Items` | `List<MenuItem>` | 菜单数据源。 |
| `Mode` | `MenuMode` | 菜单布局模式。 |
| `Theme` | `MenuTheme` | 菜单主题。 |
| `Multiple` | `bool` | 是否允许多选（仅叶子项）。 |
| `Selectable` | `bool` | 是否可选中叶子项。 |
| `ItemHeight` | `float` | 行高。 |
| `InlineIndent` | `float` | 子层级缩进。 |
| `ItemGap` | `float` | 菜单项垂直间距。 |
| `InlineCollapsed` | `bool` | inline 模式下菜单是否收起状态。 收起后仅显示图标，隐藏文字与展开箭头。仅在 <see cref="MenuMode.Inline"/> 时有效。 |
| `CollapsedWidth` | `float` | 收起时的菜单宽度，默认 48。 |
| `IconFontFamily` | `SKTypeface?` | Menu 图标字体（仅用于 string 图标）。 默认值：UIFontManager.Get("TCYMIconFont")。 |
| `ItemStyle` | `UpdateUIStyle` | 菜单项基础样式（仅支持 <see cref="UpdateUIStyle"/>）。 会应用到所有菜单项，再叠加选中态样式。 |
| `Style` | `UIStyle?` | 组件样式。 - 传入 DefaultUIStyle：视为外部完整样式，不再由主题覆盖容器背景/边框。 - 传入 UpdateUIStyle：与内部默认样式合并，且主题仅补齐未显式设置的容器属性。 |
| `SelectedKeys` | `string[]` |  |
| `OpenKeys` | `string[]` |  |
| `SelectStyle` | `UpdateUIStyle` | 选中样式（仅支持 <see cref="UpdateUIStyle"/>）。 默认：color=#1677ff；hover 背景 rgb(236,245,255)。 |
| `ExpandIconRender` | `Func<MenuItem, bool, UIIcon>?` | 自定义展开图标。 参数：(当前项, 是否展开) => 图标。 未设置时默认：收起 &#xec8d;，展开 &#xec8e;。 |
| `OnItemClick` | `event Action<MenuItem>?` | 项目点击（叶子项）事件。 |
| `OnItemClickAsync` | `event Func<MenuItem, Task>?` | 菜单项被点击时触发的异步事件。 |
| `OnSelect` | `Action<string[], MenuItem>?` | 选中变化回调（支持在对象初始化器中直接赋值）。 |
| `OnSelectAsync` | `Func<string[], MenuItem, Task>?` | 菜单项选中状态变化时触发的异步回调。 |
| `OnOpenChange` | `event Action<string[]>?` | 展开变化事件。 |
| `OnOpenChangeAsync` | `event Func<string[], Task>?` | 子菜单展开状态变化时触发的异步事件。 |

## 相关类型

### MenuItem

> **类型**：类

Menu 数据项。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Key` | `string` | 唯一键。 |
| `Label` | `string` | 显示文本。 |
| `Icon` | `MenuItemIcon?` | 图标，支持 string 或 UIIcon。 - string：等价于 new UIIcon { Content = string } - UIIcon：直接使用该实例 |
| `Badge` | `UIElement?` | 菜单项右侧角标。 通常可传入 <see cref="UIBadge"/>、<see cref="UITag"/> 或其他自定义元素， 会渲染在菜单项最右侧。 |
| `ItemRender` | `Func<MenuItem, UIMenu, UIElement>?` | 自定义项内容渲染。 若设置，则优先使用该内容替代默认的 Icon + Label 布局。 |
| `Disabled` | `bool` | 是否禁用。 |
| `Danger` | `bool` | 是否危险项（红色语义）。 |
| `IsGroup` | `bool` | 是否分组标题。 |
| `IsDivider` | `bool` | 是否分割线。 |
| `Children` | `List<MenuItem>` | 子项。 |
| `Payload` | `object?` | 附加数据。 |
| `OnClick` | `Action<MenuItem>?` | 当前项点击回调。 |
| `OnClickAsync` | `Func<MenuItem, Task>?` | 菜单项被点击时触发的异步回调。 |

### MenuItemIcon

> **类型**：结构体

Menu 图标值类型：支持 string 或 UIIcon。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Content` | `string?` | 字符串图标内容。 |
| `Icon` | `UIIcon?` | 自定义 UIIcon。 |
| `IsString` | `bool` | 是否来源于字符串。 |
| `IsUIIcon` | `bool` | 是否来源于 UIIcon。 |
| `IsEmpty` | `bool` | 是否为空。 |

### MenuMode

> **类型**：枚举

Menu 布局模式。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Inline` | - | 纵向内联模式（支持多级展开）。 |
| `Vertical` | - | 纵向模式。 |

### MenuTheme

> **类型**：枚举

Menu 主题。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Light` | - | 浅色主题。 |
| `Dark` | - | 深色主题。 |


---

# UIMenu

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Styles` | `MenuStyles?` | 各语义部位的行内样式；优先于组件默认值和普通 CSS，CSS !important 遵循框架规则。 赋值后立即刷新；原位修改子属性后调用 <see cref="RefreshStyles"/>。null 清除配置。 |
| `ClassNames` | `MenuClassNames?` | 各语义部位的 CSS 类名，与组件内置类合并；赋值 null 清除自定义类。 |
| `StylesRender` | `Func<MenuStyleContext, MenuStyles>?` | 根据菜单项、选中、展开、禁用等状态生成样式，叠加在静态 Styles 之后。 根容器与根列表的上下文 Item 为 null；回调应只返回配置，不修改菜单状态。 |
| `ClassNamesRender` | `Func<MenuStyleContext, MenuClassNames>?` | 根据菜单项状态生成 CSS 类名，与静态 ClassNames 合并；回调应无副作用。 |

## 方法

### RefreshStyles()

```csharp
void RefreshStyles()
```

在原位修改 Styles、ClassNames 或菜单项的外观状态后重新应用全部语义样式。

## 相关类型

### MenuClassNames

> **类型**：类

菜单各语义部位的 CSS 类名；可使用空格分隔多个类名。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Root` | `string?` | 菜单根容器的 CSS 类名。 |
| `List` | `string?` | 菜单顶层列表的 CSS 类名。 |
| `Item` | `string?` | 菜单项交互容器的 CSS 类名。 |
| `ItemTitle` | `string?` | 菜单项标题交互行的 CSS 类名。 |
| `ItemIcon` | `string?` | 菜单项图标的 CSS 类名。 |
| `ItemContent` | `string?` | 菜单项内容区域的 CSS 类名，包含自定义渲染内容。 |
| `Group` | `string?` | 分组容器的 CSS 类名。 |
| `GroupTitle` | `string?` | 分组标题的 CSS 类名。 |
| `GroupList` | `string?` | 分组子项列表的 CSS 类名。 |
| `Divider` | `string?` | 分割线的 CSS 类名。 |
| `Badge` | `string?` | 角标元素的 CSS 类名。 |
| `Extra` | `string?` | 右侧附加内容容器的 CSS 类名，包含角标和展开图标。 |
| `ExpandIcon` | `string?` | 子菜单展开图标的 CSS 类名。 |
| `SubMenu` | `MenuSubMenuClassNames?` | 子菜单各语义部位的专用 CSS 类名。 |

### MenuItem

> **类型**：类

Menu 数据项。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Key` | `string` | 唯一键。 |
| `Label` | `string` | 显示文本。 |
| `Icon` | `MenuItemIcon?` | 图标，支持 string 或 UIIcon。 - string：等价于 new UIIcon { Content = string } - UIIcon：直接使用该实例 |
| `Badge` | `UIElement?` | 菜单项右侧角标。 通常可传入 <see cref="UIBadge"/>、<see cref="UITag"/> 或其他自定义元素， 会渲染在菜单项最右侧。 |
| `ItemRender` | `Func<MenuItem, UIMenu, UIElement>?` | 自定义项内容渲染。 若设置，则优先使用该内容替代默认的 Icon + Label 布局。 |
| `Disabled` | `bool` | 是否禁用。 |
| `Danger` | `bool` | 是否危险项（红色语义）。 |
| `IsGroup` | `bool` | 是否分组标题。 |
| `IsDivider` | `bool` | 是否分割线。 |
| `Children` | `List<MenuItem>` | 子项。 |
| `Payload` | `object?` | 附加数据。 |
| `OnClick` | `Action<MenuItem>?` | 当前项点击回调。 |
| `OnClickAsync` | `Func<MenuItem, Task>?` | 菜单项被点击时触发的异步回调。 |

### MenuItemIcon

> **类型**：结构体

Menu 图标值类型：支持 string 或 UIIcon。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Content` | `string?` | 字符串图标内容。 |
| `Icon` | `UIIcon?` | 自定义 UIIcon。 |
| `IsString` | `bool` | 是否来源于字符串。 |
| `IsUIIcon` | `bool` | 是否来源于 UIIcon。 |
| `IsEmpty` | `bool` | 是否为空。 |

### MenuMode

> **类型**：枚举

Menu 布局模式。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Inline` | - | 纵向内联模式（支持多级展开）。 |
| `Vertical` | - | 纵向模式。 |

### MenuStyleContext

> **类型**：类

计算菜单语义样式和类名时使用的当前菜单项与状态。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Menu` | `UIMenu` | 所属菜单实例。 |
| `Item` | `MenuItem?` | 当前菜单项；计算根容器和顶层列表时为 null。 |
| `Level` | `int` | 当前菜单项的层级，从零开始。 |
| `Selected` | `bool` | 当前菜单项是否处于选中状态。 |
| `Open` | `bool` | 当前子菜单是否处于展开状态。 |
| `Disabled` | `bool` | 当前菜单项是否禁用。 |
| `Danger` | `bool` | 当前菜单项是否为危险项。 |
| `Mode` | `MenuMode` | 菜单当前的布局模式。 |
| `Theme` | `MenuTheme` | 菜单当前使用的主题。 |

### MenuStyles

> **类型**：类

菜单各语义部位的样式配置；未配置的属性沿用主题和原有样式。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Root` | `UpdateUIStyle?` | 菜单根容器的样式。 |
| `List` | `UpdateUIStyle?` | 菜单顶层列表的样式。 |
| `Item` | `UpdateUIStyle?` | 菜单项交互容器的样式。 |
| `ItemTitle` | `UpdateUIStyle?` | 菜单项标题交互行的样式。 |
| `ItemIcon` | `UpdateUIStyle?` | 菜单项图标的样式。 |
| `ItemContent` | `UpdateUIStyle?` | 菜单项内容区域的样式，包含自定义渲染内容。 |
| `Group` | `UpdateUIStyle?` | 分组容器的样式。 |
| `GroupTitle` | `UpdateUIStyle?` | 分组标题的样式。 |
| `GroupList` | `UpdateUIStyle?` | 分组子项列表的样式。 |
| `Divider` | `UpdateUIStyle?` | 分割线的样式。 |
| `Badge` | `UpdateUIStyle?` | 角标元素的样式。 |
| `Extra` | `UpdateUIStyle?` | 右侧附加内容容器的样式，包含角标和展开图标。 |
| `ExpandIcon` | `UpdateUIStyle?` | 子菜单展开图标的样式。 |
| `SubMenu` | `MenuSubMenuStyles?` | 子菜单专用样式；与通用部位样式重叠时优先使用。 |

### MenuSubMenuClassNames

> **类型**：类

子菜单标题、列表及内部菜单项的 CSS 类名；可使用空格分隔多个类名。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `ItemTitle` | `string?` | 具有子项的菜单标题交互行的 CSS 类名。 |
| `List` | `string?` | 子菜单展开列表的 CSS 类名。 |
| `Item` | `string?` | 子菜单内菜单项交互容器的 CSS 类名。 |
| `ItemIcon` | `string?` | 子菜单图标的 CSS 类名。 |
| `ItemContent` | `string?` | 子菜单内容区域的 CSS 类名。 |
| `Badge` | `string?` | 子菜单角标元素的 CSS 类名。 |
| `Extra` | `string?` | 子菜单右侧附加内容容器的 CSS 类名，包含角标和展开图标。 |
| `ExpandIcon` | `string?` | 子菜单展开图标的 CSS 类名。 |

### MenuSubMenuStyles

> **类型**：类

子菜单标题、列表及内部菜单项的语义样式。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `ItemTitle` | `UpdateUIStyle?` | 具有子项的菜单标题交互行的样式。 |
| `List` | `UpdateUIStyle?` | 子菜单展开列表的样式。 |
| `Item` | `UpdateUIStyle?` | 子菜单内菜单项交互容器的样式。 |
| `ItemIcon` | `UpdateUIStyle?` | 子菜单图标的样式。 |
| `ItemContent` | `UpdateUIStyle?` | 子菜单内容区域的样式。 |
| `Badge` | `UpdateUIStyle?` | 子菜单角标元素的样式。 |
| `Extra` | `UpdateUIStyle?` | 子菜单右侧附加内容容器的样式，包含角标和展开图标。 |
| `ExpandIcon` | `UpdateUIStyle?` | 子菜单展开图标的样式。 |

### MenuTheme

> **类型**：枚举

Menu 主题。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `Light` | - | 浅色主题。 |
| `Dark` | - | 深色主题。 |
