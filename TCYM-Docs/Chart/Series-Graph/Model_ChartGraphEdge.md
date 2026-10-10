# ChartGraphEdge

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

有向 Graph 边。允许环和重边；显式 Id 提供跨重排稳定身份。

## 构造函数

### `ChartGraphEdge(TCYM.UI.Chart.Model.ChartGraphEndpoint,TCYM.UI.Chart.Model.ChartGraphEndpoint)`

创建连接两个明确端点的边。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 逐边 Blur 状态；边标签使用 EdgeLabel。 |
| `Curveness` | 逐边曲率，有限值范围 -1 到 1。 |
| `Emphasis` | 逐边 Emphasis 状态；边标签使用 EdgeLabel。 |
| `Id` | 边的稳定业务身份。 |
| `Label` | 逐边标签补丁。 |
| `LineStyle` | 逐边描边样式。 |
| `Name` | 显示名称。 |
| `Select` | 逐边 Select 状态；边标签使用 EdgeLabel。 |
| `Source` | 源节点端点。 |
| `Symbol` | 逐边起终点符号覆盖；null 继承系列，显式 None 可关闭系列默认符号。 |
| `SymbolSize` | 逐边起终点屏幕逻辑像素尺寸覆盖；null 继承系列，零关闭对应端符号。 |
| `Target` | 目标节点端点。 |
| `Value` | 边原始值。 |

## 方法

### `Clone`

复制身份、值和所有样式。

### `CreateDataValueSnapshot`

创建与当前值内容等价、可安全发布的深度不可变快照。

**返回：** 独立的不可变快照；不得返回 `null` 或 provider 自身。

### `CreateSnapshot`

捕获不可变边领域对象。
