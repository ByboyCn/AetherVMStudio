# ChartAxisTextLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

保存单轴的最终采样决策、全部入选标签文本以及可选名称文本；集合在构造时复制并只读公开。

## 构造函数

### `ChartAxisTextLayoutSnapshot(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,Int64,Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisTickTextLayoutSnapshot},TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisNameTextLayoutSnapshot)`

创建一根轴的同源文本快照。

| 参数 | 说明 |
| --- | --- |
| `identity` | 所属轴身份。 |
| `samplingStep` | 相邻普通入选刻度的稳定索引步长。 |
| `labels` | 已经完成 formatter 与测量的入选标签。 |
| `name` | 可选轴名称文本。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Identity` | 获取所属轴身份。 |
| `Labels` | 获取构造时复制的最终入选标签文本。 |
| `Name` | 获取可选轴名称文本。 |
| `SamplingStep` | 获取布局阶段冻结、供刻度和 view 共同复用的采样步长。 |

## 方法

### `TryGetLabel(Int32,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisTickTextLayoutSnapshot@)`

按稳定主刻度索引尝试取得已经完成布局的标签。

| 参数 | 说明 |
| --- | --- |
| `tickIndex` | 目标稳定刻度索引。 |
| `label` | 成功时得到不可变标签文本。 |

**返回：** 该刻度在布局阶段最终入选时为真。
