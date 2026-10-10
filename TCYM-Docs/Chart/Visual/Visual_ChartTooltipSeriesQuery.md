# ChartTooltipSeriesQuery

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Visual`　**Chart 版本**：`0.1.1.25`

## 概述

每系列不可变 Tooltip 查询制品。构造阶段验证 canonical 系列身份、深度复制 descriptor，建立
item 哈希桶以及按坐标系和轴身份分组的投影坐标二分索引；指针查询阶段不遍历系列全部数据。

## 构造函数

### `ChartTooltipSeriesQuery(TCYM.UI.Chart.Model.ChartSeriesOption,TCYM.UI.Chart.Components.Tooltip.ChartTooltipSeriesPresentation,Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Tooltip.ChartTooltipItemDescriptor},TCYM.UI.Chart.Model.ChartTooltipOption,TCYM.UI.Chart.Core.Runtime.IChartImmutableArtifact,Boolean)`

集中构造eager查询；所有权入口只由同轮内部生产器调用。

### `ChartTooltipSeriesQuery(TCYM.UI.Chart.Model.ChartSeriesOption,TCYM.UI.Chart.Components.Tooltip.ChartTooltipSeriesPresentation,Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Tooltip.ChartTooltipItemDescriptor},TCYM.UI.Chart.Model.ChartTooltipOption,TCYM.UI.Chart.Core.Runtime.IChartImmutableArtifact)`

创建携带系列级路由补丁的每系列查询制品。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前 canonical series 或保留同一 RuntimeUid 的回调副本。 |
| `presentation` | 由同一 canonical series 创建的 Tooltip presentation。 |
| `descriptors` | 该系列发布的 descriptor 集合。 |
| `seriesOptionOverride` | 只用于系列级自动路由的 Tooltip presence 补丁。 |
| `producerOwner` | 可选的本轮不可变生产者 owner，用于同代引用校验。 |

### `ChartTooltipSeriesQuery(TCYM.UI.Chart.Model.ChartSeriesOption,TCYM.UI.Chart.Components.Tooltip.ChartTooltipSeriesPresentation,Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Tooltip.ChartTooltipItemDescriptor})`

创建每系列查询制品并完成全部复制和索引工作。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前 canonical series 或保留同一 RuntimeUid 的回调副本。 |
| `presentation` | 由同一 canonical series 创建的 Tooltip presentation。 |
| `descriptors` | 该系列发布的 descriptor 集合。 |

### `ChartTooltipSeriesQuery(TCYM.UI.Chart.Model.ChartSeriesOption,TCYM.UI.Chart.Components.Tooltip.ChartTooltipSeriesPresentation,TCYM.UI.Chart.Visual.IChartTooltipSeriesQueryBackend,TCYM.UI.Chart.Model.ChartTooltipOption,Boolean,TCYM.UI.Chart.Core.Runtime.IChartImmutableArtifact)`

创建共享不可变 presentation、但拥有独立选择索引与惰性缓存的内部查询视图。

### `ChartTooltipSeriesQuery(TCYM.UI.Chart.Model.ChartSeriesOption,TCYM.UI.Chart.Components.Tooltip.ChartTooltipSeriesPresentation,TCYM.UI.Chart.Visual.IChartTooltipSeriesQueryBackendFactory,TCYM.UI.Chart.Model.ChartTooltipOption,TCYM.UI.Chart.Core.Runtime.IChartImmutableArtifact)`

创建由系列专用紧凑工厂提供数据的内部查询，仍复制 presentation 与路由补丁。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前 canonical series。 |
| `presentation` | 由同一 series 创建的 presentation。 |
| `backendFactory` | 在 presentation 复制完成后创建后端的强类型工厂。 |
| `seriesOptionOverride` | 系列级自动路由补丁。 |
| `producerOwner` | 可选的本轮不可变生产者 owner，用于同代引用校验。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取 descriptor 数量。 |
| `Item(Int32)` | 按 StableOrder 与输入顺序读取查询自有 descriptor 副本。 |
| `Presentation` | 获取与查询绑定的不可变系列 presentation 副本。 |

## 方法

### `TryQueryAxis(TCYM.UI.Chart.Visual.ChartTooltipAxisQueryRequest@,TCYM.UI.Chart.Visual.ChartTooltipAxisQueryResult@)`

对精确轴身份执行 O(logN) nearest 查询；同坐标重复项全部保留，精确中点只保留
ECharts 偏好的较小数据值一侧。

| 参数 | 说明 |
| --- | --- |
| `request` | 有限轴投影坐标与完整轴身份。 |
| `result` | 成功时指向构造期预建匹配数组；失败时为默认结构。 |

**返回：** 轴存在且最近项不超过可选最大距离时返回 true。

### `TryQueryItem(TCYM.UI.Chart.Visual.ChartTooltipItemQueryRequest@,TCYM.UI.Chart.Visual.ChartTooltipItemQueryResult@)`

按一个或多个 AND 条件解析稳定顺序中的第一项。

| 参数 | 说明 |
| --- | --- |
| `request` | 至少含一个过滤条件的只读请求。 |
| `result` | 成功时返回查询自有 descriptor；失败时为默认结构。 |

**返回：** 存在满足全部条件的 item 时返回 true。
