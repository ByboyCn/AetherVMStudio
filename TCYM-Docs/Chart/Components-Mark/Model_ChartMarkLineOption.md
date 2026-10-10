# ChartMarkLineOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 6.1 `markLine` 的 presence-aware 共享配置。数据集合只接受
`ChartMarkLineAxisDataItem` 或 `ChartMarkLineEndpointsDataItem`
两个强类型联合分支；官方 circle/arrow、8/16、precision=2、dashed 等默认值由 Normalize 物化。

## 构造函数

### `ChartMarkLineOption`

创建空的 markLine 配置和惰性 presence-aware 数据集合。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 获取或设置 blur 状态；赋空显式重置该状态。 |
| `Data` | 获取 line 数据集合。读取不会产生 presence；所有公开写操作都会记录数据替换或显式清空意图。 |
| `Emphasis` | 获取或设置 emphasis 状态；赋空显式重置该状态。 |
| `ItemStyle` | 获取或设置常态端点图元样式；赋空显式重置整块样式。 |
| `Label` | 获取或设置常态标签；赋空显式重置整块标签。 |
| `LineStyle` | 获取或设置常态线样式；赋空显式重置整块样式。 |
| `Precision` | 获取或设置统计标记显示值的小数精度；未指定时 Normalize 会应用 ECharts 默认值 2，<br />负数表示跳过舍入。 |
| `Select` | 获取或设置 select 状态；赋空显式重置该状态。 |
| `Symbol` | 获取或设置公共起终点 symbol 对。 |
| `SymbolOffset` | 获取或设置公共起终点 symbol 二维偏移对。 |
| `SymbolRotate` | 获取或设置公共起终点 symbol 旋转角度对。 |
| `SymbolSize` | 获取或设置公共起终点 symbol 尺寸对。 |
| `Z2` | 获取或设置常态线和端点组的局部绘制层级。 |

## 方法

### `Clone`

创建联合数据、端点、样式、状态和 presence 日志均隔离的副本。

**返回：** 内容等价的新 markLine option。
