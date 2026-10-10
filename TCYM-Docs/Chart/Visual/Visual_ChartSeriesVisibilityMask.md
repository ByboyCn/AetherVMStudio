# ChartSeriesVisibilityMask

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Visual`　**Chart 版本**：`0.1.1.25`

## 概述

保存 Layout 前由 Legend 运行时选择状态投影出的系列可见性。该掩码只处理整系列目标，
数据项选择仍由 Visual 阶段的 `ChartLegendSelectionMask` 负责。

## 构造函数

### `ChartSeriesVisibilityMask(Collections.Generic.IEnumerable{Collections.Generic.KeyValuePair{TCYM.UI.Chart.Model.ChartSeriesOption,Boolean}})`

创建按系列规范身份索引的不可变可见性掩码。

| 参数 | 说明 |
| --- | --- |
| `visible` | 当前有效系列节点与可见值的集合。 |

## 方法

### `IsVisible(TCYM.UI.Chart.Model.ChartSeriesOption)`

查询系列是否可见；未列入掩码的系列默认可见。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效系列。 |

**返回：** 全部关联 Legend 均选中该系列时为 `true`。
