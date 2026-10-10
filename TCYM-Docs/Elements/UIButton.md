# UIButton

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UILabel`

## 概述

按钮控件。继承自 `UILabel`： 1. 默认文字居中 (TextAlign = center)。 2. 未定义 Hover 样式时悬停自动轻微提高背景透明度。 3. 按下时临时降低背景 Alpha形成压下效果。 4. 支持整体不透明度 Opacity（使用图层）。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Disabled` | `bool` | 是否禁用按钮。禁用后不响应点击、悬停等交互，光标变为禁止，透明度降低。 |

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

### Render(SKCanvas)

```csharp
void Render(SKCanvas canvas)
```

渲染按钮：依赖基类的渲染流程（背景/边框/内容/子元素）。 在按下时临时降低背景透明度作为视觉反馈。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `canvas` | `SKCanvas` |  |
