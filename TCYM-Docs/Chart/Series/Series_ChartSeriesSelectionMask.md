# ChartSeriesSelectionMask

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

保存 Visual 阶段为单个系列发布的不可变选择掩码。掩码只保存源目标，因此 sampling
产生的多个 presentation 会共享同一个选择状态。

## 属性

| 名称 | 说明 |
| --- | --- |
| `IsSeriesSelected` | 获取当前是否至少有一个源数据项处于选中状态。 |
| `SelectedDataKeys` | 获取默认主数据类型中的选中稳定键。 |
| `SelectedDataTargets` | 获取全部数据类型中的选中源目标。 |
| `SeriesId` | 获取掩码所属系列显式 ID 快照。 |
| `SeriesIndex` | 获取系列在当前有效配置中的索引。 |
| `SeriesName` | 获取掩码所属系列名称快照。 |
| `SeriesRuntimeUid` | 获取掩码所属系列的规范运行时身份。 |
| `SeriesType` | 获取掩码所属系列类型快照。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断掩码是否属于给定的当前有效系列。

| 参数 | 说明 |
| --- | --- |
| `series` | 待比较的系列节点。 |

**返回：** 规范运行时身份相同时为真。

### `IsDataItemSelected(TCYM.UI.Chart.Data.ChartDataKey)`

查询默认主数据项是否处于选中状态。

| 参数 | 说明 |
| --- | --- |
| `dataKey` | 主数据项稳定键。 |

**返回：** 对应源目标位于选择集合时为真。

### `IsDataItemSelected(TCYM.UI.Chart.Series.ChartSeriesDataTarget)`

查询一个源数据或精确 presentation 目标是否处于选中状态；精确目标始终回退到其源目标，
从而保证 sampling duplicate 同源联动。

| 参数 | 说明 |
| --- | --- |
| `target` | 待查询的系列数据目标。 |

**返回：** 规范后的源目标位于选择集合时为真。
