# ChartArtifactStore

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core.Runtime`　**Chart 版本**：`0.1.1.25`

## 概述

跨处理阶段共享的强类型制品存储。事务活动时，修改被路由到候选字典，同一构建内读取候选；
上一份活动字典在提交前保持不变。

## 说明

事务不可嵌套。拥有制品必须是独占的 `IDisposable` 引用；可变借用制品必须提供
`IChartArtifactSnapshot`，才能与失败候选和只读回调隔离。

## 构造函数

### `ChartArtifactStore`

创建空的制品存储。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Access` | 获取受限的处理器访问门面。与存储本身不同，该门面不能启动事务、清理阶段，<br />也不能伪造产出阶段。 |
| `Count` | 获取当前可见字典中的条目数；事务活动时为候选条目数。 |
| `IsDisposed` | 获取存储是否已释放。 |
| `PendingFaultCount` | 获取尚未由 `TryDequeueFault` 取出的清理故障数。 |
| `Version` | 获取已提交存储版本；候选内的单次修改不会单独增加此版本。 |

## 事件

| 名称 | 说明 |
| --- | --- |
| `Faulted` | 在拥有制品的 `Dispose` 抛出异常时触发。清理失败会被隔离，<br />因为它不能回滚已经应用的修改或已提交事务。 |

## 方法

### `BeginTransaction`

启动不可嵌套的候选事务。未提交即释放事务句柄会回滚；事务期间对本存储的操作
自动路由到候选字典。

**返回：** 提交或回滚当前候选的事务句柄。

### `Clear`

移除全部制品，并释放存储拥有的值。

### `ClearFrom(TCYM.UI.Chart.Core.ChartProcessorStage)`

移除在指定阶段或更晚阶段产出的制品。

| 参数 | 说明 |
| --- | --- |
| `stage` | 最早要清理的阶段。 |

### `Dispose`

回滚活动事务，释放全部拥有制品并关闭存储。

### `ForStage(TCYM.UI.Chart.Core.ChartProcessorStage)`

创建写入永久标记为指定阶段的窄门面。

| 参数 | 说明 |
| --- | --- |
| `stage` | 门面写入的产出阶段。 |

**返回：** 阶段绑定制品上下文。

### `GetOrAdd(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},Func{})`

读取制品，或在引擎当前阶段创建并存储借用值。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `factory` | 槽不存在时调用的工厂。 |

**返回：** 已有值或新建值。

### `GetOrAdd(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},TCYM.UI.Chart.Core.ChartProcessorStage,Func{},TCYM.UI.Chart.Core.Runtime.ChartArtifactOwnership)`

使用显式阶段和所有权策略读取或创建制品。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `producedAt` | 新值的产出阶段。 |
| `factory` | 槽不存在时调用的工厂。 |
| `ownership` | 新值的所有权策略。 |

**返回：** 已有值或新建值。

### `GetOrAdd(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},TCYM.UI.Chart.Core.ChartProcessorStage,Func{})`

使用显式阶段读取或创建借用制品的兼容重载。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `producedAt` | 新值的产出阶段。 |
| `factory` | 槽不存在时调用的工厂。 |

**返回：** 已有值或新建值。

### `GetOrAddOwned(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},Func{})`

读取制品，或在引擎当前阶段创建并存储独占拥有值。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `factory` | 槽不存在时调用的工厂；成功存储后所有权归存储。 |

**返回：** 已有值或新建值。

### `GetRequired(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{})`

获取必需制品，槽不存在时抛出异常。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |

**返回：** 当前可见值。

### `Remove(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{})`

移除指定槽，并按所有权策略清理被移除值。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |

**返回：** 槽存在并已移除时为 `true`。

### `Set(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},,TCYM.UI.Chart.Core.ChartProcessorStage,TCYM.UI.Chart.Core.Runtime.ChartArtifactOwnership)`

使用显式阶段和所有权策略存储制品。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `value` | 制品值。 |
| `producedAt` | 产出阶段。 |
| `ownership` | 条目离开活动集合时的所有权策略。 |

### `Set(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},,TCYM.UI.Chart.Core.ChartProcessorStage)`

使用显式产出阶段存储借用制品的兼容重载。管线集成应优先由引擎压入阶段后调用
无阶段重载，避免扩展自行声明错误阶段。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `value` | 制品值。 |
| `producedAt` | 产出阶段。 |

### `Set(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},)`

在引擎当前压入的阶段存储借用制品。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `value` | 调用方保留生命周期责任的值。 |

### `SetOwned(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},)`

在引擎当前压入的阶段存储由本存储独占拥有的制品。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `value` | 所有权转交给存储的值。 |

### `TryDequeueFault(TCYM.UI.Chart.Core.Runtime.ChartArtifactFaultEventArgs@)`

尝试取出最早记录的制品清理故障。

| 参数 | 说明 |
| --- | --- |
| `fault` | 成功时返回故障信息。 |

**返回：** 存在待处理故障时为 `true`。

### `TryGet(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},@)`

尝试读取当前可见字典中的制品。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `value` | 找到时返回值；候选事务可能返回隔离快照。 |

**返回：** 槽存在时为 `true`。
