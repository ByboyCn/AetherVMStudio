# ChartAxisNameTextLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

保存轴名称的不可变内容、统一布局及名称避让产生的图表坐标偏移。

## 构造函数

### `ChartAxisNameTextLayoutSnapshot(TCYM.UI.Chart.Text.ChartTextContent,TCYM.UI.Chart.Text.ChartTextLayoutResult,SkiaSharp.SKPoint)`

创建最终轴名称文本快照。

| 参数 | 说明 |
| --- | --- |
| `content` | 轴名称不可变内容。 |
| `layout` | 由同一内容产生的不可变统一文本布局。 |
| `overlapOffset` | nameMoveOverlap 计算出的有限偏移。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Content` | 获取轴名称不可变内容。 |
| `Layout` | 获取轴名称统一文本布局。 |
| `OverlapOffset` | 获取 nameMoveOverlap 沿名称外延方向产生的有限偏移。 |
