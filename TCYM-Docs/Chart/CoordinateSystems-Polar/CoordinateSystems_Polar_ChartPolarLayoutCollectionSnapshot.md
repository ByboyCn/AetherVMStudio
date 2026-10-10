# ChartPolarLayoutCollectionSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

聚合当前 Layout 候选中的全部 Polar 组件和 Radius/Angle 轴。

## 构造函数

### `ChartPolarLayoutCollectionSnapshot(Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Polar.ChartPolarLayoutSnapshot},Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Polar.ChartPolarAxisLayoutSnapshot})`

创建并验证一个深度不可变 Polar 布局集合。

| 参数 | 说明 |
| --- | --- |
| `polars` | Polar 布局。 |
| `axes` | Radius/Angle 轴布局。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Axes` | 获取全部 Radius/Angle 轴布局。 |
| `Polars` | 获取全部 Polar 布局。 |

## 方法

### `TryGetAxis(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,TCYM.UI.Chart.CoordinateSystems.Polar.ChartPolarAxisLayoutSnapshot@)`

按规范轴身份取得 Radius 或 Angle 布局。

| 参数 | 说明 |
| --- | --- |
| `identity` | 目标轴身份。 |
| `axis` | 成功时得到布局。 |

**返回：** 集合包含该轴时为 `true`。

### `TryGetPolar(Int32,TCYM.UI.Chart.CoordinateSystems.Polar.ChartPolarLayoutSnapshot@)`

按同主类型索引取得 Polar 布局。

| 参数 | 说明 |
| --- | --- |
| `componentIndex` | Polar 组件索引。 |
| `polar` | 成功时得到布局。 |

**返回：** 布局集合包含该组件索引时为 `true`。
