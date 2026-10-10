# ChartSeriesSelectionChangedEventPayload

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

描述一次 ECharts 风格的系列选择变更事件。

## 构造函数

### `ChartSeriesSelectionChangedEventPayload(String,Boolean,Collections.Generic.IEnumerable{TCYM.UI.Chart.Series.ChartSeriesSelectedIndices})`

创建一份不可变的选择变更事件负载。

| 参数 | 说明 |
| --- | --- |
| `fromAction` | 产生事件的 action 类型。 |
| `isFromClick` | action 是否由点击控制器产生。 |
| `selected` | 全部活动系列的非空选择索引快照。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `FromAction` | 获取产生事件的 action 类型。 |
| `IsFromClick` | 获取 action 是否由点击控制器产生。 |
| `Selected` | 获取全部活动系列的非空选择索引快照。 |
