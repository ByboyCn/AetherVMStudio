# IChartItemInteractionSourceHost

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

为批量图元提供按来源隔离的逐项交互状态；实现该可选接口后，hover、action 和其他控制器
清除自己的状态时不会覆盖其他来源仍持有的相同状态位。

## 方法

### `SetItemInteractionState(Int32,TCYM.UI.Chart.Rendering.ChartInteractionState,Boolean,String)`

按来源启用或关闭指定批量数据项的一个或多个交互状态。

| 参数 | 说明 |
| --- | --- |
| `itemIndex` | 批量元素内部的数据项索引。 |
| `state` | 要修改的状态位。 |
| `enabled` | 为 `true` 时设置状态，否则仅清除该来源的状态。 |
| `sourceKey` | 区分大小写且非空白的状态来源标识。 |
