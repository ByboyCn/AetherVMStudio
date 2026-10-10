# TextMeasureHelper

> **类型**：类　**分类**：Helpers　**框架版本**：`0.1.1.24`

## 概述

文本测量工具：对外提供通用的文本宽高测算方法。 - 内部使用 SkiaSharp 的 SKFont.MeasureText。 - 带字体回退：通过 <see cref="FontFallbackHelper.Resolve"/> 选择可渲染当前文本的字体。 - 适用于虚拟列表的 widthProvider/heightProvider 等场景。

## 方法

### MeasureWidth(string?, SKTypeface?, float)

```csharp
float MeasureWidth(string? text, SKTypeface? preferredTypeface, float fontSize)
```

测量单行文本宽度（像素）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `text` | `string?` | 要测量的文本。 |
| `preferredTypeface` | `SKTypeface?` | 期望字体（可为 null，内部会回退到默认字体）。 |
| `fontSize` | `float` | 字号（像素）。 |

**返回：** 单行文本宽度（像素）。

### MeasureSize(string?, SKTypeface?, float)

```csharp
(float width, float height) MeasureSize(string? text, SKTypeface? preferredTypeface, float fontSize)
```

测量单行文本尺寸（像素）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `text` | `string?` | 要测量的文本。 |
| `preferredTypeface` | `SKTypeface?` | 期望字体（可为 null）。 |
| `fontSize` | `float` | 字号（像素）。 |

**返回：** (width,height) 分别为文本宽度与字体行高（像素）。

### MeasureWrapped(string?, SKTypeface?, float, float)

```csharp
(float width, float height, int lineCount) MeasureWrapped(string? text, SKTypeface? preferredTypeface, float fontSize, float maxWidth)
```

测量支持换行的文本尺寸（像素）。 - 这里采用“按字符贪心换行”的简化策略：适合 CJK，也能处理含空格的英文。 - 对于更复杂的排版（按单词、断字、富文本等）建议由具体控件自行实现。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `text` | `string?` | 要测量的文本。 |
| `preferredTypeface` | `SKTypeface?` | 期望字体（可为 null）。 |
| `fontSize` | `float` | 字号（像素）。 |
| `maxWidth` | `float` | 单行最大宽度（像素）。小于等于 0 时等价于单行测量。 |

**返回：** (width,height,lineCount) 分别为最大行宽、总高度、行数。
