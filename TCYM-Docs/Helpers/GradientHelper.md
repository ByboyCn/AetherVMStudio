# GradientHelper

> **类型**：类　**分类**：Helpers　**框架版本**：`0.1.1.24`

## 概述

渐变助手类，用于解析和创建CSS样式的线性渐变

## 方法

### CreateLinearGradientFromCss(string, SKRect)

```csharp
SKShader? CreateLinearGradientFromCss(string css, SKRect rect)
```

尝试从CSS样式的linear-gradient(...)字符串创建线性渐变SKShader

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `css` | `string` | CSS渐变字符串 |
| `rect` | `SKRect` | 应用渐变的矩形区域 |

**返回：** 创建的SKShader对象，解析失败时返回null

### TryGetDarkestLinearGradientColor(string, SKColor)

```csharp
bool TryGetDarkestLinearGradientColor(string css, SKColor color)
```

获取线性渐变中亮度最低的有效颜色，适合为折角、边缘等区域生成同色系深色。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `css` | `string` | CSS linear-gradient 定义。 |
| `color` | `SKColor` | 解析成功时返回亮度最低的颜色。 |

**返回：** 至少解析到一个非透明颜色时返回 true。
