# ChartTreeNode

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

Tree 的可修改节点；提交时会迭代捕获完整不可变层级。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 淡化状态。 |
| `Children` | 子节点；禁止环路及多个父节点共享同一个对象。 |
| `Collapsed` | 显式初始折叠状态，优先于系列 InitialTreeDepth。 |
| `Emphasis` | 强调状态。 |
| `Id` | 业务稳定身份；整棵森林内必须唯一。 |
| `ItemStyle` | 正常节点样式。 |
| `Key` | 显式稳定键，优先于业务 ID。 |
| `Label` | 节点标签。 |
| `LineStyle` | 父节点至本节点连接线的样式。 |
| `Name` | 显示名称。 |
| `Select` | 选择状态。 |
| `Selected` | 初始选择种子。 |
| `Symbol` | 逐节点符号。 |
| `SymbolRotate` | 逐节点符号旋转角度。 |
| `SymbolSize` | 逐节点符号尺寸。 |
| `Value` | 节点原始值。 |

## 方法

### `Clone`

复制节点及全部后代；迭代实现不会因深树发生调用栈溢出。

### `CreateDataValueSnapshot`

创建与当前值内容等价、可安全发布的深度不可变快照。

**返回：** 独立的不可变快照；不得返回 `null` 或 provider 自身。

### `CreateSnapshot`

捕获当前节点和所有后代的不可变快照。
