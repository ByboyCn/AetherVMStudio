# ChartStatefulSymbolElement

> **类型**：class　**命名空间**：`TCYM.UI.Chart.Rendering.Symbols`　**Chart 版本**：`0.1.1.25`

## 概述

拥有一个公共 symbol 工厂图元，并为任意 path/image symbol 提供状态样式、
emphasis 缩放、旋转和一致命中的轻量包装元素。

## 说明

内容图元保持脱离场景树并由包装元素独占释放。包装元素的
`Style` 及三个状态样式是唯一视觉真源；
emphasis 缩放仅改变绘制和命中坐标，不改变原始 symbol 几何。

## 构造函数

### `ChartStatefulSymbolElement(TCYM.UI.Chart.Rendering.ChartElement,SkiaSharp.SKPoint)`

创建一个拥有指定内容和变换锚点的状态化 symbol。

| 参数 | 说明 |
| --- | --- |
| `content` | 尚未加入场景树、由包装元素接管生命周期的 symbol 图元。 |
| `center` | symbol 在包装元素局部坐标中的有限变换锚点；多数 symbol 使用几何中心，<br />`pin` 使用尖端。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Center` | 获取 emphasis 缩放使用的局部变换锚点；具体包装元素可为旋转选择其他原点。 |
| `Content` | 获取由当前包装元素独占的实际 path/image symbol 图元。 |
| `EmphasisScale` | 获取或设置 emphasis 状态的有限正缩放倍率；值为 1 时保持 normal 尺寸。 |
