# ChartAxisDimension

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

标识二维比例坐标轴负责的逻辑维度。

## 说明

X/Y 是 Cartesian 维度，Radius/Angle 是 Polar 维度。类型保留原名称和命名空间以兼容
M1 已发布的 Cartesian API；公共 series schema、extent、category-domain 与 stack 使用同一身份。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `Angle` | Polar 中围绕中心旋转的角度维度。 |
| `Radius` | Polar 中从中心向外增长的半径维度。 |
| `X` | 水平方向的 X 维度。 |
| `Y` | 垂直方向的 Y 维度。 |
