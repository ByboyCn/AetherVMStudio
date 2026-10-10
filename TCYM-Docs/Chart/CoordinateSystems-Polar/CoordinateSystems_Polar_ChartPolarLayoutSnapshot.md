# ChartPolarLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个 Polar 组件最终采用的像素中心、半径和可见角域。

## 构造函数

### `ChartPolarLayoutSnapshot(String,Int32,String,SkiaSharp.SKRect,SkiaSharp.SKPoint,Single,Single,Double,Double,Boolean,Boolean,Int32)`

创建一个已经完成 box、center、radius、angle 与有效方向解析的 Polar 布局。

| 参数 | 说明 |
| --- | --- |
| `id` | 本图表内唯一的稳定布局 ID。 |
| `componentIndex` | Polar 同主类型索引。 |
| `componentId` | 调用方提供的可选组件 ID。 |
| `containerBounds` | center/radius 百分比使用的有限容器矩形。 |
| `center` | 最终有限像素中心。 |
| `innerRadius` | 非负内半径。 |
| `outerRadius` | 不小于内半径的外半径。 |
| `startAngle` | 可见扇区起始角度。 |
| `endAngle` | 可见扇区结束角度；显式配置允许多圈。 |
| `clockwise` | option 声明的顺时针方向。 |
| `effectiveAngleInverse` | Angle 轴把 option inverse 与 clockwise 合并后的最终圆弧方向。 |
| `renderOrder` | 组件稳定绘制顺序。 |

### `ChartPolarLayoutSnapshot(String,Int32,String,SkiaSharp.SKRect,SkiaSharp.SKPoint,Single,Single,Double,Double,Boolean,Int32)`

创建一个已经完成 box、center、radius 与 angle 解析的兼容 Polar 布局；有效角度方向
按旧契约从角域端点推断。新布局处理器应使用包含 `effectiveAngleInverse` 的重载。

| 参数 | 说明 |
| --- | --- |
| `id` | 本图表内唯一的稳定布局 ID。 |
| `componentIndex` | Polar 同主类型索引。 |
| `componentId` | 调用方提供的可选组件 ID。 |
| `containerBounds` | center/radius 百分比使用的有限容器矩形。 |
| `center` | 最终有限像素中心。 |
| `innerRadius` | 非负内半径。 |
| `outerRadius` | 不小于内半径的外半径。 |
| `startAngle` | 可见扇区起始角度。 |
| `endAngle` | 可见扇区结束角度；显式配置允许多圈。 |
| `clockwise` | option 声明的顺时针方向。 |
| `renderOrder` | 组件稳定绘制顺序。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Bounds` | 获取外圆的粗包围盒。 |
| `Center` | 获取最终像素中心。 |
| `Clockwise` | 获取 option 声明的顺时针方向。 |
| `ComponentId` | 获取调用方提供的可选 Polar ID。 |
| `ComponentIndex` | 获取 Polar 同主类型索引。 |
| `ContainerBounds` | 获取 center/radius 百分比采用的最终容器矩形。 |
| `EffectiveAngleInverse` | 获取 Angle 轴把 option inverse 与 clockwise 合并后的最终圆弧方向。 |
| `EndAngle` | 获取可见角域终点。 |
| `Id` | 获取内部稳定布局 ID。 |
| `InnerRadius` | 获取最终内半径。 |
| `OuterRadius` | 获取最终外半径。 |
| `RenderOrder` | 获取组件稳定绘制顺序。 |
| `StartAngle` | 获取可见角域起点。 |
