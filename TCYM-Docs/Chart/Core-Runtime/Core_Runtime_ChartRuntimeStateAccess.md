# ChartRuntimeStateAccess

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core.Runtime`　**Chart 版本**：`0.1.1.25`

## 概述

向所有 Engine 管理回调开放的组件与系列运行时状态只读门面。

## 方法

### `CreateComponentKey(String,TCYM.UI.Chart.Model.ChartComponentOption)`

为当前 Engine 中的规范组件身份创建一个强类型状态键。

| 参数 | 说明 |
| --- | --- |
| `name` | 模块在该组件下使用的非空槽名称。 |
| `component` | 当前回调 Option 中的组件或其保留 RuntimeUid 的副本。 |

**返回：** 同时绑定 Engine、组件身份、名称和状态类型的键。

### `CreateSeriesKey(String,TCYM.UI.Chart.Model.ChartSeriesOption)`

为当前 Engine 中的规范系列身份创建一个强类型状态键。

| 参数 | 说明 |
| --- | --- |
| `name` | 模块在该系列下使用的非空槽名称。 |
| `series` | 当前回调 Option 中的系列或其保留 RuntimeUid 的副本。 |

**返回：** 同时绑定 Engine、系列身份、名称和状态类型的键。

### `TryGet(TCYM.UI.Chart.Core.Runtime.ChartRuntimeStateKey{},@)`

尝试读取当前 Engine 已提交的状态，action 内也可读到本事务刚写入的候选值。

| 参数 | 说明 |
| --- | --- |
| `key` | 由当前 Engine 状态门面创建的键。 |
| `value` | 找到时返回状态快照。 |

**返回：** 槽存在时为 `true`。
