# ChartImageElement

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Rendering.Symbols`　**Chart 版本**：`0.1.1.25`

## 概述

在指定局部矩形内绘制一张图片的轻量场景元素。默认独占图片生命周期，支持父级透明度、
裁剪、变换与矩形命中。

## 构造函数

### `ChartImageElement(SkiaSharp.SKImage,SkiaSharp.SKRect,Boolean)`

创建图片场景元素，并按 `ownsImage` 明确图片所有权。

| 参数 | 说明 |
| --- | --- |
| `image` | 待绘制的 Skia 图片。 |
| `destinationRect` | 元素局部坐标中的目标矩形。 |
| `ownsImage` | 为 `true` 时，构造成功即把图片所有权转交给元素，调用方不得再释放图片；<br />为 `false` 时，调用方保留所有权，并须保证图片至少存活到元素释放完成。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DestinationRect` | 获取或设置元素局部坐标中的目标矩形。 |
| `Image` | 获取待绘制图片。 |
| `OwnsImage` | 获取元素是否负责释放 `Image`；为 `false` 时，<br />图片生命周期由调用方负责。 |
| `Sampling` | 获取或设置图片缩放采样策略。 |
