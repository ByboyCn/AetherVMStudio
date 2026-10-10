# UISvg

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

UISvg：SVG 渲染组件，支持基本 SVG 元素与动画。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `SvgContent` | `string?` | SVG 内容字符串（优先级高于 Source）。 |
| `Source` | `string?` | SVG 文件路径（相对资源或绝对路径）。 |
| `SvgCss` | `string?` | SVG 样式（CSS 字符串），用于支持 .class 与 @keyframes。 |
| `SvgCssPath` | `string?` | SVG 样式文件路径（相对资源或绝对路径）。 |
| `AutoPlay` | `bool` | 是否自动播放动画。 |

## 方法

### Load()

```csharp
void Load()
```

解析并加载 SVG。

### Update(float)

```csharp
void Update(float deltaSeconds)
```

执行动画更新，自动播放时每帧调用以更新动画状态并请求重绘。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaSeconds` | `float` |  |

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

根据 SVG 自身宽高或 viewBox 计算组件测量尺寸。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` | 可用宽度。 |
| `availableHeight` | `float` | 可用高度。 |
