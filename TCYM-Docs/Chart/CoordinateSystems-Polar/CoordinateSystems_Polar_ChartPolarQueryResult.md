# ChartPolarQueryResult

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

保存一次 Polar 点查询的规范组件身份、坐标系身份和反算数据。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AngleCoordinate` | 获取按最终 Angle range 对齐后的物理角度坐标，单位为度。 |
| `CoordinateSystemId` | 获取公开坐标系 ID。 |
| `IsInsideSector` | 获取点是否位于精确可见扇区。 |
| `LayoutId` | 获取内部稳定布局 ID。 |
| `Point` | 获取原始查询点。 |
| `PolarId` | 获取可选 Polar 组件 ID。 |
| `PolarIndex` | 获取 Polar 组件索引。 |
| `RadiusCoordinate` | 获取查询点相对 Polar 中心的像素半径。 |
| `StableOrder` | 获取布局索引分配的稳定顺序。 |
| `Value` | 获取 X=radius、Y=angle 的反算数据。 |
