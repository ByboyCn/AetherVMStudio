# IChartMarkQuery

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

定义每宿主系列公共 Mark 查询的只读、无分配热路径。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取可查询 Mark item 总数。 |
| `Item(Int32)` | 按稳定顺序读取查询自有 item。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断查询是否属于给定 canonical 系列。

| 参数 | 说明 |
| --- | --- |
| `series` | 待匹配系列。 |

**返回：** RuntimeUid 相同时为 `true`。

### `Query(TCYM.UI.Chart.Components.Mark.ChartMarkQueryRequest@,Span{TCYM.UI.Chart.Components.Mark.ChartMarkQueryResult})`

把全部匹配项按稳定顺序写入调用方 Span。

| 参数 | 说明 |
| --- | --- |
| `request` | 至少包含一个选择器的请求。 |
| `destination` | 接收结果的缓冲区。 |

**返回：** 实际写入的结果数量；缓冲区不足时截断。

### `TryQuery(TCYM.UI.Chart.Components.Mark.ChartMarkQueryRequest@,TCYM.UI.Chart.Components.Mark.ChartMarkQueryResult@)`

按 AND 选择器返回稳定顺序中的第一项。

| 参数 | 说明 |
| --- | --- |
| `request` | 至少包含一个选择器的请求。 |
| `result` | 成功时返回命中结果，失败时为默认结构。 |

**返回：** 至少存在一个匹配项时为 `true`。
