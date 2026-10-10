# ChartMarkQueryRequest

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

描述一次宿主系列 Mark 查询。所有已提供选择器使用 AND 语义；Kind 与 Key 同时提供时必须一致。
Mark dataIndex 始终指 Mark option 数据块，不与宿主 raw/insideIndex 混用。

## 构造函数

### `ChartMarkQueryRequest(Nullable{TCYM.UI.Chart.Components.Mark.ChartMarkKind},Nullable{TCYM.UI.Chart.Components.Mark.ChartMarkItemKey},Nullable{Int32},Nullable{Int32},String,String,Nullable{TCYM.UI.Chart.Data.ChartDataKey},Nullable{Int32},Nullable{Int32},Nullable{Int32})`

创建包含零个或多个过滤条件的 Mark 查询。

| 参数 | 说明 |
| --- | --- |
| `kind` | 可选 Mark 类型。 |
| `key` | 可选 Mark 复合稳定键。 |
| `dataIndex` | 可选 Mark option Data 中的原始 dataIndex。 |
| `insideIndex` | 可选过滤无效项后的 Mark 连续 insideIndex。 |
| `id` | 可选 Mark 业务 ID；空字符串是合法 ID。 |
| `name` | 可选 Mark 显示名称；空字符串是合法名称。 |
| `sourceDataKey` | 可选宿主系列数据稳定键。 |
| `sourceRawIndex` | 可选宿主 lineage 根 rawIndex。 |
| `sourceDataIndex` | 可选宿主处理链 processed dataIndex。 |
| `sourceInsideIndex` | 可选宿主处理后 insideIndex。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataIndex` | 获取可选 Mark option Data 中的原始 dataIndex。 |
| `HasSelector` | 获取当前请求是否至少包含一个选择器；默认结构返回 false。 |
| `Id` | 获取可选 Mark 业务 ID。 |
| `InsideIndex` | 获取可选过滤无效项后的 Mark 连续 insideIndex。 |
| `Key` | 获取可选 Mark 复合稳定键。 |
| `Kind` | 获取可选 Mark 类型。 |
| `Name` | 获取可选显示名称。 |
| `SourceDataIndex` | 获取可选宿主处理链 processed dataIndex。 |
| `SourceDataKey` | 获取可选宿主系列数据稳定键。 |
| `SourceInsideIndex` | 获取可选宿主处理后 insideIndex。 |
| `SourceRawIndex` | 获取可选宿主 lineage 根 rawIndex。 |
