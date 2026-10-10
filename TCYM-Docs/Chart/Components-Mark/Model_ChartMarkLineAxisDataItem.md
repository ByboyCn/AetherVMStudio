# ChartMarkLineAxisDataItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 markLine 的单对象轴值或统计数据项；运行时会把它规范化为横跨另一根 Cartesian 轴的直线。

## 构造函数

### `ChartMarkLineAxisDataItem`

创建尚未指定轴值或统计请求的单对象 markLine 数据项。

### `ChartMarkLineAxisDataItem(TCYM.UI.Chart.Model.ChartMarkLineAxisPositionOption)`

从位置或统计请求创建单对象 markLine 数据项。

| 参数 | 说明 |
| --- | --- |
| `position` | 轴简写、统计请求或屏幕覆盖。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 获取或设置 blur 状态；赋空显式重置。 |
| `Emphasis` | 获取或设置 emphasis 状态；赋空显式重置。 |
| `ItemStyle` | 获取或设置常态端点图元样式；赋空显式重置。 |
| `Label` | 获取或设置常态标签；赋空显式重置。 |
| `LineStyle` | 获取或设置常态线样式；赋空显式重置。 |
| `Position` | 获取或设置轴值、统计请求或屏幕覆盖位置。 |
| `Select` | 获取或设置 select 状态；赋空显式重置。 |
| `Symbol` | 获取或设置起终点 symbol 对。 |
| `SymbolOffset` | 获取或设置起终点 symbol 偏移对。 |
| `SymbolRotate` | 获取或设置起终点 symbol 旋转对。 |
| `SymbolSize` | 获取或设置起终点 symbol 尺寸对。 |
| `Z2` | 获取或设置整条线及端点组的图元层级。 |

## 方法

### `Clone`

创建位置、样式和状态均隔离的单对象数据项副本。

**返回：** 内容等价的新数据项。
