# ChartGaugeTextStyleOption

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

为 Gauge axisLabel、title 和 detail 提供 presence-aware 文本及文本框样式。
字体遵循公共 borrowed-resource 契约，画刷在 setter、Clone 和 Merge 时快照。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Align` | 获取或设置水平对齐。 |
| `BackgroundColor` | 获取或设置文本框背景画刷。 |
| `BorderColor` | 获取或设置文本框边框画刷。 |
| `BorderRadius` | 获取或设置有限非负文本框圆角。 |
| `BorderWidth` | 获取或设置有限非负文本框边框宽度。 |
| `Color` | 获取或设置文本画刷。 |
| `ColorSource` | 获取或设置 static/auto/inherit 文字颜色来源。与 `Color` 共享 presence；<br />两者同时提交时最后一次 setter 生效，空值表示显式清除。 |
| `FontSize` | 获取或设置严格大于零的有限字号。 |
| `FontWeight` | 获取或设置 1～1000 的字体粗细。 |
| `Height` | 获取或设置文本内容高度，支持非负像素、百分比或 auto。 |
| `LineHeight` | 获取或设置有限非负行高；零表示使用字体自然行高。 |
| `Padding` | 获取或设置有限非负文本框内边距。 |
| `Rich` | 获取或设置 ECharts LabelOption 富文本样式。赋值形成整体替换补丁，字典及样式会深复制；<br />赋空或清空会保留显式清除意图。 |
| `ShadowBlur` | 获取或设置有限非负阴影模糊半径。 |
| `ShadowColor` | 获取或设置文本框阴影画刷。 |
| `ShadowOffsetX` | 获取或设置有限水平阴影偏移。 |
| `ShadowOffsetY` | 获取或设置有限垂直阴影偏移。 |
| `Typeface` | 获取或设置借用的 Skia 字体；option 不取得其释放权。 |
| `VerticalAlign` | 获取或设置垂直对齐。 |
| `Width` | 获取或设置文本内容宽度，支持非负像素、百分比或 auto。 |
