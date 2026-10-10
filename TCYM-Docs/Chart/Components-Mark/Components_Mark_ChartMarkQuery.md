# ChartMarkQuery

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

每宿主系列不可变 Mark 查询。构造阶段深度复制规范化快照并预建复合键、Kind/dataIndex、名称和
宿主 lineage 索引；查询阶段不使用反射、dynamic 或表达式编译。

## 构造函数

### `ChartMarkQuery(TCYM.UI.Chart.Components.Mark.ChartMarkSeriesSnapshot)`

从每系列规范化 Mark 快照创建查询独占副本和索引。

| 参数 | 说明 |
| --- | --- |
| `series` | 待索引的不可变系列快照。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取可查询 Mark item 总数。 |
| `Item(Int32)` | 按稳定顺序读取查询自有 item。 |
| `Series` | 获取查询绑定的不可变系列快照。 |

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
