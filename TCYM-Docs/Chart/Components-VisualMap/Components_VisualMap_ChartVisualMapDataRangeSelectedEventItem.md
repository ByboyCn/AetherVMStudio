# ChartVisualMapDataRangeSelectedEventItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.VisualMap`　**Chart 版本**：`0.1.1.25`

## 概述

保存 dataRangeSelected 中一个组件的最终结果。

## 构造函数

### `ChartVisualMapDataRangeSelectedEventItem(String,String,Int32,Collections.Generic.IEnumerable{Collections.Generic.KeyValuePair{String,Boolean}})`

创建 piecewise 事件项并深复制完整选择映射。

| 参数 | 说明 |
| --- | --- |
| `id` | 组件 ID。 |
| `name` | 组件名称。 |
| `index` | 同主类型索引。 |
| `selected` | 最终完整选择映射。 |

### `ChartVisualMapDataRangeSelectedEventItem(String,String,Int32,TCYM.UI.Chart.Model.ChartVisualMapRange)`

创建 continuous 事件项。

| 参数 | 说明 |
| --- | --- |
| `id` | 组件 ID。 |
| `name` | 组件名称。 |
| `index` | 同主类型索引。 |
| `range` | 最终有效范围。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Range` | 获取 continuous 最终范围。 |
| `Selected` | 获取 piecewise 完整选择映射。 |
| `VisualMapId` | 获取组件 ID。 |
| `VisualMapIndex` | 获取组件索引。 |
| `VisualMapName` | 获取组件名称。 |
