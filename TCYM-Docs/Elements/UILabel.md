# UILabel

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

UILabel：基础文本显示控件。 功能： 1. 支持自动换行（Wrap）、最大行数（MaxLines）、省略号（Ellipsize）。 2. 支持文本水平对齐（TextAlign: left/center/right）。 3. 支持简单的字体回退机制（通过 FontFallbackHelper）。 4. 支持文本渐变（text-gradient 标签）。 5. 测量阶段根据内容动态计算宽高（若未显式设置）。 6. 渲染阶段按行绘制文本，并在其后绘制子元素（文本在下层，子元素可覆盖之）。 7. 当 Display="flex" 且 FlexDirection="row" 时，文本和子元素水平排列，支持 gap、align-items、justify-content。 8. 支持文本高亮（Highlights），可通过精确文本或正则表达式匹配并以不同颜色绘制。 用法示例： <code> var label = new UILabel { Text = "搜索结果：Hello World 示例文本", Highlights = new List&lt;TextHighlight&gt; { new TextHighlight { Color = "#FF0000", Value = "Hello" }, new TextHighlight { Color = "rgb(0,128,255)", Value = @"\b[A-Z]+-\d+\b", IsRegex = true } } }; </code>

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Text` | `string` |  |
| `Wrap` | `bool` | 是否自动换行。 |
| `MaxLines` | `int` | 最大行数（0 表示不限）。 |
| `TextAlign` | `string` | 文本对齐方式：left / center / right / start / end；竖排时作用于高度方向。 |
| `Ellipsize` | `bool` | 超出最大行数时是否使用省略号“...”。 |
| `Highlights` | `List<TextHighlight>?` | 高亮文本列表：匹配的文本片段将以指定颜色绘制。 |
| `IsTextTruncated` | `bool` | 文本是否被截断（测量宽度超过可用内容宽度时为 true）。 仅在 Measure 执行后有效。 |

## 方法

### ApplyHotReloadTextPatchFrom(UILabel)

```csharp
bool ApplyHotReloadTextPatchFrom(UILabel nextLabel)
```

供设计期热更新使用：在文本相关状态变化时，尽量只触发当前标签重绘。 当标签宽高已固定且不参与文本+子元素的行内混排时，文本变化不会影响外部布局， 因此可以避免把整条父链都标记为需要重新布局。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `nextLabel` | `UILabel` |  |

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

布局阶段：当 Display="flex" 且 FlexDirection="row" 时，文本和子元素水平排列

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |
| `width` | `float` |  |
| `height` | `float` |  |

## 相关类型

### TextHighlight

> **类型**：类

文本高亮项：指定要高亮的文本片段及其颜色。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Color` | `string` | 高亮颜色（支持 CSS 格式，如 "#FF0000"、"red"、"rgb(255,0,0)"）。 |
| `Value` | `string` | 要高亮的文本内容；当 <see cref="IsRegex"/> 为 true 时表示正则表达式。 |
| `IsRegex` | `bool` | 是否将 <see cref="Value"/> 作为正则表达式匹配。默认为 false，保持原有的精确文本匹配行为。 无效、仅产生零长度匹配或匹配超时的表达式不会参与高亮。 |


---

# UILabel

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`


---

# UILabel

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`


---

# UILabel

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `SelectionStart` | `int` | 选区在原始 Text 中的 UTF-16 起始索引；边界始终落在完整字素上。 |
| `SelectionLength` | `int` | 选区在原始 Text 中的 UTF-16 长度。 |
| `SelectedText` | `string` | 已选择的原始文字，不包含省略号或伪元素生成的文字。 |

## 方法

### ClearSelection()

```csharp
void ClearSelection()
```

清除当前标签选区，同时结束尚未完成的鼠标拖选。

### SelectAll()

```csharp
void SelectAll()
```

选择当前标签的完整原文；none 禁止创建新选区，但不销毁已存在的选区。

### OnMouseEvent(UIMouseEvent)

```csharp
void OnMouseEvent(UIMouseEvent e)
```

保留完整鼠标事件派发，仅为随后无按钮信息的 PointerDown 钩子记录主键语义。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIMouseEvent` |  |

### OnPointerDown(float, float)

```csharp
void OnPointerDown(float x, float y)
```

普通主键点击建立拖选锚点；all 在第一次选择操作时选中整段。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnPointerMove(float, float)

```csharp
void OnPointerMove(float x, float y)
```

捕获阶段按真实排版字素推进选区，越界时保持在当前 UILabel 的文字范围内。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnPointerUp(float, float)

```csharp
void OnPointerUp(float x, float y)
```

抬起时提交最后位置，不消费框架原有 Click、PointerReleased 或业务事件。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |


---

# UILabel

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`


---

# UILabel

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`


---

# UILabel

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`
