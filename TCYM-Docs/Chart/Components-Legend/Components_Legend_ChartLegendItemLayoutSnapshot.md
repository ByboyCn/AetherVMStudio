# ChartLegendItemLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Legend`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个可见 Legend item 的不可变图标、文字、命中和目标投影。

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataIndex` | 获取当前项在 Legend data 中的零基索引。 |
| `DrawLineThroughSymbol` | 获取是否先在完整图标边界绘制水平线段，再把 symbol 绘制在线段上层。 |
| `HitBounds` | 获取整项命中区域。 |
| `HoverTargets` | 获取此项允许由 Legend hover 强调的不可变目标子集。 |
| `Icon` | 获取基础图标名称。 |
| `IconBounds` | 获取图标局部边界。 |
| `ItemStyle` | 获取图标面样式。 |
| `Key` | 获取稳定图例项键。 |
| `LineStyle` | 获取图标线样式。 |
| `Name` | 获取显示名及 selection 键。 |
| `Selected` | 获取当前项是否选中。 |
| `SymbolKeepAspect` | 获取自定义 path 图标是否保持原始比例。 |
| `SymbolRotate` | 获取图标顺时针旋转角度。 |
| `Targets` | 获取此项共同控制的不可变目标集合。 |
| `TextLayout` | 获取渲染、测量和命中共享的预布局文本。 |
| `TextX` | 获取文本元素原点 X。 |
| `TextY` | 获取文本元素原点 Y。 |
| `TooltipShow` | 获取是否允许 M1.6 Tooltip 消费本项命中。 |
| `TooltipTarget` | 获取独立于控制器 Payload 的 Tooltip 稳定命中身份；未启用时为空。 |
