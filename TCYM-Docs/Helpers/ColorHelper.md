# ColorHelper

> **类型**：类　**分类**：Helpers　**框架版本**：`0.1.1.24`

## 概述

色彩解析辅助类：负责将 CSS 风格的颜色表示（#hex, rgb(), rgba(), named colors, 百分比等） 解析为 SkiaSharp 的 SKColor。将解析逻辑集中在此处以便复用。 所有注释均为中文以便维护。

## 方法

### ParseColor(string)

```csharp
SKColor ParseColor(string input)
```

解析颜色字符串为 SKColor。 支持： - CSS 十六进制：#rgb、#rgba、#rrggbb、#rrggbbaa；透明度位于末尾。 - rgb(...), rgba(...), 支持数值与百分比（如 50%） - 若干基础命名颜色（transparent, black, white, red, green, blue, gray/grey, yellow, cyan, magenta） 解析失败或空字符串返回 SKColors.Transparent。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `input` | `string` |  |

### ParsePercentOrFloat(string)

```csharp
float ParsePercentOrFloat(string s)
```

解析一个可能是百分比或普通浮点数字的字符串： - 如果以 '%' 结尾，则将其视为百分比并返回 0..1 区间的值 - 否则按浮点数解析并返回原始值（例如 rgba 的 alpha） 失败时返回 0。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `s` | `string` |  |

### ColorToRgbaString(SKColor)

```csharp
string ColorToRgbaString(SKColor c)
```

将 SKColor 转换为 CSS 风格的 rgba 字符串。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `c` | `SKColor` |  |

### TintColor(SKColor, float)

```csharp
SKColor TintColor(SKColor color, float ratio = 0.9f)
```

将指定颜色与白色按比例混合，生成浅色版本（Tint） 常用于： - UI 主题色的浅背景色 - Ant Design / Element 风格颜色算法 - SkiaSharp 绘制时生成柔和背景色

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `color` | `SKColor` | 原始颜色（SKColor） |
| `ratio` | `float` | 与白色混合的比例（0 ~ 1） 0 = 原色不变 1 = 纯白色 常用值： 0.9 → 非常浅的背景色（推荐） |

**返回：** 与白色混合后的浅色 SKColor
