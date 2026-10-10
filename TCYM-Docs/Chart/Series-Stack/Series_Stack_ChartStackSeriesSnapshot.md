# ChartStackSeriesSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series.Stack`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个系列在当前 Layout 候选中的公共堆叠结果，供已开放的系列、Tooltip 和后续面积布局复用。

## 构造函数

### `ChartStackSeriesSnapshot(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,String,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,TCYM.UI.Chart.Model.ChartAxisType,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,TCYM.UI.Chart.Model.ChartAxisType,TCYM.UI.Chart.Data.ChartSeriesCoordinateSource,TCYM.UI.Chart.Data.ChartSeriesCoordinateSource,TCYM.UI.Chart.Series.Stack.ChartStackMatchKind,TCYM.UI.Chart.Model.ChartStackStrategy,TCYM.UI.Chart.Model.ChartStackOrder,Nullable{Int32},Collections.Generic.IEnumerable{TCYM.UI.Chart.Series.Stack.ChartStackItemSnapshot},TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleExtent,Int32)`

创建与一个有效系列及其当前处理后数据视图绑定的不可变堆叠快照。

| 参数 | 说明 |
| --- | --- |
| `series` | 所属有效系列。 |
| `seriesIndex` | 系列在 effective option 中的索引。 |
| `stackGroup` | 非空堆叠分组键。 |
| `baseAxis` | 跨系列匹配使用的 base 轴。 |
| `baseAxisType` | base 轴的有效类型。 |
| `valueAxis` | 累计结果投影使用的连续值轴。 |
| `valueAxisType` | 值轴的有效类型。 |
| `baseSource` | base 坐标通道的数据来源。 |
| `valueSource` | 累计值坐标通道的数据来源。 |
| `matchKind` | 跨系列匹配方式。 |
| `strategy` | 当前系列采用的正负策略。 |
| `order` | 当前兼容组采用的系列顺序。 |
| `previousSeriesIndex` | 按组顺序排列的直接前一系列索引。 |
| `items` | 与处理后 insideIndex 一一对齐的堆叠项。 |
| `resultExtent` | 过滤轴规则后的累计结果范围。 |
| `resultValidCount` | 参与累计结果范围的有效项数。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `BaseAxis` | 获取跨系列匹配使用的 base 轴身份。 |
| `BaseAxisType` | 获取 base 轴的有效类型。 |
| `BaseSource` | 获取 base 坐标通道的数据来源。 |
| `Item(Int32)` | 按处理后 insideIndex 直接读取堆叠项。 |
| `Items` | 获取与处理后 insideIndex 一一对齐的只读堆叠项。 |
| `MatchKind` | 获取不同系列数据项之间的匹配方式。 |
| `Order` | 获取当前兼容组采用的系列累计顺序。 |
| `PreviousSeriesIndex` | 获取按组顺序排列的直接前一系列索引；组内首个系列为空。 |
| `ResultExtent` | 获取应用值轴规则后的累计结果范围。 |
| `ResultValidCount` | 获取参与累计结果范围的有效项数。 |
| `SeriesIndex` | 获取系列在 effective option 中的索引。 |
| `StackGroup` | 获取非空堆叠分组键。 |
| `Strategy` | 获取当前系列选择前驱累计值时采用的正负策略。 |
| `ValueAxis` | 获取累计结果投影使用的连续值轴身份。 |
| `ValueAxisType` | 获取累计结果值轴的有效类型。 |
| `ValueSource` | 获取累计值坐标通道的数据来源。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断快照是否属于指定 effective 系列或其保留身份副本。

| 参数 | 说明 |
| --- | --- |
| `series` | 待匹配系列。 |

**返回：** 规范运行时身份相同时为 `true`。
