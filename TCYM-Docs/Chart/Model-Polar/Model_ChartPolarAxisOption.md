# ChartPolarAxisOption

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 `radiusAxis` 与 `angleAxis` 共享的 Polar 轴补丁；本类型不会暴露
Cartesian 专属的 GridId、GridIndex、Position 或 Offset。

## 属性

| 名称 | 说明 |
| --- | --- |
| `PolarId` | 获取或设置所属 polar 的业务 ID；显式赋空可恢复按索引绑定。 |
| `PolarIndex` | 获取或设置所属 polar 的同主类型索引；PolarId 非空时优先按 ID 绑定。 |
