# ChartLegendLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Legend`　**Chart 版本**：`0.1.1.25`

## 概述

保存一次成功 Visual 阶段产生的全部 Legend 不可变布局。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Components` | 获取按 Legend 同类索引排列的全部组件快照。 |

## 方法

### `TryGet(Int32,TCYM.UI.Chart.Components.Legend.ChartLegendComponentLayoutSnapshot@)`

按 Legend 同类索引尝试取得组件快照。

| 参数 | 说明 |
| --- | --- |
| `componentIndex` | Legend 同类索引。 |
| `component` | 找到时返回组件快照。 |

**返回：** 存在对应组件时为 `true`。
