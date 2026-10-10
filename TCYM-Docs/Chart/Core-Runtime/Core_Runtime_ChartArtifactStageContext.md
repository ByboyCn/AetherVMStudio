# ChartArtifactStageContext

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core.Runtime`　**Chart 版本**：`0.1.1.25`

## 概述

写入固定标记为某一处理阶段的窄制品门面。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Count` | 获取当前可见制品数。 |

## 方法

### `GetOrAdd(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},Func{})`

读取制品，或在绑定阶段创建并存储借用值。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `factory` | 槽不存在时调用的工厂。 |

**返回：** 已有值或新建值。

### `GetOrAddOwned(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},Func{})`

读取制品，或在绑定阶段创建并存储独占拥有值。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `factory` | 槽不存在时调用的工厂。 |

**返回：** 已有值或新建值。

### `GetRequired(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{})`

获取必需制品。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |

**返回：** 当前可见值。

### `Remove(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{})`

移除指定制品槽。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |

**返回：** 槽存在并已移除时为 `true`。

### `Set(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},)`

在绑定阶段存储借用制品。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `value` | 制品值。 |

### `SetOwned(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},)`

在绑定阶段存储由存储独占拥有的制品。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `value` | 所有权转交给存储的值。 |

### `TryGet(TCYM.UI.Chart.Core.Runtime.ChartArtifactKey{},@)`

尝试读取当前可见制品。

| 参数 | 说明 |
| --- | --- |
| `key` | 制品键。 |
| `value` | 找到时返回值。 |

**返回：** 槽存在时为 `true`。
