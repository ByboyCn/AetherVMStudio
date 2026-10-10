# ChartGaugeDataItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示一个 Gauge 原始数据项。除单值与稳定身份外，可携带逐项 itemStyle、pointer、
progress、title、detail 与 emphasis/blur/select 状态。

## 构造函数

### `ChartGaugeDataItem(TCYM.UI.Chart.Data.ChartValue,String)`

从单个值和显示名称创建 Gauge 数据项。

| 参数 | 说明 |
| --- | --- |
| `value` | 仪表盘显示的值。 |
| `name` | 标题、Tooltip 和稳定身份回退使用的名称。 |

### `ChartGaugeDataItem(TCYM.UI.Chart.Data.ChartValue)`

从单个值创建 Gauge 数据项。

| 参数 | 说明 |
| --- | --- |
| `value` | 仪表盘显示的值。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 获取或设置逐项 blur 状态；赋空或空对象显式重置。 |
| `ChildGroupId` | 获取或设置 universal transition 钻取关系使用的子数据组 ID。 |
| `Detail` | 获取或设置逐项数值详情覆盖；赋空或空对象显式重置整个块。 |
| `Emphasis` | 获取或设置逐项 emphasis 状态；赋空或空对象显式重置。 |
| `GroupId` | 获取或设置 universal transition 使用的当前数据组 ID。 |
| `Id` | 获取或设置数据项业务 ID。 |
| `ItemStyle` | 获取或设置逐项常态样式；赋空或空对象显式重置整个块。 |
| `Key` | 获取或设置 TCYM 稳定 diff 键；优先级高于 ID 和名称。 |
| `Name` | 获取或设置数据项显示名称。 |
| `Pointer` | 获取或设置逐项指针覆盖；赋空或空对象显式重置整个块。 |
| `Progress` | 获取或设置逐项进度弧覆盖；赋空或空对象显式重置整个块。 |
| `Select` | 获取或设置逐项 select 状态；赋空或空对象显式重置。 |
| `Title` | 获取或设置逐项标题覆盖；赋空或空对象显式重置整个块。 |
| `Value` | 获取唯一值。 |
| `Values` | 获取只读单值向量，供公共数据源契约消费。 |

## 方法

### `Clone`

创建值和身份均隔离的可变副本。

**返回：** 内容等价的新 Gauge 数据项。

### `CreateDataValueSnapshot`

创建与当前值内容等价、可安全发布的深度不可变快照。

**返回：** 独立的不可变快照；不得返回 `null` 或 provider 自身。

### `CreateSnapshot`

创建可由公共 RawItem 安全共享的深度不可变 Gauge 数据项快照。

**返回：** 独立的不可变快照。
