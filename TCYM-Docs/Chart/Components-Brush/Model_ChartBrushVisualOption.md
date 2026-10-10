# ChartBrushVisualOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

定义数据项进入或离开 Brush 区域时可覆盖的固定颜色和透明度通道。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Color` | 获取或设置固定颜色覆盖；空值表示显式恢复 Brush 前颜色。 |
| `Opacity` | 获取或设置 0～1 的固定透明度覆盖。 |

## 方法

### `Clone`

创建值、画刷、presence 与 reset 意图均隔离的副本。

### `Reset`

显式清除颜色和透明度两个视觉通道。
