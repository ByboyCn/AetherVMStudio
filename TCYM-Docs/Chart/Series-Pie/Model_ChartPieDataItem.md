# ChartPieDataItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示一个 Pie 原始数据项。Pie 的公开 inline 简写始终保存单个 value；name、逐项样式、
Label/LabelLine、Tooltip、交互状态与过渡身份会在公共数据捕获前转换为不可变快照。

## 构造函数

### `ChartPieDataItem(TCYM.UI.Chart.Data.ChartValue,String)`

从单个值和显示名称创建 Pie 数据项。

| 参数 | 说明 |
| --- | --- |
| `value` | 该扇区参与布局与百分比计算的值。 |
| `name` | 数据项显示名称，也是默认 Label、Legend 与 Tooltip 名称。 |

### `ChartPieDataItem(TCYM.UI.Chart.Data.ChartValue)`

从单个值创建 Pie 数据项。

| 参数 | 说明 |
| --- | --- |
| `value` | 该扇区参与布局与百分比计算的值。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 获取或设置逐项 blur 状态；赋空显式重置整个状态。 |
| `ChildGroupId` | 获取或设置 universal transition 钻取关系使用的子数据组 ID。 |
| `Cursor` | 获取或设置命中该数据项时建议使用的原生指针光标名称。 |
| `Emphasis` | 获取或设置逐项 emphasis 状态；赋空显式重置整个状态。 |
| `GroupId` | 获取或设置 universal transition 使用的当前数据组 ID。 |
| `Id` | 获取或设置数据项业务 ID。 |
| `ItemStyle` | 获取或设置逐项常态图元样式；赋空显式重置整块样式。 |
| `Key` | 获取或设置 TCYM 稳定 diff 键；该扩展优先于 `Id` 与 `Name`。 |
| `Label` | 获取或设置逐项常态标签；赋空显式重置整块标签。 |
| `LabelLine` | 获取或设置逐项常态标签引导线；赋空显式重置整块配置。 |
| `Name` | 获取或设置数据项显示名称。 |
| `Select` | 获取或设置逐项 select 状态；赋空显式重置整个状态。 |
| `Selected` | 获取或设置数据项是否作为公共选择管线的初始选中种子。 |
| `Tooltip` | 获取或设置逐项 CommonTooltip 覆盖；赋空显式重置整个块。 |
| `Value` | 获取唯一值。 |
| `Values` | 获取只读单值向量，供公共数据源契约消费。 |

## 方法

### `Clone`

创建值、身份、样式、状态、LabelLine 与 Tooltip 均隔离的可变副本。

**返回：** 内容等价的新 Pie 数据项。

### `CreateDataValueSnapshot`

创建与当前值内容等价、可安全发布的深度不可变快照。

**返回：** 独立的不可变快照；不得返回 `null` 或 provider 自身。

### `CreateSnapshot`

创建可由公共 RawItem 安全共享的深度不可变 Pie 数据项快照。

**返回：** 独立的 `ChartPieDataItemSnapshot`。
