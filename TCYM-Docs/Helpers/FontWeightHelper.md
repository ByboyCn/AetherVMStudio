# FontWeightHelper

> **类型**：类　**分类**：Helpers　**框架版本**：`0.1.1.24`

## 概述

按字重解析字体的辅助类。 元素持有的 SKTypeface 只是字体族的默认字重；CSS font-weight 需要在渲染期 解析出同族对应字重的变体（如 Bold）。族内没有目标变体（例如 @font-face 注册的 字体文件只含常规体）时保留原字体，由调用方决定是否用 Skia 合成加粗兜底。

## 方法

### ClampWeight(float)

```csharp
int ClampWeight(float weight)
```

把字重值钳制到 CSS 合法区间（1-1000，取整）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `weight` | `float` |  |

### ResolveWeighted(SKTypeface?, float)

```csharp
SKTypeface ResolveWeighted(SKTypeface? baseTypeface, float weight)
```

在 <paramref name="baseTypeface"/> 的族内解析目标字重的变体； 已是目标字重或族内没有更近的变体时返回原字体实例。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `baseTypeface` | `SKTypeface?` |  |
| `weight` | `float` |  |

### NeedsFakeBold(SKTypeface?, float)

```csharp
bool NeedsFakeBold(SKTypeface? typeface, float weight)
```

判断是否需要 Skia 合成加粗（SKFont.Embolden）兜底： 目标是粗体量级而当前 typeface 明显更细（族内无粗体变体）时为 true。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `typeface` | `SKTypeface?` |  |
| `weight` | `float` |  |
