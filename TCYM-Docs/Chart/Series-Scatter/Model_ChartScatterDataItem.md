# ChartScatterDataItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示一个 Scatter 原始数据项。值向量支持标量、X/Y 二维点和任意更多 dataset 维度；
值在构造时捕获，逐项视觉与交互配置在进入公共数据管线前转换为不可变快照。

## 构造函数

### `ChartScatterDataItem(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},Boolean)`

捕获值向量并保留标量和向量入口的语法差异。

### `ChartScatterDataItem(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue})`

从任意非空值向量创建 Scatter 数据项。

| 参数 | 说明 |
| --- | --- |
| `values` | 按数据维度顺序排列的值。 |

### `ChartScatterDataItem(TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue)`

从 X/Y 二维值创建 Scatter 数据项。

| 参数 | 说明 |
| --- | --- |
| `x` | 第一个值维度。 |
| `y` | 第二个值维度。 |

### `ChartScatterDataItem(TCYM.UI.Chart.Data.ChartValue)`

从一个标量创建 Scatter 数据项。

| 参数 | 说明 |
| --- | --- |
| `value` | 映射为唯一数值维度的值。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 获取或设置逐项 blur 状态；赋空显式重置整个状态。 |
| `ChildGroupId` | 获取或设置 universal transition 钻取关系使用的子数据组 ID。 |
| `Cursor` | 获取或设置命中该数据项时建议使用的原生指针光标名称。 |
| `Emphasis` | 获取或设置逐项 emphasis 状态；赋空显式重置整个状态。 |
| `GroupId` | 获取或设置 universal transition 使用的当前数据组 ID。 |
| `HasSymbol` | 获取逐项 symbol 字段是否由调用方显式声明。 |
| `HasSymbolKeepAspect` | 获取逐项 image symbol 宽高比字段是否由调用方显式声明。 |
| `HasSymbolOffset` | 获取逐项 symbol 偏移字段是否由调用方显式声明。 |
| `HasSymbolRotate` | 获取逐项 symbol 旋转字段是否由调用方显式声明。 |
| `HasSymbolSize` | 获取逐项 symbol 尺寸字段是否由调用方显式声明。 |
| `Id` | 获取或设置数据项业务 ID。 |
| `ItemStyle` | 获取或设置逐项常态图元样式；赋空显式重置整块样式。 |
| `Key` | 获取或设置 TCYM 稳定 diff 键；该扩展优先于 `Id` 与<br />`Name`。 |
| `Label` | 获取或设置逐项常态标签；赋空显式重置整块标签。 |
| `Name` | 获取或设置数据项显示名称。 |
| `Select` | 获取或设置逐项 select 状态；赋空显式重置整个状态。 |
| `Selected` | 获取或设置数据项是否作为公共选择管线的初始选中种子。 |
| `Symbol` | 获取或设置逐项 symbol 类型、路径或图片 URI。 |
| `SymbolKeepAspect` | 获取或设置逐项 image symbol 是否保持宽高比。 |
| `SymbolOffset` | 获取或设置逐项 symbol 的像素或百分比二维偏移。 |
| `SymbolRotate` | 获取或设置逐项 symbol 的顺时针有限旋转角度（度）。 |
| `SymbolSize` | 获取或设置逐项 symbol 尺寸。 |
| `Tooltip` | 获取或设置逐项 Tooltip 覆盖；赋空显式重置整个块。 |
| `Values` | 获取构造时已捕获的只读值向量。 |

## 方法

### `Clone`

创建值、身份、视觉、状态与 presence 日志均隔离的可变副本。

**返回：** 内容等价的新 Scatter 数据项。

### `CreateDataValueSnapshot`

创建与当前值内容等价、可安全发布的深度不可变快照。

**返回：** 独立的不可变快照；不得返回 `null` 或 provider 自身。

### `CreateSnapshot`

创建可由公共 RawItem 安全共享的深度不可变 Scatter 数据项快照。

**返回：** 独立的 `ChartScatterDataItemSnapshot`。
