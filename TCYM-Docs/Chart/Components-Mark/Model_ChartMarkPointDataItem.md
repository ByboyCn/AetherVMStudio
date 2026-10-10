# ChartMarkPointDataItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示一个 markPoint 数据项及其坐标、symbol、Label、样式和四状态。

## 构造函数

### `ChartMarkPointDataItem`

创建一个尚未指定位置的 markPoint 数据项。

### `ChartMarkPointDataItem(TCYM.UI.Chart.Model.ChartMarkPositionOption)`

从一个强类型位置创建 markPoint 数据项。

| 参数 | 说明 |
| --- | --- |
| `position` | 数据坐标、轴简写、统计或屏幕位置。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 获取或设置逐项 blur 状态；赋空显式重置。 |
| `Emphasis` | 获取或设置逐项 emphasis 状态；赋空显式重置。 |
| `ItemStyle` | 获取或设置逐项常态图元样式；赋空显式重置。 |
| `Label` | 获取或设置逐项常态标签；赋空显式重置。 |
| `Position` | 获取或设置位置；赋空恢复尚未指定的位置。 |
| `Select` | 获取或设置逐项 select 状态；赋空显式重置。 |
| `Symbol` | 获取或设置逐项 symbol 类型、path 或 image URI。 |
| `SymbolCallback` | 获取或设置按当前规范化数据项动态解析 symbol 的同步回调；返回空值或失败时回退到逐项或块级静态值。 |
| `SymbolKeepAspect` | 获取或设置 image symbol 是否保持宽高比。 |
| `SymbolOffset` | 获取或设置逐项 symbol 偏移。 |
| `SymbolRotate` | 获取或设置逐项 symbol 的有限顺时针旋转角度。 |
| `SymbolSize` | 获取或设置逐项 symbol 尺寸。 |
| `SymbolSizeCallback` | 获取或设置按当前规范化数据项动态解析 symbol 尺寸的同步回调；返回空值或失败时回退到逐项或块级静态值。 |
| `Tooltip` | 获取或设置逐项 Tooltip 覆盖；赋空会显式重置该数据项的 Tooltip 子块。 |
| `Z2` | 获取或设置逐项图元层级。 |

## 方法

### `Clone`

创建位置、样式、状态及自定义值载荷均隔离的副本。

**返回：** 内容等价的新数据项。
