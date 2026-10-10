# ChartMarkSeriesSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个宿主系列在当前 Layout 候选中的全部公共 Mark 规范化结果。

## 构造函数

### `ChartMarkSeriesSnapshot(TCYM.UI.Chart.Components.Mark.ChartMarkSeriesSnapshot)`

从已冻结身份和 item 集合创建查询层独占副本。

| 参数 | 说明 |
| --- | --- |
| `source` | 待复制系列快照。 |

### `ChartMarkSeriesSnapshot(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,Boolean,Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Mark.ChartMarkPointItemSnapshot},Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Mark.ChartMarkLineItemSnapshot},Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Mark.ChartMarkAreaItemSnapshot})`

创建一个与 canonical 宿主系列绑定的不可变 Mark 快照。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前 effective 宿主系列。 |
| `seriesIndex` | 宿主系列在 effective option 中的索引。 |
| `visible` | 宿主系列经过 Show 和 Legend 过滤后的可见性。 |
| `points` | 有效 Point 项。 |
| `lines` | 有效 Line 项。 |
| `areas` | 有效 Area 项。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Areas` | 获取有效 Area 项。 |
| `Count` | 获取全部有效 Mark 项数量。 |
| `Items` | 获取按 Kind 和 Mark insideIndex 排列的全部项。 |
| `Lines` | 获取有效 Line 项。 |
| `Points` | 获取有效 Point 项。 |
| `SeriesId` | 获取宿主系列可选业务 ID。 |
| `SeriesIndex` | 获取宿主系列在 effective option 中的索引。 |
| `SeriesName` | 获取宿主系列可选名称。 |
| `SeriesRuntimeUid` | 获取宿主系列 canonical RuntimeUid。 |
| `SeriesType` | 获取宿主系列类型。 |
| `Visible` | 获取宿主系列经过 Show 和 Legend 过滤后的可见性。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断快照是否属于给定 canonical 系列或保留其身份的副本。

| 参数 | 说明 |
| --- | --- |
| `series` | 待匹配系列。 |

**返回：** RuntimeUid 相同时为 `true`。
