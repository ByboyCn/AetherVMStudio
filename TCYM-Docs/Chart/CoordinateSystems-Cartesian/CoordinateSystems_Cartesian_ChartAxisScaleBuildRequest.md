# ChartAxisScaleBuildRequest

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

描述一次不依赖 option、系列或场景树的坐标轴比例尺构建请求。输入序列在构造时完成快照，
因而请求发布后可以安全跨布局候选共享。

## 构造函数

### `ChartAxisScaleBuildRequest(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisScaleBuildRequest,Boolean,Nullable{Double},Boolean,Boolean)`

复制请求并只替换分类槽位去重策略，供显式 axis.data 与系列收集域分别使用。

| 参数 | 说明 |
| --- | --- |
| `source` | 已经完成验证和输入快照的来源请求。 |
| `deduplicateCategories` | 分类比例尺是否稳定去重。 |
| `startValue` | 待保留或替换的显式轴起点。 |
| `requiresStartValue` | 待保留或替换的系列自动起点需求。 |
| `expandDegenerateFixedDomain` | 是否允许相等双固定端点扩展为单值布局域。 |

### `ChartAxisScaleBuildRequest(TCYM.UI.Chart.Model.ChartAxisType,TCYM.UI.Chart.CoordinateSystems.Scales.ChartScaleRange,Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},Nullable{TCYM.UI.Chart.Model.ChartAxisBound},Nullable{TCYM.UI.Chart.Model.ChartAxisBound},Nullable{TCYM.UI.Chart.Model.ChartAxisBoundaryGap},Boolean,Int32,Nullable{Double},Nullable{Double},Nullable{Double},Double,Boolean)`

创建统一坐标轴比例尺构建请求。

| 参数 | 说明 |
| --- | --- |
| `axisType` | value、category、time 或 log 轴类型。 |
| `range` | 有限输出范围，允许反向或零跨度。 |
| `values` | 连续轴数据；构造时复制。为空时使用空序列。 |
| `categories` | 分类轴的显式分类；构造时复制。为空时使用空序列。 |
| `minimum` | 可选最小端约束；为空表示自动端。 |
| `maximum` | 可选最大端约束；为空表示自动端。 |
| `boundaryGap` | 可选边界间隙；分类轴默认启用 band，连续轴默认零间隙。 |
| `includeZero` | value 轴是否在可修改的自动端包含零。 |
| `splitNumber` | 期望主刻度分段数，必须为一至一千。 |
| `interval` | 可选正有限显式主刻度间隔；time 使用 Unix 毫秒，log 使用指数间隔。 |
| `minimumInterval` | 可选正有限最小主刻度间隔。 |
| `maximumInterval` | 可选正有限最大主刻度间隔。 |
| `logarithmBase` | log 轴使用的大于一有限底数。 |
| `clamp` | 是否限制比例尺的正反变换。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AxisType` | 获取轴类型。 |
| `BoundaryGap` | 获取已经按轴类型补齐默认值的边界间隙。 |
| `Categories` | 获取构造时捕获并保持原顺序的只读分类数据。 |
| `Clamp` | 获取是否限制正反变换。 |
| `IncludeZero` | 获取 value 轴是否在自动端包含零。 |
| `Interval` | 获取可选显式间隔。 |
| `LogarithmBase` | 获取 log 轴底数。 |
| `Maximum` | 获取可选最大端约束；为空时该端自动计算。 |
| `MaximumInterval` | 获取可选最大间隔。 |
| `Minimum` | 获取可选最小端约束；为空时该端自动计算。 |
| `MinimumInterval` | 获取可选最小间隔。 |
| `Range` | 获取比例尺输出范围。 |
| `SplitNumber` | 获取期望主刻度分段数。 |
| `StartValue` | 获取调用方显式提供的有限轴起点；空值保留系列与轴类型的自动语义，显式 min 最终优先。 |
| `Values` | 获取构造时捕获的只读连续轴数据。 |

## 方法

### `WithStartValue(Nullable{Double},Boolean)`

复制当前不可变请求并同时替换显式起点与系列自动起点需求。

| 参数 | 说明 |
| --- | --- |
| `startValue` | 可选显式有限轴起点。 |
| `requiresStartValue` | 可见系列是否请求轴类型默认起点。 |

**返回：** 策略未改变时返回当前实例，否则返回共享已捕获输入的新请求。

### `WithStartValue(Nullable{Double})`

复制当前不可变请求并替换显式有限轴起点。

| 参数 | 说明 |
| --- | --- |
| `startValue` | 可选显式起点；空值清除先前显式起点和系列自动需求。 |

**返回：** 值未改变时返回当前实例，否则返回共享已捕获输入的新请求。
