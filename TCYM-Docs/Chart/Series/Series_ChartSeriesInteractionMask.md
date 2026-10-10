# ChartSeriesInteractionMask

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

保存 Visual 阶段为单个系列发布的不可变 emphasis 掩码。每种数据类型的整体所有权、显式
数据项目标和整体所有权中的排除项彼此隔离；同一个来源对同一有效目标只计一次。

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataTargets` | 获取当前处理后数据视图中全部稳定逐项目标。 |
| `EmphasizedDataKeys` | 获取主数据类型中具有显式数据项所有权的稳定键；整体所有权不会展开为全部数据键。 |
| `EmphasizedDataTargets` | 获取全部数据类型中具有显式数据项所有权的复合目标；整体所有权不会展开为全部目标。 |
| `IsSeriesBlurred` | 获取系列级路径是否被至少一个 action focus 来源弱化。 |
| `IsSeriesEmphasized` | 获取当前是否至少有一个来源强调默认主数据整体。 |
| `PresentationDataTargets` | 获取当前公开 presentation 中按复合身份保存的全部逐项目标。 |
| `SeriesEmphasisOwnerCount` | 获取当前拥有默认主数据整体 emphasis 的不同来源数量。 |
| `SeriesId` | 获取掩码所属系列的可选 ID 快照。 |
| `SeriesIndex` | 获取系列在当前有效配置中的索引。 |
| `SeriesName` | 获取掩码所属系列的可选名称快照。 |
| `SeriesRuntimeUid` | 获取掩码所属系列在当前规范快照中的运行时身份。 |
| `SeriesTarget` | 获取系列级路径和整体交互使用的公共目标。 |
| `SeriesType` | 获取掩码所属系列的类型快照。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断掩码是否属于给定的当前有效系列。

| 参数 | 说明 |
| --- | --- |
| `series` | 待比较的系列节点。 |

**返回：** 运行时身份相同时为 `true`。

### `GetDataItemEmphasisOwnerCount(TCYM.UI.Chart.Data.ChartDataKey)`

取得默认主数据项的有效 emphasis 来源数，并对整体和数据项的同源所有权去重。

| 参数 | 说明 |
| --- | --- |
| `dataKey` | 主数据项稳定键。 |

**返回：** 不同来源数量。

### `GetDataItemEmphasisOwnerCount(TCYM.UI.Chart.Series.ChartSeriesDataTarget)`

取得复合数据目标的有效 emphasis 来源数，并对同类型整体和显式数据项的同源所有权去重，
同时应用来源自己创建的 item exclusion。

| 参数 | 说明 |
| --- | --- |
| `target` | 包含数据类型命名空间的目标。 |

**返回：** 不同来源数量。

### `GetDataTypeEmphasisOwnerCount(TCYM.UI.Chart.Series.ChartSeriesDataType)`

查询拥有指定数据类型整体 emphasis 的来源数量。

| 参数 | 说明 |
| --- | --- |
| `dataType` | 目标数据集合类型。 |

**返回：** 不同来源数量。

### `IsDataItemBlurred(TCYM.UI.Chart.Data.ChartDataKey)`

查询默认主数据项是否被至少一个 action focus 来源弱化。

| 参数 | 说明 |
| --- | --- |
| `dataKey` | 主数据项稳定键。 |

**返回：** 当前 Blur 联合集合包含该键时为真。

### `IsDataItemBlurred(TCYM.UI.Chart.Series.ChartSeriesDataTarget)`

查询一个源数据或精确 presentation 目标是否被 action focus 来源弱化。精确目标继承源目标
的 Blur，源目标不会反向继承某个精确表示的 Blur。

| 参数 | 说明 |
| --- | --- |
| `target` | 包含数据类型、源键与可选 presentation 身份的目标。 |

**返回：** 目标自身或其源目标位于 Blur 联合集合时为真。

### `IsDataItemEmphasized(TCYM.UI.Chart.Data.ChartDataKey)`

查询默认主数据项是否因整体或数据项来源而处于 emphasis 状态。

| 参数 | 说明 |
| --- | --- |
| `dataKey` | 主数据项稳定键。 |

**返回：** 至少一个来源拥有其 emphasis 时为 `true`。

### `IsDataItemEmphasized(TCYM.UI.Chart.Series.ChartSeriesDataTarget)`

查询复合数据目标是否因同类型整体或显式数据项来源而处于 emphasis 状态。

| 参数 | 说明 |
| --- | --- |
| `target` | 包含数据类型命名空间的目标。 |

**返回：** 至少一个来源拥有其 emphasis 时为 `true`。

### `IsDataTypeEmphasized(TCYM.UI.Chart.Series.ChartSeriesDataType)`

查询是否至少有一个来源拥有指定数据类型的整体 emphasis。

| 参数 | 说明 |
| --- | --- |
| `dataType` | 目标数据集合类型。 |

**返回：** 存在整体来源时为 `true`。

### `TryGetDataTarget(TCYM.UI.Chart.Data.ChartDataKey,TCYM.UI.Chart.Series.ChartSeriesInteractionTarget@)`

按稳定键取得公共逐项交互目标。

| 参数 | 说明 |
| --- | --- |
| `dataKey` | 主数据项稳定键。 |
| `target` | 成功时返回不持有可变 option 的公共目标。 |

**返回：** 当前处理后数据视图仍包含该键时为真。

### `TryGetDataTarget(TCYM.UI.Chart.Series.ChartSeriesDataTarget,TCYM.UI.Chart.Series.ChartSeriesInteractionTarget@)`

按源数据与可选 presentation 复合身份取得公共逐项交互目标。

| 参数 | 说明 |
| --- | --- |
| `dataTarget` | 目标数据类型、源稳定键与可选精确 presentation 身份。 |
| `target` | 成功时返回不持有可变 option 的公共目标。 |

**返回：** 当前公开 presentation 仍包含该复合目标时为真。
