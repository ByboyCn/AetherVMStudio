# ChartEncode

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示视觉通道到数据维度的映射，并保留 set/remove/clear 的 presence 日志以支持增量补丁。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Channels` | 获取通道映射的只读快照。返回集合及其维度列表均不可修改，不能绕过变更跟踪或影响后续合并。 |

## 方法

### `Clear`

显式清除从先前 `SetOption` 继承的全部通道。

### `Clone`

创建当前值与 presence 日志均独立的副本。

**返回：** 内容等价的新 encode。

### `Remove(String)`

从合并后选项移除通道。即使当前补丁实例不含该通道，也会保留删除意图。

### `Set(String,TCYM.UI.Chart.Model.ChartDimensionSelector[])`

设置或替换一个视觉通道的维度序列。

| 参数 | 说明 |
| --- | --- |
| `channel` | 通道名，例如 `x`、`y`、`tooltip`。 |
| `dimensions` | 按通道语义排列的维度选择器。 |

**返回：** 当前 encode，便于链式配置。

### `TryGet(String,Collections.Generic.IReadOnlyList{TCYM.UI.Chart.Model.ChartDimensionSelector}@)`

尝试读取一个通道的只读维度快照。

| 参数 | 说明 |
| --- | --- |
| `channel` | 通道名。 |
| `dimensions` | 成功时得到的只读维度列表；失败时为空列表。 |

**返回：** 通道存在时返回 `true`。
