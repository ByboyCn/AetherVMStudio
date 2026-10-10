# ChartRadarDataItemSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

进入数据管线后的不可变 Radar 富项；嵌套选项只返回独立克隆。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Id` | 获取业务身份。 |
| `Key` | 获取显式稳定键。 |
| `Name` | 获取显示名称。 |
| `Selected` | 获取初始选择种子。 |
| `Symbol` | 获取符号声明。 |
| `SymbolKeepAspect` | 获取符号宽高比开关。 |
| `SymbolOffset` | 获取符号偏移。 |
| `SymbolRotate` | 获取符号旋转。 |
| `SymbolSize` | 获取符号尺寸。 |
| `Values` | 获取不可变原始值向量。 |

## 方法

### `GetAreaStyle`

返回隔离的 AreaStyle 副本。

### `GetBlur`

返回隔离的 Blur 副本。

### `GetEmphasis`

返回隔离的 Emphasis 副本。

### `GetItemStyle`

返回隔离的 ItemStyle 副本。

### `GetLabel`

返回隔离的 Label 副本。

### `GetLineStyle`

返回隔离的 LineStyle 副本。

### `GetSelect`

返回隔离的 Select 副本。
