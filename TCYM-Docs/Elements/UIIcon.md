# UIIcon

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

字体图标元素

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Content` | `string` | 要显示的图标内容，通常是一个字体图标的 Unicode 字符，例如 "\uE9F3" 或 "&#xe9f3;"。 |
| `Disabled` | `bool` | 是否禁用图标。禁用后不响应点击、悬停等交互，光标变为禁止，透明度降低。 |

## 方法

### OnMouseEvent(UIMouseEvent)

```csharp
void OnMouseEvent(UIMouseEvent e)
```

禁用时屏蔽所有鼠标事件。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `e` | `UIMouseEvent` |  |

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

重新测量阶段：根据图标内容计算所需尺寸。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` | 实际可用宽度 |
| `availableHeight` | `float` | 实际可用高度 |
