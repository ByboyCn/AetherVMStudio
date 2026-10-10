# IChartItemStateHost

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

批量图元按数据项维护交互状态的统一契约。

## 方法

### `ClearItemInteractionStates`

清除全部数据项的交互状态。

### `GetItemInteractionState(Int32)`

获取指定批量数据项的组合交互状态。

| 参数 | 说明 |
| --- | --- |
| `itemIndex` | 批量元素内部的数据项索引。 |

### `SetItemInteractionState(Int32,TCYM.UI.Chart.Rendering.ChartInteractionState,Boolean)`

启用或关闭指定批量数据项的一个或多个交互状态。

| 参数 | 说明 |
| --- | --- |
| `itemIndex` | 批量元素内部的数据项索引。 |
| `state` | 要修改的状态位。 |
| `enabled` | 为 `true` 时设置状态，否则清除状态。 |
