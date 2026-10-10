# ChartTooltipItemQueryRequest

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Visual`　**Chart 版本**：`0.1.1.25`

## 概述

描述一次系列 item 查询。所有已提供条件使用 AND 语义；重复键命中时按 descriptor
StableOrder、再按输入顺序稳定选择第一项。

## 构造函数

### `ChartTooltipItemQueryRequest(TCYM.UI.Chart.Interaction.ChartTooltipTargetIdentity,Nullable{TCYM.UI.Chart.Data.ChartDataKey},Nullable{Int32},Nullable{Int32},String,String)`

创建至少包含一个过滤条件的 item 查询。

| 参数 | 说明 |
| --- | --- |
| `target` | 可选系列数据项命中身份。 |
| `dataKey` | 可选稳定数据键。 |
| `dataIndex` | 可选 lineage 根 raw 索引。 |
| `dataIndexInside` | 可选系列公开 presentation inside 索引。 |
| `name` | 可选数据项名称；空字符串是合法名称。 |
| `stableKey` | 可选 descriptor owner 内稳定键。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataIndex` | 获取可选 lineage 根 raw 索引。 |
| `DataIndexInside` | 获取系列当前公开 presentation 中的可选 inside 索引。 |
| `DataKey` | 获取可选稳定数据键。 |
| `DataType` | 获取可选数据集合类型过滤条件；空值保留旧查询语义，不增加结构体实例字段。 |
| `HasSelector` | 获取当前结构是否包含有效过滤条件；默认结构返回 false。 |
| `Name` | 获取可选数据项名称。 |
| `StableKey` | 获取可选 descriptor owner 内稳定键。 |
| `Target` | 获取可选系列数据项命中身份。 |
