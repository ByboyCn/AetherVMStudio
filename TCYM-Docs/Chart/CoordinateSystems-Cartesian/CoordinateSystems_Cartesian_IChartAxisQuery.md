# IChartAxisQuery

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

定义基于已发布直角布局执行无分配最近主刻度查询的只读契约。

## 方法

### `Query(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisQueryRequest@,Span{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisQueryResult})`

按稳定轴顺序把全部匹配结果写入调用方提供的缓冲区。

| 参数 | 说明 |
| --- | --- |
| `request` | 只读查询条件。 |
| `destination` | 由调用方提供且允许为空的结果缓冲区。 |

**返回：** 实际写入的结果数量；容量不足时只写入稳定顺序中的前若干项。

### `TryQuery(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisQueryRequest@,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisQueryResult@)`

尝试从全部匹配轴中解析距离轴线最近的确定性结果。

| 参数 | 说明 |
| --- | --- |
| `request` | 只读查询条件。 |
| `result` | 成功时得到最近轴的投影值和可选最近主刻度；失败时为默认值。 |

**返回：** 至少存在一根满足过滤与投影条件、并满足当前吸附设置的轴时返回 `true`。
