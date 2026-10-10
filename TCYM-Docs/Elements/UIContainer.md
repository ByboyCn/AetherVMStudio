# UIContainer

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

通用容器控件。 默认按垂直方向堆叠子元素，并根据子元素测量结果计算自身尺寸。

## 方法

### base()

```csharp
UIContainer() : base()
```

初始化一个 <see cref="UIContainer"/> 实例。

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

测量容器期望尺寸。 规则：遍历子元素，宽度取最大值，高度取累加值。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` | 可用宽度。 |
| `availableHeight` | `float` | 可用高度。 |

### Layout(float, float, float, float)

```csharp
void Layout(float x, float y, float width, float height)
```

布局容器及其子元素。 当前实现沿用基类默认布局（子元素垂直堆叠）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `x` | `float` | 目标 X 坐标。 |
| `y` | `float` | 目标 Y 坐标。 |
| `width` | `float` | 目标宽度。 |
| `height` | `float` | 目标高度。 |
