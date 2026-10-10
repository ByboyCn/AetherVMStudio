# ChartCartesianSeriesBinding

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

表示一个系列已由公共 Cartesian 管线解析出的最终 grid、X/Y 轴和坐标系身份。

## 说明

绑定按系列规范运行时身份发布；ID 优先、索引次之、有效轴类型和 grid 归属只解析一次。
具体系列应在 order 大于 `SeriesBinding` 的
Layout 处理器中读取本制品。

## 属性

| 名称 | 说明 |
| --- | --- |
| `CoordinateSystem` | 获取与工厂实例和其他 Engine 隔离的只读坐标系快照；具体系列可直接执行坐标转换。 |
| `CoordinateSystemId` | 获取公共坐标系工厂发布并由独立快照保留的坐标系 ID。 |
| `Grid` | 获取 X/Y 轴共同所属的最终不可变网格布局。 |
| `SeriesIndex` | 获取系列在当前有效 option 中的索引。 |
| `XAxis` | 获取最终 X 轴绑定。 |
| `YAxis` | 获取最终 Y 轴绑定。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断绑定是否仍属于给定的规范系列节点。

| 参数 | 说明 |
| --- | --- |
| `series` | 待核对的当前有效系列。 |

**返回：** 主类型和规范运行时身份均相同时返回 `true`。

### `GetCoordinateSystem(TCYM.UI.Chart.Core.ChartBuildContext)`

在验证调用上下文属于同一 Engine 后取得本绑定自有的隔离坐标系快照。

| 参数 | 说明 |
| --- | --- |
| `context` | 正在执行具体系列处理器的构建上下文。 |

**返回：** 不会从上下文按 ID 重新解析的绑定自有快照。
