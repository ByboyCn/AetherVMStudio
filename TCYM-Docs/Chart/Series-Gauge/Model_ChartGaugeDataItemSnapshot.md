# ChartGaugeDataItemSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

公共数据快照中保存的深度不可变 Gauge 数据项。值载荷在构造时再次隔离，
对外只暴露只读单值向量和不可变身份字符串。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ChildGroupId` | 获取 universal transition 钻取关系使用的子数据组 ID。 |
| `GroupId` | 获取 universal transition 使用的当前数据组 ID。 |
| `Id` | 获取数据项业务 ID。 |
| `IsScalarSyntax` | 获取来源项使用标量语法。 |
| `Key` | 获取 TCYM 稳定 diff 键。 |
| `Name` | 获取数据项显示名称。 |
| `Value` | 获取唯一值。 |
| `Values` | 获取不可变单值向量。 |

## 方法

### `GetBlur`

创建逐项 blur 状态的 detached 副本。

### `GetDetail`

创建逐项数值详情覆盖的 detached 副本。

### `GetEmphasis`

创建逐项 emphasis 状态的 detached 副本。

### `GetItemStyle`

创建逐项常态样式的 detached 副本。

### `GetPointer`

创建逐项指针覆盖的 detached 副本。

### `GetProgress`

创建逐项进度弧覆盖的 detached 副本。

### `GetSelect`

创建逐项 select 状态的 detached 副本。

### `GetTitle`

创建逐项标题覆盖的 detached 副本。
