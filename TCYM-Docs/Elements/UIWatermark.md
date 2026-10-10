# UIWatermark

> **类型**：类　**分类**：Elements　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView`

## 概述

水印组件。 在子元素内容之上平铺半透明文字水印，支持自定义内容、旋转、间距、偏移和字体样式。 设计参考 Ant Design Watermark。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Content` | `string` | 水印文字内容（默认 "TCYM.UI"）。 |
| `WatermarkWidth` | `float` | 单个水印单元的宽度（默认 120）。 |
| `WatermarkHeight` | `float` | 单个水印单元的高度（默认 64）。 |
| `Rotate` | `float` | 水印旋转角度（默认 -22 度）。 |
| `GapX` | `float` | 水印之间的水平间距（默认 12）。 |
| `GapY` | `float` | 水印之间的垂直间距（默认 8）。 |
| `OffsetX` | `float` | 水印相对于左上角的水平偏移量。 |
| `OffsetY` | `float` | 水印相对于左上角的垂直偏移量。 |
| `FontConfig` | `WatermarkFont` | 水印字体配置。 |
| `Inherit` | `bool` | 是否继承父级水印（默认 true）。 当为 true 时，子树中的 Watermark 会合并显示。 |
| `WatermarkZIndex` | `int` | 水印层的 z-index（默认 9）。 |

## 相关类型

### WatermarkFont

> **类型**：类

水印字体配置。

| 属性 | 类型 | 说明 |
| --- | --- | --- |
| `Color` | `SKColor` | 字体颜色（默认 rgba(0,0,0,0.15)）。 |
| `FontSize` | `float` | 字号（默认 14）。 |
| `FontWeight` | `string` | 字体粗细（normal / bold）。 |
| `FontStyle` | `string` | 字体样式（normal / italic）。 |
| `FontFamily` | `string?` | 字体族名称（留空使用默认字体）。 |
