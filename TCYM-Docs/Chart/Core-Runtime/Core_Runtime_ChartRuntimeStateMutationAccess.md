# ChartRuntimeStateMutationAccess

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core.Runtime`　**Chart 版本**：`0.1.1.25`

## 概述

仅在 action 候选事务内开放的运行时状态写门面。所有写入在 handler 与 event provider 均成功后
原子提交；门面逃逸、其他回调或逐帧回调中的写入都会失败。

## 方法

### `Remove(TCYM.UI.Chart.Core.Runtime.ChartRuntimeStateKey{})`

在 action 成功提交时移除指定状态槽。

| 参数 | 说明 |
| --- | --- |
| `key` | 当前 Engine 的组件或系列状态键。 |

**返回：** 当前提交状态或本事务候选中存在该槽时为 `true`。

### `Set(TCYM.UI.Chart.Core.Runtime.ChartRuntimeStateKey{},)`

写入不可变、无需释放的状态候选；实现 `IDisposable` 的值会被拒绝。

| 参数 | 说明 |
| --- | --- |
| `key` | 当前 Engine 的组件或系列状态键。 |
| `value` | 要在 action 成功后发布的新快照。 |

### `SetOwned(TCYM.UI.Chart.Core.Runtime.ChartRuntimeStateKey{},)`

写入由 Engine 拥有的可释放不可变状态；替换、退休、回滚或释放时至多释放一次。

| 参数 | 说明 |
| --- | --- |
| `key` | 当前 Engine 的组件或系列状态键。 |
| `value` | 所有权随成功提交或候选回滚交给 Engine 的值。 |
