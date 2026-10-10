# ChartCandlestickData

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

提供 OHLC 四值、附加维与富数据项的 inline 数据源。默认维度为
open、close、lowest、highest，并声明隐式 raw-index category base 语义。

## 构造函数

### `ChartCandlestickData`

创建带默认 OHLC 维度的显式空数据源。

### `ChartCandlestickData(TCYM.UI.Chart.Data.ChartValue[])`

创建显式空数据源，或从一根至少四值的向量创建数据源。

| 参数 | 说明 |
| --- | --- |
| `values` | 空数组表示空数据；非空数组前四项为 OHLC。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取原始数据项数量。 |
| `Dimensions` | 获取可在提交前添加或调整的维度。 |
| `Items` | 获取可在提交前修改的数据项。 |
| `Relations` | 获取数据项之间的关系；表格数据通常返回空集合。 |
| `SourceTraits` | 获取当前来源声明的有效语义标记组合。 |
| `Topology` | 获取数据的逻辑拓扑。 |

## 方法

### `Add(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue})`

追加一根紧凑 OHLC 或 OHLC+辅助维向量。

### `Add(TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue)`

追加一根紧凑 OHLC 数据。

### `Add(TCYM.UI.Chart.Model.ChartCandlestickDataItem)`

追加一根富数据项。

### `AddOhlc(TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue,String,String,String)`

追加带可选Name/Id/Key的OHLC纯值项，不创建逐项样式和状态对象。

### `Clone`

创建维度、值载荷和富数据项均深度隔离的副本。

### `GetItem(Int32)`

按原始索引取得数据项。

| 参数 | 说明 |
| --- | --- |
| `rawIndex` | 数据源中的原始索引。 |

**返回：** 指定位置的数据项，不得返回 `null`。
