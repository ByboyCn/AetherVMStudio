# ChartLineDataItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示一个 Line 原始数据项。值向量支持单值、二维值和更多 dataset 维度，逐项视觉配置会在
进入公共数据管线前转换为不可变 `ChartLineDataItemSnapshot`。

## 构造函数

### `ChartLineDataItem(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue},Boolean)`

捕获值向量并保留调用入口的标量/向量语法差异。

| 参数 | 说明 |
| --- | --- |
| `values` | 非空值向量。 |
| `isScalarSyntax` | 是否由标量构造入口创建。 |

### `ChartLineDataItem(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue})`

从任意非空值向量创建 Line 数据项。

| 参数 | 说明 |
| --- | --- |
| `values` | 按数据维度顺序排列的值。 |

### `ChartLineDataItem(TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue)`

从 X/Y 二维值创建 Line 数据项。

| 参数 | 说明 |
| --- | --- |
| `x` | 第一个值维度。 |
| `y` | 第二个值维度。 |

### `ChartLineDataItem(TCYM.UI.Chart.Data.ChartValue)`

从一个标量创建 Line 数据项。

| 参数 | 说明 |
| --- | --- |
| `value` | 映射为唯一数值维度的值。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 获取或设置逐项 blur 状态；赋空显式重置整块状态。 |
| `ChildGroupId` | 获取或设置 universal transition 钻取关系使用的子数据组 ID。 |
| `Emphasis` | 获取或设置逐项 emphasis 状态；赋空显式重置整块状态。 |
| `EndLabel` | 获取或设置逐项常态终点标签；赋空显式重置整块标签。 |
| `GroupId` | 获取或设置 universal transition 使用的当前数据组 ID。 |
| `Id` | 获取或设置数据项业务 ID。 |
| `ItemStyle` | 获取或设置逐项常态图元样式；赋空显式重置整块样式。 |
| `Key` | 获取或设置 TCYM 稳定 diff 键；该扩展优先于 `Id` 和<br />`Name`，不是 ECharts 原始 LineDataItem 字段。 |
| `Label` | 获取或设置逐项常态标签；赋空显式重置整块标签。 |
| `Name` | 获取或设置数据项显示名称。 |
| `Select` | 获取或设置逐项 select 状态；赋空显式重置整块状态。 |
| `Selected` | 获取或设置数据项是否初始选中。 |
| `Symbol` | 获取或设置逐项 symbol 类型、路径或图片 URI。 |
| `SymbolKeepAspect` | 获取或设置逐项 image symbol 是否保持宽高比。 |
| `SymbolOffset` | 获取或设置逐项 symbol 的像素或百分比二维偏移。 |
| `SymbolRotate` | 获取或设置逐项 symbol 的顺时针有限旋转角度（度）。 |
| `SymbolSize` | 获取或设置逐项 symbol 尺寸。 |
| `Values` | 获取只读值向量。 |

## 方法

### `Clone`

创建值、样式、状态和 presence 日志均隔离的可变副本。

**返回：** 内容等价的新数据项。

### `CreateDataValueSnapshot`

创建与当前值内容等价、可安全发布的深度不可变快照。

**返回：** 独立的不可变快照；不得返回 `null` 或 provider 自身。

### `CreateSnapshot`

创建可由公共 RawItem 安全共享的深度不可变 Line 数据项快照。

**返回：** 独立的 `ChartLineDataItemSnapshot`。
