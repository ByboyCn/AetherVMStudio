# ChartPolarQueryRequest

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

描述一次 Polar 像素查询和可选组件过滤条件。

## 构造函数

### `ChartPolarQueryRequest(SkiaSharp.SKPoint,Nullable{Int32},String,Boolean)`

创建一个已经验证的 Polar 查询。

| 参数 | 说明 |
| --- | --- |
| `point` | 图表本地有限像素点。 |
| `polarIndex` | 可选 Polar 同主类型索引。 |
| `polarId` | 可选 Polar 组件 ID；非空时按 TCYM 已冻结的 ID-first 规则过滤。 |
| `allowOutsideSector` | 是否允许查询可见扇区之外的可逆坐标。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AllowOutsideSector` | 获取是否允许返回精确可见扇区之外的反算值。 |
| `Point` | 获取图表本地查询点。 |
| `PolarId` | 获取可选 Polar 组件 ID。 |
| `PolarIndex` | 获取可选 Polar 组件索引。 |
