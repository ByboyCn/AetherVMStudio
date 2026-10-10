# UIView

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIElement`

## 概述

UIView：基础可视容器元素。 仅提供背景/边框/圆角等 UIElement 已实现的渲染功能，不新增内容逻辑。 用途：作为布局分组或简单的色块、面板。 可在派生类中重写 RenderContent 来添加自定义内容。

## 方法

### base()

```csharp
UIView() : base()
```

默认构造：调用基类，保持属性为初始状态。

### Render(SKCanvas)

```csharp
void Render(SKCanvas canvas)
```

渲染入口：直接调用基类 Render，执行背景、边框、内容及子元素绘制。 若需扩展绘制（例如叠加自定义图形），可在派生类中重写并在 base.Render 前后插入逻辑。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `canvas` | `SKCanvas` |  |
