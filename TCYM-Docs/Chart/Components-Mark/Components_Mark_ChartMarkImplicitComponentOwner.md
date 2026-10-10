# ChartMarkImplicitComponentOwner

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

描述 model-only 隐式 Mark 组件所服务的一个宿主系列。

## 构造函数

### `ChartMarkImplicitComponentOwner(TCYM.UI.Chart.Components.Mark.ChartMarkKind,Int64,Int32,String,String,String)`

从已冻结字段创建 owner 副本。

| 参数 | 说明 |
| --- | --- |
| `kind` | Mark 类型。 |
| `seriesRuntimeUid` | 宿主 RuntimeUid。 |
| `seriesIndex` | 宿主索引。 |
| `seriesType` | 宿主类型。 |
| `seriesId` | 宿主可选 ID。 |
| `seriesName` | 宿主可选名称。 |

### `ChartMarkImplicitComponentOwner(TCYM.UI.Chart.Components.Mark.ChartMarkKind,TCYM.UI.Chart.Model.ChartSeriesOption,Int32)`

从当前 effective 宿主系列创建隐式组件 owner。

| 参数 | 说明 |
| --- | --- |
| `kind` | 隐式 Mark 组件类型。 |
| `series` | 声明有效 Mark 数据的宿主系列。 |
| `seriesIndex` | 宿主系列索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Kind` | 获取隐式组件类型。 |
| `SeriesId` | 获取宿主系列可选 ID。 |
| `SeriesIndex` | 获取宿主系列索引。 |
| `SeriesName` | 获取宿主系列可选名称。 |
| `SeriesRuntimeUid` | 获取宿主系列 canonical RuntimeUid。 |
| `SeriesType` | 获取宿主系列类型。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断 owner 是否属于给定 canonical 系列。

| 参数 | 说明 |
| --- | --- |
| `series` | 待匹配系列。 |

**返回：** RuntimeUid 相同时为 `true`。

### `Equals(Object)`

### `Equals(TCYM.UI.Chart.Components.Mark.ChartMarkImplicitComponentOwner)`

### `GetHashCode`
