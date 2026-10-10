# UIFloatButtonGroup

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

悬浮按钮组。 以垂直堆叠的形式承载多个 <see cref="UIFloatButton"/>。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Fixed` | `bool` | 是否使用 fixed 定位。 |
| `OffsetRight` | `float` | fixed 模式下距右侧偏移量。 |
| `OffsetBottom` | `float` | fixed 模式下距底部偏移量。 |
| `Gap` | `float` | 子按钮间距。 |

## 方法

### Measure(float, float)

```csharp
void Measure(float availableWidth, float availableHeight)
```

测量前把组内按钮切为相对定位，避免固定定位子项脱离组布局。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `availableWidth` | `float` |  |
| `availableHeight` | `float` |  |
