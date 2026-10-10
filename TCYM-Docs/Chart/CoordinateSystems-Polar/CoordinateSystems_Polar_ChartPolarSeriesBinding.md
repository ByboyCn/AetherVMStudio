# ChartPolarSeriesBinding

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个系列最终绑定的 Polar、两根轴和独立坐标快照。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AngleAxis` | 获取最终 Angle 轴绑定。 |
| `CoordinateSystem` | 获取与工厂实例隔离的坐标快照。 |
| `CoordinateSystemId` | 获取最终坐标系 ID。 |
| `Polar` | 获取最终 Polar 布局。 |
| `RadiusAxis` | 获取最终 Radius 轴绑定。 |
| `SeriesIndex` | 获取系列索引。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断绑定是否仍属于指定 effective 系列。

| 参数 | 说明 |
| --- | --- |
| `series` | 待核对系列。 |

**返回：** canonical 运行时身份相同时为 `true`。

### `GetCoordinateSystem(TCYM.UI.Chart.Core.ChartBuildContext)`

在验证 Engine 身份后取得绑定自有坐标快照。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前系列处理器构建上下文。 |

**返回：** 不按 ID 二次解析的坐标系。
