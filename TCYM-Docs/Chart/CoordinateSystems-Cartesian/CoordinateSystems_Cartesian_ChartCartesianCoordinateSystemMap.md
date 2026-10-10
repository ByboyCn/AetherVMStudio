# ChartCartesianCoordinateSystemMap

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

按最终 X/Y 轴身份保存 Cartesian 工厂输出的独立只读坐标系快照。

## 说明

公共布局按 X 轴组件索引升序、再按 Y 轴组件索引升序解释工厂返回序列。坐标系 ID
只需在图表内唯一，不参与轴对反向推导，因此替换工厂可以自由选择 ID。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取已映射的 X/Y 轴对数量。 |

## 方法

### `TryGet(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartCartesianCoordinateSystemSnapshot@)`

按完整最终 X/Y 轴身份尝试取得隔离坐标系快照。

| 参数 | 说明 |
| --- | --- |
| `xAxis` | 最终 X 轴身份。 |
| `yAxis` | 最终 Y 轴身份。 |
| `coordinateSystem` | 成功时得到不暴露工厂具体实例的只读快照。 |

**返回：** 公共布局曾为该轴对注册坐标系时返回 `true`。
