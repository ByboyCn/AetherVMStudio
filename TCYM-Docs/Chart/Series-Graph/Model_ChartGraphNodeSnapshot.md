# ChartGraphNodeSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

不可变节点领域对象；样式只暴露隔离副本。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Category` | 分类名。 |
| `CategoryIndex` | 分类索引。 |
| `Fixed` | 是否固定。 |
| `Id` | 业务稳定身份。 |
| `Key` | 显式稳定键。 |
| `Name` | 显示名。 |
| `Selected` | 初始选择种子。 |
| `Symbol` | 节点符号。 |
| `SymbolRotate` | 符号旋转角度。 |
| `SymbolSize` | 节点符号尺寸。 |
| `Value` | 原始值。 |
| `X` | 初始横坐标。 |
| `Y` | 初始纵坐标。 |

## 方法

### `GetBlur`

取得淡化样式副本。

### `GetEmphasis`

取得强调样式副本。

### `GetItemStyle`

取得正常样式副本。

### `GetLabel`

取得标签副本。

### `GetSelect`

取得选择样式副本。
