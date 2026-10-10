# ChartPieDataItemSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

公共数据快照中保存的不可变 Pie 逐项配置。所有可变嵌套 option 只通过克隆 getter 暴露，
因而不能反向修改已经发布的 RawItem。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ChildGroupId` | 获取 universal transition 子数据组 ID。 |
| `Cursor` | 获取建议使用的原生指针光标名称。 |
| `GroupId` | 获取 universal transition 当前数据组 ID。 |
| `Id` | 获取数据项业务 ID。 |
| `IsScalarSyntax` | 获取来源数据项为单值语法。 |
| `Key` | 获取 TCYM 稳定 diff 键。 |
| `Name` | 获取数据项显示名称。 |
| `Selected` | 获取数据项初始选择种子。 |
| `Value` | 获取唯一值。 |
| `Values` | 获取不可变单值向量。 |

## 方法

### `GetBlur`

创建逐项 blur 状态的独立副本。

### `GetEmphasis`

创建逐项 emphasis 状态的独立副本。

### `GetItemStyle`

创建逐项图元样式的独立副本。

### `GetLabel`

创建逐项标签的独立副本。

### `GetLabelLine`

创建逐项标签引导线的独立副本。

### `GetSelect`

创建逐项 select 状态的独立副本。

### `GetTooltip`

创建逐项 Tooltip 的独立副本。
