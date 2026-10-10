# ChartSeriesInteractionIndexMap

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

把系列公开 presentation 的 `dataIndexInside` 映射回源稳定键与可选精确 presentation 身份。
未改变数据顺序的系列无需发布该制品；sampling、聚合或其他私有输出视图可用它保持
event/action 往返一致。

## 构造函数

### `ChartSeriesInteractionIndexMap(TCYM.UI.Chart.Model.ChartSeriesOption,Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartDataKey})`

创建一份与当前规范系列绑定的不可变 inside 索引映射。

| 参数 | 说明 |
| --- | --- |
| `series` | 拥有该 presentation 的当前有效系列。 |
| `dataKeys` | 按公开 dataIndexInside 顺序排列的源数据稳定键。 |

### `ChartSeriesInteractionIndexMap(TCYM.UI.Chart.Model.ChartSeriesOption,TCYM.UI.Chart.Series.ChartSeriesDataTarget[])`

复制并验证复合目标序列，同时避免与旧稳定键构造函数产生集合表达式歧义。

| 参数 | 说明 |
| --- | --- |
| `series` | 拥有该 presentation 的当前有效系列。 |
| `dataTargets` | 按公开 inside 顺序排列的复合目标。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取公开 presentation 中的 inside 项数。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断映射是否仍属于指定规范系列。

| 参数 | 说明 |
| --- | --- |
| `series` | 待核对的当前有效系列。 |

**返回：** 系列运行时身份相同时为真。

### `FromDataTargets(TCYM.UI.Chart.Model.ChartSeriesOption,Collections.Generic.IEnumerable{TCYM.UI.Chart.Series.ChartSeriesDataTarget})`

创建一份与当前规范系列绑定的不可变复合 inside 索引映射。

| 参数 | 说明 |
| --- | --- |
| `series` | 拥有该 presentation 的当前有效系列。 |
| `dataTargets` | 按公开 dataIndexInside 顺序排列的源数据或精确 presentation 目标。 |

**返回：** 已经复制输入序列的不可变 inside 索引映射。

### `TryGetDataKey(Int32,TCYM.UI.Chart.Data.ChartDataKey@)`

尝试把公开 presentation inside 索引解析为源数据稳定键。

| 参数 | 说明 |
| --- | --- |
| `dataIndexInside` | 公开事件或 action 携带的非负 inside 索引。 |
| `dataKey` | 成功时返回处理视图中的稳定键。 |

**返回：** 索引落在当前 presentation 范围内时为真。

### `TryGetDataTarget(Int32,TCYM.UI.Chart.Series.ChartSeriesDataTarget@)`

尝试把公开 presentation inside 索引解析为源或精确 presentation 复合目标。

| 参数 | 说明 |
| --- | --- |
| `dataIndexInside` | 公开事件或 action 携带的非负 inside 索引。 |
| `dataTarget` | 成功时返回当前公开表示的复合稳定目标。 |

**返回：** 索引落在当前 presentation 范围内时为真。
