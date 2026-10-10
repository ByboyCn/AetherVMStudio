# ChartOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

图表完整配置及 `setOption` 补丁载体。提交后引擎会先合并为 canonical 选项，再为
processor 构建可丢弃的 effective 快照；调用方不应把传入实例视为运行时模型。

## 说明

为 `ChartOption` 提供与 ECharts 顶层 JSON 字段对应的强类型组件入口；普通组件使用
首组件快捷属性，X/Y 轴使用可接收单对象或数组的稳定集合属性。
全部入口都直接读写 `Components`，不会建立第二套组件模型。
将快捷属性设为 `null` 只修改当前 `ChartOption`；普通增量
`SetOption` 不会把本地缺失自动解释为删除已提交组件。

## 构造函数

### `ChartOption`

创建一个尚未提交任何 presence 字段的空选项。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AngleAxis` | 获取或设置首个角度轴组件。多个角度轴仍可通过 `Components` 或<br />`AddComponent`` 添加。 |
| `Animation` | 获取或设置动画选项。修改子属性执行 presence-aware 部分合并；赋入一个全新且未修改的<br />实例表示显式恢复整块动画默认值。 |
| `Background` | 获取或设置图表背景。赋值操作本身会记录 presence；显式赋<br />`null` 可清除上一次 `SetOption` 继承的背景。 |
| `Brush` | 获取引用稳定的全部 Brush 实时集合，或整体设置单个 Brush、数组及 collection expression。<br />全部 IList 写操作直接写入 `Components`。 |
| `Color` | 获取调色板补丁。只有修改集合才会标记 presence，因此仅读取空集合不会覆盖旧值；<br />显式调用 `Color.Clear()` 会恢复主题调色板。 |
| `Components` | 获取非 dataset、非 series 的组件节点补丁列表。 |
| `Dataset` | 获取 dataset 节点补丁列表。 |
| `DataZoom` | 获取引用稳定的全部 dataZoom 实时集合，或整体设置单个 dataZoom、数组及<br />collection expression。全部 IList 写操作直接写入 `Components`。 |
| `Grid` | 获取或设置首个笛卡尔绘图区组件。多个 Grid 仍可通过 `Components` 或<br />`AddComponent`` 添加。 |
| `Legend` | 获取或设置首个图例组件。多个图例仍可通过 `Components` 或<br />`AddComponent`` 添加。 |
| `Polar` | 获取或设置首个极坐标组件。多个 Polar 仍可通过 `Components` 或<br />`AddComponent`` 添加。 |
| `Radar` | 获取或设置首个雷达坐标组件。多个 Radar 仍通过 `Components` 添加，<br />系列使用 RadarId 或 RadarIndex 选择目标；本属性不创建独立组件集合。 |
| `RadiusAxis` | 获取或设置首个半径轴组件。多个半径轴仍可通过 `Components` 或<br />`AddComponent`` 添加。 |
| `Series` | 获取实时系列节点列表，或整体设置单个系列、系列数组及强类型 collection expression。 |
| `Title` | 获取或设置首个标题组件。多个标题仍可通过 `Components` 或<br />`AddComponent`` 添加。 |
| `Tooltip` | 获取或设置首个提示框组件。多个提示框仍可通过 `Components` 或<br />`AddComponent`` 添加。 |
| `VisualMap` | 获取引用稳定的全部 VisualMap 实时集合，或整体设置单个 VisualMap、数组及<br />collection expression。全部 IList 写操作直接写入 `Components`。 |
| `XAxes` | 获取或整体设置全部 X 轴的过时兼容视图；新代码统一使用 `XAxis`。 |
| `XAxis` | 获取引用稳定的全部 X 轴实时集合，或整体设置单个 X 轴、X 轴数组及 collection expression。<br />集合局部顺序就是 `XAxisIndex` 顺序，全部 IList 写操作直接写入 `Components`。 |
| `YAxes` | 获取或整体设置全部 Y 轴的过时兼容视图；新代码统一使用 `YAxis`。 |
| `YAxis` | 获取引用稳定的全部 Y 轴实时集合，或整体设置单个 Y 轴、Y 轴数组及 collection expression。<br />集合局部顺序就是 `YAxisIndex` 顺序，全部 IList 写操作直接写入 `Components`。 |

## 方法

### `AddComponent()`

添加组件并返回同一实例。

| 参数 | 说明 |
| --- | --- |
| `component` | 待添加组件。 |

**返回：** `component`，便于继续配置。

### `AddSeries()`

添加系列并返回同一实例。

| 参数 | 说明 |
| --- | --- |
| `series` | 待添加系列。 |

**返回：** `series`，便于继续配置。

### `Clone`

创建与当前实例分离的选项副本。返回对象内所有 component、series、dataset 节点都会获得
新 runtime identity，因此把该副本作为新输入提交时不会别名复用当前实例拥有的持久 view。

### `GetComponents`

枚举指定类型的组件。

### `GetSeries`

枚举指定类型的系列。

### `ResetAnimation`

将动画块标记为显式重置到默认值。
