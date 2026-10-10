# ChartMarkCoordinateValue

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示一个强类型 mark 坐标分量。统计值与同名 category 文本保持不同类型，避免把字符串
`min`、`max` 等错误解释为统计命令。

## 构造函数

### `ChartMarkCoordinateValue(TCYM.UI.Chart.Data.ChartValue)`

从一个已经隔离的普通图表值创建坐标分量。

| 参数 | 说明 |
| --- | --- |
| `value` | category、number、time 或其他图表值。 |

### `ChartMarkCoordinateValue(TCYM.UI.Chart.Model.ChartMarkStatisticType)`

从统计请求创建坐标分量。

| 参数 | 说明 |
| --- | --- |
| `statistic` | 受支持的统计类型。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Kind` | 获取当前分量的联合类型。 |

## 方法

### `Equals(Object)`

### `Equals(TCYM.UI.Chart.Model.ChartMarkCoordinateValue)`

### `GetHashCode`

### `ToString`

### `TryGetDataValue(TCYM.UI.Chart.Data.ChartValue@)`

尝试取得普通图表数据值。

| 参数 | 说明 |
| --- | --- |
| `value` | 成功时返回普通值；失败时返回空图表值。 |

**返回：** 当前分量是普通数据时返回 `true`。

### `TryGetStatistic(TCYM.UI.Chart.Model.ChartMarkStatisticType@)`

尝试取得统计请求。

| 参数 | 说明 |
| --- | --- |
| `statistic` | 成功时返回统计类型；失败时返回默认枚举值。 |

**返回：** 当前分量是统计请求时返回 `true`。
