# ChartSeriesExtentArtifacts

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

集中定义公共 series extent 的每系列与全局制品键。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Snapshot` | 获取 Layout 阶段聚合后的全局范围快照键。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ContributionArtifactName` | 获取每系列贡献的稳定制品名称。 |
| `InputContributionArtifactName` | 获取具体系列在当前 Data 代次提交自定义贡献输入的稳定制品名称。 |
| `LayoutInputContributionArtifactName` | 获取 Layout 阶段在最终聚合前提交每系列迟绑定覆盖贡献的稳定制品名称。 |
| `SnapshotArtifactName` | 获取全局聚合快照的稳定制品名称。 |

## 方法

### `ForSeries(TCYM.UI.Chart.Model.ChartSeriesOption)`

按系列规范身份创建 Data 阶段贡献键。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效系列。 |

**返回：** 稳定每系列键。

### `InputForSeries(TCYM.UI.Chart.Model.ChartSeriesOption)`

按系列规范身份创建自定义 Data 输入键；具体系列必须在
`ExtentProducerLowerBound` 与
`ExtentProducerUpperBound` 范围内的同轮
Data 回调中发布。公共 collector 会验证身份、当前数据计数和轴类型，再把其中列出的轴覆盖到
公共默认贡献；未列出的绑定连续轴不会被丢弃。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效系列。 |

**返回：** 只在当前 Data 代次有效的自定义输入键。

### `LayoutInputForSeries(TCYM.UI.Chart.Model.ChartSeriesOption)`

按系列规范身份创建 Layout 迟绑定覆盖键。公共 stack 等依赖 Legend 可见性的处理器可在
`ExtentAggregation` 之前发布；
聚合器会验证系列身份、数据计数、轴集合和轴类型，再用它替换同轮 Data 贡献。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效系列。 |

**返回：** 只在当前 Layout 候选中有效的每系列覆盖键。
