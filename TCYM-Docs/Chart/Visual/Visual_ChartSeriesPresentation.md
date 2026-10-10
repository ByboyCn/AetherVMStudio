# ChartSeriesPresentation

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Visual`　**Chart 版本**：`0.1.1.25`

## 概述

保存单个系列在 Visual 阶段发布给 Legend、Tooltip 等公共组件的不可变 presentation。

## 构造函数

### `ChartSeriesPresentation(TCYM.UI.Chart.Model.ChartSeriesOption,Collections.Generic.IEnumerable{TCYM.UI.Chart.Visual.ChartLegendPresentationItem})`

按系列稳定键复制并校验全部 presentation 项。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效系列或保留同一规范身份的快照。 |
| `items` | 只属于该系列的不可变 Legend 项。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Items` | 获取按系列处理器稳定顺序排列的只读 Legend 项。 |
| `SeriesId` | 获取创建 presentation 时的系列显式 ID。 |
| `SeriesName` | 获取创建 presentation 时的系列显示名称。 |
| `SeriesType` | 获取创建 presentation 时的系列注册类型。 |
