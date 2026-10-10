# ChartCartesianGridLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

表示一个直角坐标网格已经完成计算的不可变内容区布局。

## 构造函数

### `ChartCartesianGridLayoutSnapshot(String,Int32,SkiaSharp.SKRect,Int32)`

创建具有稳定标识、组件索引、边界和绘制顺序的网格布局快照。

| 参数 | 说明 |
| --- | --- |
| `id` | 当前图表内唯一的非空白网格布局标识。 |
| `componentIndex` | 网格在有效 grid 组件序列中的零基索引。 |
| `bounds` | 规范化且只包含有限值的内容区像素边界。 |
| `renderOrder` | 用于确定多个网格稳定先后关系的布局顺序。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Bounds` | 获取网格内容区的规范化有限像素边界。 |
| `ComponentIndex` | 获取网格在有效 grid 组件序列中的零基索引。 |
| `Id` | 获取当前图表内唯一的网格布局标识。 |
| `RenderOrder` | 获取用于确定多个网格稳定先后关系的布局顺序。 |
