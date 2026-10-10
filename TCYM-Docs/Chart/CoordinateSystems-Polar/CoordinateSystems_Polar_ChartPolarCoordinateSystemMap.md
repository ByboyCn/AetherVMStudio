# ChartPolarCoordinateSystemMap

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

按 Polar 组件索引保存工厂输出的独立只读坐标快照。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取已映射 Polar 数量。 |

## 方法

### `TryGet(Int32,TCYM.UI.Chart.CoordinateSystems.Polar.ChartPolarCoordinateSystemSnapshot@)`

按 Polar 同主类型索引读取独立坐标快照。

| 参数 | 说明 |
| --- | --- |
| `polarIndex` | Polar 组件索引。 |
| `coordinateSystem` | 成功时得到坐标快照。 |

**返回：** 工厂为该 Polar 发布坐标时为 `true`。
