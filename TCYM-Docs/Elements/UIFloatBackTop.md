# UIFloatBackTop

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIFloatButton`

## 概述

回到顶部按钮。 默认在目标滚动容器滚动超过阈值后显示，点击后滚回顶部。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Target` | `UIScrollView?` | 滚动目标。未设置时会沿父链查找最近的 <see cref="UIScrollView"/>。 |
| `VisibilityHeight` | `float` | 超过多少滚动距离后显示按钮。 |
| `ShowProgress` | `bool` | 是否在按钮边缘展示滚动进度环，参考 Ant Design BackTop 的 showProgress。 进度环绘制在按钮边框位置：已完成部分使用主色，剩余部分沿用按钮边框色。 |
| `ProgressColor` | `SKColor?` | 进度环颜色。未设置时使用主色 #1677ff。 |

## 方法

### Update(float)

```csharp
void Update(float deltaTime)
```

根据滚动位置更新可见状态。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `deltaTime` | `float` |  |
