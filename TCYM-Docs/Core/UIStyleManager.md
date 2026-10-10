# UIStyleManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

全局样式管理器，用于存储和管理类名对应的样式。

## 方法

### RegisterClassStyle(string, UIStyle)

```csharp
void RegisterClassStyle(string className, UIStyle style)
```

注册一个类名及其对应的样式

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `className` | `string` | 类名 |
| `style` | `UIStyle` | 样式对象 |

### GetStyleForClass(string)

```csharp
UIStyle? GetStyleForClass(string className)
```

获取指定类名的样式

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `className` | `string` | 类名 |

**返回：** 对应的样式对象，如果不存在则返回 null

### GetStyleForId(string)

```csharp
UIStyle? GetStyleForId(string id)
```

获取纯 <c>#id</c> 选择器为指定 Id 注册的样式。 Id 按区分大小写的序号规则匹配。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `id` | `string` | 元素 Id。 |

**返回：** 对应样式；不存在时返回 null。

### UnregisterClassStyle(string)

```csharp
void UnregisterClassStyle(string className)
```

移除指定类名的样式

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `className` | `string` | 类名 |

### ClearAllStyles()

```csharp
void ClearAllStyles()
```

清除所有已注册的类样式

### GetMatchedSelectorStyles(UIElement)

```csharp
IEnumerable<UIStyle> GetMatchedSelectorStyles(UIElement element)
```

获取当前元素命中的组合选择器样式（例如 .a .b 或 .a > .b）。 返回顺序按 (specificity, order) 从低到高，调用方可按顺序 MergeWith。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `element` | `UIElement` |  |

### RegisterClassStylesFromCss(string)

```csharp
void RegisterClassStylesFromCss(string cssText)
```

从 CSS 文本批量注册类样式

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `cssText` | `string` | CSS 文本，例如：".button { color: red; } .label { font-size: 16px; }" |

### RegisterClassStylesFromCss(string, string?)

```csharp
void RegisterClassStylesFromCss(string cssText, string? sourceKey)
```

从 CSS 文本批量注册类样式，并按样式源替换旧规则。 文件路径或 res:// 形式的 sourceKey 同时作为相对 @import 的解析基址。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `cssText` | `string` | CSS 文本。 |
| `sourceKey` | `string?` | 样式源标识；相同 sourceKey 的后续注册会替换旧规则。 |


---

# UIStyleManager

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`
