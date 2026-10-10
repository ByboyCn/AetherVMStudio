# ChartMarkAreaOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 6.1 `markArea` 的 presence-aware 共享配置。数据集合只接受严格的
`ChartMarkAreaDataItem` 端点对；官方 z=1、label=top、borderWidth=0 和
animation=false 默认值由 Mark Normalize processor 在 effective option 中物化。

## 构造函数

### `ChartMarkAreaOption`

创建空的 markArea 配置和惰性 presence-aware 数据集合。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 获取或设置 blur 状态；赋空显式重置该状态。 |
| `Data` | 获取严格端点对集合。读取不会产生 presence；所有公开写操作都会记录数据替换或显式清空意图。 |
| `Emphasis` | 获取或设置 emphasis 状态；赋空显式重置该状态。 |
| `ItemStyle` | 获取或设置常态区域图元样式；赋空显式重置整块样式。 |
| `Label` | 获取或设置常态区域标签；赋空显式重置整块标签。 |
| `Precision` | 获取或设置统计区域显示值的小数精度；负数保留 ECharts 的不舍入语义。 |
| `Select` | 获取或设置 select 状态；赋空显式重置该状态。 |
| `Z2` | 获取或设置常态区域图元的局部绘制层级。 |

## 方法

### `Clone`

创建端点对、样式、状态、自定义值载荷和 presence 日志均隔离的副本。

**返回：** 内容等价的新 markArea option。
