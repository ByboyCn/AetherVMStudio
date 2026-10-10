# ChartMarkAreaEndpointOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 markArea 矩形或任意二维区域的一个强类型端点。端点只描述位置、标签、图元样式和
emphasis/blur/select 三个交互状态，不公开 markPoint/markLine 专属 symbol 或线样式。

## 构造函数

### `ChartMarkAreaEndpointOption`

创建尚未指定位置的 markArea 端点。

### `ChartMarkAreaEndpointOption(TCYM.UI.Chart.Model.ChartMarkPositionOption)`

从强类型位置创建 markArea 端点。

| 参数 | 说明 |
| --- | --- |
| `position` | 端点坐标、轴简写、统计或屏幕覆盖。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 获取或设置端点 blur 状态；赋空显式重置该状态。 |
| `Emphasis` | 获取或设置端点 emphasis 状态；赋空显式重置该状态。 |
| `ItemStyle` | 获取或设置端点常态图元样式；赋空显式重置整块样式。 |
| `Label` | 获取或设置端点常态标签；赋空显式重置整块标签。 |
| `Name` | 获取或设置端点显示名称。 |
| `Position` | 获取或设置端点位置；赋空恢复尚未指定的位置。 |
| `Select` | 获取或设置端点 select 状态；赋空显式重置该状态。 |
| `Z2` | 获取或设置端点图元层级。 |

## 方法

### `Clone`

创建位置、样式、状态及自定义值载荷均隔离的端点副本。

**返回：** 内容等价的新端点。
