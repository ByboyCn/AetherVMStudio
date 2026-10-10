# UICodeEditor

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIElement, IKeyboardFocusable, IDisposable`

## 概述

轻量代码编辑器。 支持多语言关键字高亮、行号、键盘输入与剪贴板。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `DefaultClassName` | `string` | 代码编辑器内置默认样式类。它始终排在用户类之前，因此可被 CSS 类覆盖； 用户显式设置的 <see cref="UIElement.Style"/> 仍保持最高优先级。 |
| `OnValueChanged` | `event Action<string>?` | 文本内容变更事件。 参数为当前完整文本。 |
| `OnValueChangedAsync` | `event Func<string, Task>?` | 编辑器文本变化时触发的异步事件。 |
| `Language` | `CodeEditorLanguage` | 当前代码语言类型。 |
| `TabSize` | `int` | Tab 对应的空格数量。 |
| `ShowLineNumbers` | `bool` | 是否显示行号。 |
| `ReadOnly` | `bool` | 是否只读。 |
| `ShowMinimap` | `bool` | 是否显示最小地图。 |
| `WordWrap` | `bool` | 是否启用自动换行（预留）。 |
| `AutoFormatOnPaste` | `bool` | 粘贴（Ctrl+V）后是否自动格式化代码。 |
| `AutoFormatOnInitialize` | `bool` | 首次初始化 <see cref="Text"/> 时是否自动格式化（异步）。 |
| `ShowFormatLoading` | `bool` | 异步格式化时是否显示 TomatoNovelLoading 等待动画。 |
| `FormatLoadingMaskColor` | `SKColor` | 异步格式化遮罩颜色。 |
| `AsyncApplyLinesPerFrame` | `int` | 每帧应用格式化结果的最大行数（用于避免 UI 卡顿）。 |
| `EditorBackground` | `SKColor` | 编辑器背景色。 |
| `EditorBorder` | `SKColor` | 编辑器边框色。 |
| `EditorText` | `SKColor` | 默认文本颜色。 |
| `IdentifierColor` | `SKColor` | 标识符颜色（变量/方法/类型名等非关键字）。 |
| `LineNumberText` | `SKColor` | 行号文本颜色。 |
| `GutterBackground` | `SKColor` | 行号区域背景色。 |
| `CurrentLineBackground` | `SKColor` | 当前行背景色。 |
| `CursorColor` | `SKColor` | 光标颜色。 |
| `KeywordColor` | `SKColor` | 关键字颜色。 |
| `TypeColor` | `SKColor` | 类型名颜色。 |
| `MethodColor` | `SKColor` | 方法名颜色。 |
| `NamespaceColor` | `SKColor` | 命名空间名颜色。 |
| `VariableColor` | `SKColor` | 变量名颜色（局部变量/字段等）。 |
| `StringColor` | `SKColor` | 字符串颜色。 |
| `CommentColor` | `SKColor` | 注释颜色。 |
| `NumberColor` | `SKColor` | 数字颜色。 |
| `SelectionColor` | `SKColor` | 选区背景色。 |
| `MatchColor` | `SKColor` | 查找匹配高亮色。 |
| `ActiveMatchColor` | `SKColor` | 当前匹配项高亮色。 |
| `FoldMarkerColor` | `SKColor` | 折叠标记颜色。 |
| `FoldInlineHintBackground` | `SKColor` | 折叠内联提示背景色。 |
| `FoldInlineHintText` | `SKColor` | 折叠内联提示文字色。 |
| `FoldInlineHintBorder` | `SKColor` | 折叠内联提示边框色。 |
| `MinimapColor` | `SKColor` | 最小地图线条颜色。 |
| `MinimapViewportColor` | `SKColor` | 最小地图视口颜色。 |
| `Text` | `string` |  |

## 方法

### Dispose()

```csharp
void Dispose()
```

释放编辑器拥有的后台任务、内部输入框以及 Skia 原生资源。 后台任务只发出取消信号，不在 UI 线程等待线程退出。

### Update(float)

```csharp
void Update(float deltaSeconds)
```

每帧更新：处理光标闪烁和查找面板输入框状态。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` | 与上一帧的时间间隔（秒）。 |

### Render(SKCanvas)

```csharp
void Render(SKCanvas canvas)
```

渲染编辑器主体、选区、折叠、最小地图、滚动条和查找面板。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `canvas` | `SKCanvas` | 目标画布。 |

### OnPointerDown(float, float)

```csharp
void OnPointerDown(float x, float y)
```

处理指针按下：焦点、查找面板、折叠、最小地图、滚动条拖拽与选区起点。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnPointerMove(float, float)

```csharp
void OnPointerMove(float x, float y)
```

处理指针移动：最小地图拖拽、滚动条拖拽与选区更新。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnPointerUp(float, float)

```csharp
void OnPointerUp(float x, float y)
```

处理指针抬起：结束选择与拖拽状态。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` |  |
| `y` | `float` |  |

### OnMouseEvent(UIMouseEvent)

```csharp
void OnMouseEvent(UIMouseEvent e)
```

处理鼠标事件（当前主要处理滚轮滚动）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIMouseEvent` |  |

### OnTouchEvent(UITouchEvent)

```csharp
void OnTouchEvent(UITouchEvent e)
```

处理触摸事件：支持平板触摸滑动滚动，到达边界时冒泡给祖级。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UITouchEvent` |  |

### Focus()

```csharp
void Focus()
```

获取键盘焦点并开启文本输入。

### Blur()

```csharp
void Blur()
```

失去键盘焦点并停止文本输入。

## 相关类型

### CodeEditorLanguage

> **类型**：枚举

代码编辑器语言类型。

| 名称 | 值 | 说明 |
| --- | --- | --- |
| `PlainText` | - | 纯文本（不做语法高亮）。 |
| `CSharp` | - | C# 语言。 |
| `Java` | - | Java 语言。 |
| `JavaScript` | - | JavaScript 语言。 |
| `TypeScript` | - | TypeScript 语言。 |
| `Css` | - | CSS 样式语言。 |
| `Json` | - | JSON 数据语言。 |


---

# UICodeEditor

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`


---

# UICodeEditor

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`


---

# UICodeEditor

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

## 概述

语义高亮辅助（接近 Monaco 的“标识符按上下文着色”思路）。
