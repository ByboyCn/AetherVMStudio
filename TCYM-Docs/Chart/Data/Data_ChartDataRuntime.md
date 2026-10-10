# ChartDataRuntime

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

一份 resolved effective 选项对应的数据运行时集合。不可变 dataset store 可安全共享，
每个系列的 wrapper 与 view 独立。引擎创建的实例由 invocation-bound authority 控制写入；
通过 `Create` 创建的独立实例保留显式离线数据处理能力。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Series` | 获取按 effective 系列顺序排列的只读运行时列表。 |

## 方法

### `Create(TCYM.UI.Chart.Model.ChartOption)`

从选项创建独立数据运行时。该入口不绑定引擎 mutation authority，适合离线处理与测试。

| 参数 | 说明 |
| --- | --- |
| `option` | 用于解析 inline source 与 dataset 绑定的选项。 |

**返回：** 捕获数据源后的运行时。

### `GetSeries(Int32)`

按系列索引取得运行时。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | effective 系列索引。 |

**返回：** 指定系列的数据运行时。

### `TryGetSeries(Int32,TCYM.UI.Chart.Data.ChartSeriesDataRuntime@)`

尝试按系列索引取得运行时。

| 参数 | 说明 |
| --- | --- |
| `seriesIndex` | effective 系列索引。 |
| `data` | 成功时得到的数据运行时。 |

**返回：** 索引有效时返回 `true`。

### `TryGetSeries(TCYM.UI.Chart.Model.ChartSeriesOption,TCYM.UI.Chart.Data.ChartSeriesDataRuntime@)`

尝试按系列节点保留的 canonical RuntimeUid 取得运行时。

| 参数 | 说明 |
| --- | --- |
| `option` | 当前 effective 节点，或由同一 canonical 节点产生的保留身份副本。 |
| `data` | 成功时得到的数据运行时。 |

**返回：** 节点身份存在于当前映射时返回 `true`。
