# ChartGraphNode

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

Graph 节点配置。进入数据管线后捕获为不可变快照。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 逐节点淡化状态。 |
| `Category` | 分类名称，与 CategoryIndex 互斥。 |
| `CategoryIndex` | 分类零基索引，与 Category 互斥。 |
| `Emphasis` | 逐节点强调状态。 |
| `Fixed` | 是否在力导向计算期间固定初始坐标。 |
| `Id` | 业务稳定身份，也是字符串边端点优先使用的名称。 |
| `ItemStyle` | 逐节点正常样式。 |
| `Key` | 显式稳定键，优先于业务 ID。 |
| `Label` | 逐节点标签。 |
| `Name` | 显示名；没有匹配 ID 时边端点可按唯一显示名解析。 |
| `Select` | 逐节点选择状态。 |
| `Selected` | 初始选择种子。 |
| `Symbol` | 逐节点符号声明。 |
| `SymbolRotate` | 逐节点符号角度。 |
| `SymbolSize` | 逐节点符号尺寸。 |
| `Value` | 节点原始值。 |
| `X` | 相对图表视口左边的逻辑像素横坐标。 |
| `Y` | 相对图表视口顶边的逻辑像素纵坐标。 |

## 方法

### `Clone`

创建隔离的可修改副本。

### `CreateDataValueSnapshot`

创建与当前值内容等价、可安全发布的深度不可变快照。

**返回：** 独立的不可变快照；不得返回 `null` 或 provider 自身。

### `CreateSnapshot`

捕获不可变数据值。
