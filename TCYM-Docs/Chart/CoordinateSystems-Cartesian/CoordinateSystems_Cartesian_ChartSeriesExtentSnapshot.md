# ChartSeriesExtentSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

保存当前 Layout 候选中全部轴的可见 series extent 联合结果。

## 构造函数

### `ChartSeriesExtentSnapshot(Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisSeriesExtent})`

创建轴身份到聚合范围的深度只读映射。

| 参数 | 说明 |
| --- | --- |
| `axes` | 不含重复轴身份的聚合范围。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取至少被一个系列贡献治理的轴数量；即使这些系列当前全部隐藏，轴仍保留空聚合项以禁止<br />回退到旧式 axis.Data。 |

## 方法

### `TryGet(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisSeriesExtent@)`

尝试按规范轴身份读取合并范围。

| 参数 | 说明 |
| --- | --- |
| `axis` | 目标轴身份。 |
| `extent` | 成功时返回聚合范围。 |

**返回：** 至少一个系列为该轴发布过贡献时为 `true`；当前可见域允许为空。
