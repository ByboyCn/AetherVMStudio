# ChartMarkLineEndpointOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示任意方向 markLine 的一个强类型端点。

## 构造函数

### `ChartMarkLineEndpointOption`

创建尚未指定位置的 markLine 端点。

### `ChartMarkLineEndpointOption(TCYM.UI.Chart.Model.ChartMarkPositionOption)`

从强类型位置创建 markLine 端点。

| 参数 | 说明 |
| --- | --- |
| `position` | 端点坐标、轴简写、统计或屏幕覆盖。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 获取或设置端点 blur 状态；赋空显式重置。 |
| `Emphasis` | 获取或设置端点 emphasis 状态；赋空显式重置。 |
| `ItemStyle` | 获取或设置端点常态图元样式；赋空显式重置。 |
| `Label` | 获取或设置端点常态标签；赋空显式重置。 |
| `LineStyle` | 获取或设置端点常态线样式；赋空显式重置。 |
| `Name` | 获取或设置端点显示名称。 |
| `Position` | 获取或设置端点位置。 |
| `Select` | 获取或设置端点 select 状态；赋空显式重置。 |
| `Symbol` | 获取或设置端点 symbol。 |
| `SymbolKeepAspect` | 获取或设置 image symbol 是否保持宽高比。 |
| `SymbolOffset` | 获取或设置端点 symbol 偏移。 |
| `SymbolRotate` | 获取或设置端点 symbol 的有限顺时针旋转角度。 |
| `SymbolSize` | 获取或设置端点 symbol 尺寸。 |
| `Z2` | 获取或设置端点图元层级。 |

## 方法

### `Clone`

创建位置、symbol、样式和状态均隔离的端点副本。

**返回：** 内容等价的新端点。
