# FontFallbackHelper

> **类型**：类　**分类**：Helpers　**框架版本**：`0.1.1.24`

## 概述

全局字体回退助手：为给定示例文本选择可渲染的字体。 顺序：首选字体 -> 系统候选（平台字体 + 常见中文字体 + Emoji）。

## 方法

### Resolve(string, SKTypeface)

```csharp
SKTypeface Resolve(string sample, SKTypeface preferred)
```

解析示例文本，返回首选字体或第一个可渲染该文本的候选字体。 若首选字体能渲染则直接返回，否则依次尝试候选字体，找到第一个可渲染的即返回。 若所有候选都无法渲染，则回退到首选/默认字体。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `sample` | `string` | 要渲染的示例文本。 |
| `preferred` | `SKTypeface` | 首选字体（可为 null）。 |

**返回：** 可渲染示例文本的字体。
