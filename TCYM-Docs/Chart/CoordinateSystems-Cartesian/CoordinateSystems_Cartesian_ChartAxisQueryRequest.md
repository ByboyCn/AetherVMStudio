# ChartAxisQueryRequest

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

描述一次最近坐标轴主刻度查询使用的像素点和可选过滤条件。

## 构造函数

### `ChartAxisQueryRequest(SkiaSharp.SKPoint,Nullable{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisDimension},String,Nullable{Int32},String,Boolean,Boolean)`

创建不会在执行阶段产生托管分配的坐标轴查询条件。

| 参数 | 说明 |
| --- | --- |
| `point` | 相对于图表内容区的有限像素点。 |
| `dimension` | 可选的 X 或 Y 维度过滤。 |
| `gridId` | 可选的非空白网格布局标识过滤。 |
| `componentIndex` | 可选的同类坐标轴组件索引过滤。 |
| `componentId` | 可选的非空白坐标轴组件 ID 过滤。 |
| `allowOutsideGrid` | 是否允许查询点位于目标网格边界之外。 |
| `snapToTick` | 最终轴值是否吸附到最近主刻度；默认启用。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AllowOutsideGrid` | 获取是否允许查询点位于目标网格边界之外。 |
| `ComponentId` | 获取可选的坐标轴组件 ID 过滤。 |
| `ComponentIndex` | 获取可选的同类坐标轴组件索引过滤。 |
| `Dimension` | 获取可选的 X 或 Y 维度过滤。 |
| `GridId` | 获取可选的网格布局标识过滤。 |
| `Point` | 获取相对于图表内容区的查询像素点。 |
| `SnapToTick` | 获取最终轴值是否吸附到最近主刻度；结构默认值同样返回 `true`。 |
