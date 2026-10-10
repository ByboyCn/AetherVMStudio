# ChartSeriesPipelineOrders

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

冻结公共系列处理器的阶段内顺序，供具体系列的数据变换和贡献 producer 协调。

## 字段

| 名称 | 说明 |
| --- | --- |
| `CategoryDomainAggregation` | 可见系列的 category 通道聚合为轴分类域的 Layout order；必须晚于可见性与公共 stack，<br />早于 Line sampling、连续轴范围聚合和 Cartesian/Polar 最终比例尺构建。 |
| `DataSchema` | 公共处理后数据 schema 冻结并发布的 Data order。 |
| `DataTransformUpperBound` | 具体系列和通用数据变换应使用的小于或等于此值的 Data order，确保公共 schema<br />最后观察过滤后的 DataView。 |
| `ExtentAggregation` | 可见系列贡献聚合为轴范围快照的 Layout order。 |
| `ExtentContribution` | 验证自定义输入或生成默认二维比例轴 extent contribution 的 Data order。 |
| `ExtentInputReset` | 清除上一个 Data 代次留下的 schema、正式贡献和自定义输入；具体系列不得使用相同或更小<br />的 Data order。 |
| `ExtentProducerLowerBound` | 具体系列读取公共 schema 并发布自定义 extent 输入时可使用的最小 Data order。 |
| `ExtentProducerUpperBound` | 具体系列读取公共 schema 并发布自定义 extent 输入时可使用的最大 Data order。 |
| `InteractionState` | 已提交 highlight/downplay 状态投影为不可变系列交互掩码的 Visual order。<br />具体系列视觉编码应使用更大的 order 读取该掩码。 |
| `StackCalculation` | 公共 stack 在可见性确定后重算每系列累计值并发布迟绑定 extent 覆盖的 Layout order。 |
| `Visibility` | Legend 运行时选择投影为系列可见性的 Layout order。 |
