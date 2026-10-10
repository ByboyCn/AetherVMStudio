# ChartLegendControlLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Legend`　**Chart 版本**：`0.1.1.25`

## 概述

保存 selector 或 scroll page 控件的不可变布局。

## 属性

| 名称 | 说明 |
| --- | --- |
| `EmphasisTextLayout` | 获取 selector 强调状态的预布局文字；非 selector 或无差异时为空。 |
| `Enabled` | 获取控件是否可触发 action。 |
| `Glyph` | 获取分页图标声明；为空表示使用方向默认箭头。 |
| `GlyphBounds` | 获取分页箭头图形区域；文字控件为空矩形。 |
| `GlyphStyle` | 获取分页箭头或其他图形使用的不可变样式。 |
| `HitBounds` | 获取控件命中区域。 |
| `Kind` | 获取控件用途。 |
| `ScrollDataIndex` | 获取分页按钮目标起始索引。 |
| `TextLayout` | 获取 selector 或页码的预布局文字。 |
| `TextX` | 获取文字元素原点 X。 |
| `TextY` | 获取文字元素原点 Y。 |
