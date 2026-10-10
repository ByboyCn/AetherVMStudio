# ChartSeriesExtentContribution

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个系列在 Data 阶段发布的不可变轴范围贡献。未来 stack、采样或自定义系列可以在公共
collector 之前通过 `InputForSeries` 发布按轴覆盖输入；
未列出的绑定连续轴仍采用公共默认贡献，具体系列不得直接修改轴 Scale。

## 构造函数

### `ChartSeriesExtentContribution(TCYM.UI.Chart.Model.ChartSeriesOption,Int32,Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartSeriesAxisExtentContribution},Int32,Int32)`

创建与系列规范身份绑定的贡献。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前 effective option 中的系列。 |
| `seriesIndex` | 系列索引。 |
| `axes` | 每根连续轴至多一项的范围贡献。 |
| `rawCount` | lineage 根数据项数量。 |
| `insideCount` | 过滤后数据项数量。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Axes` | 获取全部连续轴贡献。 |
| `InsideCount` | 获取过滤后数据项数量。 |
| `RawCount` | 获取 lineage 根数据项数量。 |
| `SeriesIndex` | 获取系列索引。 |
| `SeriesType` | 获取系列注册类型。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断贡献是否属于指定 effective 系列。

| 参数 | 说明 |
| --- | --- |
| `series` | 待匹配系列。 |

**返回：** 规范运行时身份相同时为 `true`。
