# CssEasing

> **类型**：结构体　**分类**：Helpers　**框架版本**：`0.1.1.24`

## 概述

已编译的 CSS 缓动函数。标准关键字遵循 CSS Easing Level 1；默认值为 linear。 解析结果包含有界缓存，动画可直接保存此值并逐帧求值，无需重复拆分字符串。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Ease` | `CssEasing` | CSS 默认 ease，即 cubic-bezier(.25,.1,.25,1)。 |
| `Linear` | `CssEasing` | 线性缓动。 |

## 方法

### TryParse(string?, CssEasing)

```csharp
bool TryParse(string? text, CssEasing easing)
```

严格解析单个缓动函数；无效文本返回 false，不会静默替换成默认值。 同时接受框架既有的 cubic、quart、back 非标准别名以保持兼容。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `text` | `string?` |  |
| `easing` | `CssEasing` |  |

### Evaluate(float, bool)

```csharp
float Evaluate(float progress, bool before = false)
```

根据输入进度求输出进度。贝塞尔输出不钳制，可保留回弹；区间外输入按端点切线延伸。 before 仅影响阶梯精确跳点，用于 delay/backwards-fill 或反向播放的前侧边界。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `progress` | `float` |  |
| `before` | `bool` |  |
