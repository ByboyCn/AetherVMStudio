# ChartArtifactAccess

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core.Runtime`　**Chart 版本**：`0.1.1.25`

## 概述

面向处理器及其他扩展回调的制品访问。存储存活时允许读取；写入和移除必须来自引擎创建的
精确活动处理器调用，并自动标记为该调用阶段。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取当前权限下可见的候选或已发布制品数。 |

## 方法

### `GetOrAdd(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},Func{})`

读取制品，或在当前活动处理器阶段创建借用值。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `factory` | 槽不存在时调用的工厂。 |

**返回：** 已有值或新建值。

### `GetOrAddOwned(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},Func{})`

读取制品，或在当前活动处理器阶段创建独占拥有值。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `factory` | 槽不存在时调用的工厂。 |

**返回：** 已有值或新建值。

### `GetRequired(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{})`

获取当前权限下的必需制品。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |

**返回：** 制品值或隔离快照。

### `Remove(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{})`

从当前活动处理器阶段移除制品。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |

**返回：** 槽存在并已移除时为 `true`。

### `Set(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},)`

在当前活动处理器阶段存储借用制品。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `value` | 制品值。 |

### `SetOwned(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},)`

在当前活动处理器阶段存储独占拥有制品。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `value` | 所有权转交给存储的值。 |

### `TryGet(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},@)`

尝试读取制品；非活动处理器回调只会获得隔离的只读发布视图。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `value` | 找到时返回当前权限允许的值或快照。 |

**返回：** 槽存在时为 `true`。
