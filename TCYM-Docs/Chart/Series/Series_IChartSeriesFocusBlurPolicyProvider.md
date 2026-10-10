# IChartSeriesFocusBlurPolicyProvider

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

允许具体系列把自身与逐项的专属 option 合并为公共 focus/blurScope 策略。
公共交互处理器只依赖此接口，不读取 Line、Bar 等具体系列类型。

## 方法

### `GetDataItemFocusBlurPolicy(TCYM.UI.Chart.Data.ChartDataKey,Object)`

解析一个处理后数据项使用的最终策略。

| 参数 | 说明 |
| --- | --- |
| `dataKey` | 数据项在当前处理后视图中的稳定键。 |
| `rawItem` | 数据源隔离后的领域快照；具体系列可识别自己的逐项类型。 |

**返回：** 已经合并系列回退值的值类型快照。

### `GetSeriesFocusBlurPolicy`

解析系列级路径或整体 highlight 使用的最终策略。

**返回：** 不再持有可变 option 的值类型快照。
