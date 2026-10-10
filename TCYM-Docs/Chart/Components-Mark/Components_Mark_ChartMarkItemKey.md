# ChartMarkItemKey

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

使用 Mark 类型命名空间和该数据块内部的稳定键唯一标识一个 Mark 数据项。

## 构造函数

### `ChartMarkItemKey(TCYM.UI.Chart.Components.Mark.ChartMarkKind,TCYM.UI.Chart.Data.ChartDataKey)`

创建一个已经验证的 Mark 复合稳定键。

| 参数 | 说明 |
| --- | --- |
| `kind` | Mark 数据集合类型。 |
| `dataKey` | 该 Mark 数据块内部的稳定数据键。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DataKey` | 获取 Mark 数据块内部的稳定键；其中 RawIndex 表示 Mark option 的 dataIndex，<br />不表示宿主系列的 lineage rawIndex。 |
| `Kind` | 获取 Mark 数据集合类型。 |

## 方法

### `ToString`
