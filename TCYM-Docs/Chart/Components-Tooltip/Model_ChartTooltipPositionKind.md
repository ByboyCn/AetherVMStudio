# ChartTooltipPositionKind

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

标识 Tooltip 位置表达式的不可变种类。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `Auto` | 跟随指针，并在视口边界处自动翻转。 |
| `Box` | 通过 left、top、right、bottom 执行 box layout。 |
| `Callback` | 由强类型回调在布局时返回另一种位置表达式。 |
| `Keyword` | 相对于命中图元包围盒放置。 |
| `Point` | 使用像素或百分比二维坐标。 |
