# ChartScaleExtent

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Scales`　**Chart 版本**：`0.1.1.25`

## 概述

表示比例尺的有限连续数据范围；默认值表示尚未收集到有效数据。

## 构造函数

### `ChartScaleExtent(Double,Double)`

创建包含两个有限端点的范围；端点顺序会自动规范为从小到大。

| 参数 | 说明 |
| --- | --- |
| `first` | 第一个有限端点。 |
| `second` | 第二个有限端点。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Empty` | 获取不含有效数据的空范围。 |
| `HasValues` | 获取当前范围是否已经包含至少一个有限值。 |
| `IsEmpty` | 获取当前范围是否为空。 |
| `Maximum` | 获取最大端点；范围为空时该值为零且不得参与比例尺计算。 |
| `Minimum` | 获取最小端点；范围为空时该值为零且不得参与比例尺计算。 |
| `Span` | 获取两个端点之差；范围为空时返回零。 |

## 方法

### `FromValues(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue})`

从图表值序列收集可转换的有限数值，空值和非有限值会被忽略。

| 参数 | 说明 |
| --- | --- |
| `values` | 待扫描的图表值序列。 |

**返回：** 收集后的范围；没有有效数值时返回 `Empty`。

### `Include(Double)`

把一个有限值并入范围；NaN 和 Infinity 作为缺失数据忽略。

| 参数 | 说明 |
| --- | --- |
| `value` | 待并入的数据值。 |

**返回：** 包含原范围和新值的范围，或在值无效时返回原范围。
