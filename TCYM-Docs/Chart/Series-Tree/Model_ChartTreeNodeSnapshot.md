# ChartTreeNodeSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

不可变 Tree 节点及其子树；样式访问器返回隔离副本。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Children` | 不可变子节点列表。 |
| `Collapsed` | 显式初始折叠状态。 |
| `Id` | 业务身份。 |
| `Key` | 显式稳定键。 |
| `Name` | 显示名称。 |
| `Selected` | 初始选择种子。 |
| `Symbol` | 节点符号。 |
| `SymbolRotate` | 符号旋转角度。 |
| `SymbolSize` | 节点符号尺寸。 |
| `Value` | 节点原始值。 |

## 方法

### `GetBlur`

取得淡化样式副本。

### `GetEmphasis`

取得强调样式副本。

### `GetItemStyle`

取得正常样式副本。

### `GetLabel`

取得标签副本。

### `GetLineStyle`

取得入边样式副本。

### `GetSelect`

取得选择样式副本。
