# MathHelper

> **类型**：类　**分类**：Helpers　**框架版本**：`0.1.1.24`

## 概述

数学与绘制辅助函数： - 插值（线性插值） - 颜色插值 - 过渡时长解析（支持 "200ms" / "0.18s" 等） - 绘制盒子阴影（使用 SkiaSharp） - 绘制 backdrop blur（从 UIRenderer 的当前表面采样并模糊） - 绘制背景图（size/repeat/opacity） 所有注释均为中文说明用途与行为。

## 方法

### Lerp(float, float, float)

```csharp
float Lerp(float a, float b, float t)
```

线性插值：返回 a 与 b 之间按 t 比例的值（t 在 0..1）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `a` | `float` |  |
| `b` | `float` |  |
| `t` | `float` |  |

### UsesContinuousCorners(string?)

```csharp
bool UsesContinuousCorners(string? cornerCurve)
```

是否使用连续圆角（iOS 风格）路径。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `cornerCurve` | `string?` |  |

### CreateRoundedRectPath(SKRect, float, float, float, float, bool)

```csharp
SKPath CreateRoundedRectPath(SKRect rect, float topLeftRadius, float topRightRadius, float bottomRightRadius, float bottomLeftRadius, bool continuous = false)
```

创建一个圆角矩形路径。continuous=true 时使用连续曲率近似。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `rect` | `SKRect` |  |
| `topLeftRadius` | `float` |  |
| `topRightRadius` | `float` |  |
| `bottomRightRadius` | `float` |  |
| `bottomLeftRadius` | `float` |  |
| `continuous` | `bool` |  |

### CreateRoundedBorderPath(SKRect, float, float, float, float, SKRect, float, float, float, float, bool)

```csharp
SKPath CreateRoundedBorderPath(SKRect outerRect, float outerTopLeftRadius, float outerTopRightRadius, float outerBottomRightRadius, float outerBottomLeftRadius, SKRect innerRect, float innerTopLeftRadius, float innerTopRightRadius, float innerBottomRightRadius, float innerBottomLeftRadius, bool continuous = false)
```

创建 CSS 式圆角边框环：外圆角轮廓减去内圆角轮廓。 单次 EvenOdd 填充可避免细圆弧 Stroke 在不同象限产生不一致的覆盖率。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `outerRect` | `SKRect` |  |
| `outerTopLeftRadius` | `float` |  |
| `outerTopRightRadius` | `float` |  |
| `outerBottomRightRadius` | `float` |  |
| `outerBottomLeftRadius` | `float` |  |
| `innerRect` | `SKRect` |  |
| `innerTopLeftRadius` | `float` |  |
| `innerTopRightRadius` | `float` |  |
| `innerBottomRightRadius` | `float` |  |
| `innerBottomLeftRadius` | `float` |  |
| `continuous` | `bool` |  |

### AppendRoundedRectPath(SKPathBuilder, SKRect, float, float, float, float, bool)

```csharp
void AppendRoundedRectPath(SKPathBuilder path, SKRect rect, float topLeftRadius, float topRightRadius, float bottomRightRadius, float bottomLeftRadius, bool continuous = false)
```

向现有路径追加圆角矩形轮廓。continuous=true 时使用 superellipse 近似的连续圆角。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `SKPathBuilder` |  |
| `rect` | `SKRect` |  |
| `topLeftRadius` | `float` |  |
| `topRightRadius` | `float` |  |
| `bottomRightRadius` | `float` |  |
| `bottomLeftRadius` | `float` |  |
| `continuous` | `bool` |  |

### NormalizeCornerRadii(SKRect, float, float, float, float)

```csharp
void NormalizeCornerRadii(SKRect rect, float topLeft, float topRight, float bottomRight, float bottomLeft)
```

按 CSS border-radius 规则以同一比例缩小四角，保证任一相邻半径之和 不超过对应边长。不能逐角截断到短边一半，否则非对称圆角会失真。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `rect` | `SKRect` |  |
| `topLeft` | `float` |  |
| `topRight` | `float` |  |
| `bottomRight` | `float` |  |
| `bottomLeft` | `float` |  |

### ApplyEasing(float, string)

```csharp
float ApplyEasing(float t, string easingFunction = "ease-out")
```

应用缓动函数到插值参数 t（0..1），使动画更加平滑自然。 标准关键字按 CSS 贝塞尔曲线求值，同时保留框架原有非标准别名。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `t` | `float` |  |
| `easingFunction` | `string` |  |

### LerpColor(SKColor, SKColor, float)

```csharp
SKColor LerpColor(SKColor a, SKColor b, float t)
```

线性插值用于 SKColor（对 RGBA 通道分别插值）。 注意：透明度按比例计算并返回新的 SKColor。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `a` | `SKColor` |  |
| `b` | `SKColor` |  |
| `t` | `float` |  |

### ParseTransitionDuration(string?, float)

```csharp
float ParseTransitionDuration(string? transition, float fallback)
```

解析 transition / duration 字符串，支持 "200ms", "0.18s", 或直接数字（秒）。 如果解析失败返回 fallback（若 fallback 小于等于 0 则返回 0.12f 的默认值）。 此函数与原来 UIElement 中的 ParseTransitionDuration 行为保持一致。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `transition` | `string?` |  |
| `fallback` | `float` |  |

### DrawBoxShadow(SKCanvas, SKRect, float, SKColor, float, float, float, float, bool)

```csharp
void DrawBoxShadow(SKCanvas canvas, SKRect contentRect, float borderRadius, SKColor shadowColor, float blur, float offsetX, float offsetY, float spread = 0, bool inset = false)
```

在指定的 canvas 上绘制盒子阴影（近似 CSS box-shadow）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `canvas` | `SKCanvas` | 目标画布（已在元素局部坐标系内） |
| `contentRect` | `SKRect` | 元素内容区（不含边框） |
| `borderRadius` | `float` | 圆角半径（像素） |
| `shadowColor` | `SKColor` | 阴影颜色 |
| `blur` | `float` | 模糊半径（像素），若为 0 则无模糊 |
| `offsetX` | `float` | 阴影偏移（像素）(X) |
| `offsetY` | `float` | 阴影偏移（像素）(Y) |
| `spread` | `float` | 阴影扩散（像素），正值扩大阴影范围，负值收缩 |
| `inset` | `bool` | 是否为内阴影（true 则在元素内部绘制阴影） |

### DrawBoxShadow(SKCanvas, SKRect, float, float, float, float, bool, SKColor, float, float, float, float, bool)

```csharp
void DrawBoxShadow(SKCanvas canvas, SKRect contentRect, float topLeftRadius, float topRightRadius, float bottomRightRadius, float bottomLeftRadius, bool continuousCorners, SKColor shadowColor, float blur, float offsetX, float offsetY, float spread = 0, bool inset = false)
```

使用与背景、边框相同的逐角圆角路径绘制阴影。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `canvas` | `SKCanvas` |  |
| `contentRect` | `SKRect` |  |
| `topLeftRadius` | `float` |  |
| `topRightRadius` | `float` |  |
| `bottomRightRadius` | `float` |  |
| `bottomLeftRadius` | `float` |  |
| `continuousCorners` | `bool` |  |
| `shadowColor` | `SKColor` |  |
| `blur` | `float` |  |
| `offsetX` | `float` |  |
| `offsetY` | `float` |  |
| `spread` | `float` |  |
| `inset` | `bool` |  |

### DrawBackdropBlur(SKCanvas, SKRect, float, float, float, float)

```csharp
void DrawBackdropBlur(SKCanvas canvas, SKRect contentRect, float borderRadius, float blur, float absX, float absY)
```

兼容旧调用签名；绝对坐标参数已不再需要，当前画布矩阵会自动处理平移、缩放与旋转。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `canvas` | `SKCanvas` |  |
| `contentRect` | `SKRect` |  |
| `borderRadius` | `float` |  |
| `blur` | `float` |  |
| `absX` | `float` |  |
| `absY` | `float` |  |

### DrawBackgroundImage(SKCanvas, SKImage?, SKRect, string, string, float, float, bool, float, bool, float)

```csharp
void DrawBackgroundImage(SKCanvas canvas, SKImage? image, SKRect contentRect, string backgroundSize, string backgroundRepeat, float opacity, float borderRadius, bool posXIsPercent, float posXVal, bool posYIsPercent, float posYVal)
```

绘制背景图片（优化版）：调用方传入已缓存的 SKImage，避免每帧 FromBitmap 开销。 支持 size: fill/contain/cover/auto，以及 repeat: no-repeat/repeat/repeat-x/repeat-y。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `canvas` | `SKCanvas` | 目标画布 |
| `image` | `SKImage?` | 已缓存的 SKImage（可为 null） |
| `contentRect` | `SKRect` | 内容区域 |
| `backgroundSize` | `string` | 填充策略，支持 cover/contain/fill/auto 以及显式尺寸如 80% 80%、120px auto。 |
| `backgroundRepeat` | `string` | 重复策略 |
| `opacity` | `float` | 不透明度0..1 |
| `borderRadius` | `float` | 圆角半径（裁剪用） |
| `posXIsPercent` | `bool` | X位置是否百分比 |
| `posXVal` | `float` | X 值（百分比或像素） |
| `posYIsPercent` | `bool` | Y位置是否百分比 |
| `posYVal` | `float` | Y 值（百分比或像素） |

### ParseBackgroundPosition(string?, bool, float, bool, float)

```csharp
void ParseBackgroundPosition(string? backgroundPosition, bool xIsPercent, float xVal, bool yIsPercent, float yVal)
```

解析 background-position 字符串为可复用的组件，避免每帧解析成本。 支持关键字(left/center/right/top/bottom)、百分比(eg "50%") 和像素值(eg "10px" 或 "10")。 返回值说明： - xIsPercent/xVal: 如果 xIsPercent 为 true，xVal 表示 0..100 的百分比；否则 xVal 表示像素值。 - yIsPercent/yVal: 同上，用于 Y 轴（top->0, center->50, bottom->100）

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `backgroundPosition` | `string?` |  |
| `xIsPercent` | `bool` |  |
| `xVal` | `float` |  |
| `yIsPercent` | `bool` |  |
| `yVal` | `float` |  |
