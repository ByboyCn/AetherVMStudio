# ChartCandlestickDataItemSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

保存不可变 Candlestick 逐项配置；所有嵌套块仅通过 detached clone getter 暴露。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ChildGroupId` | 获取子组 ID。 |
| `Close` | 获取 close 原始值。 |
| `Cursor` | 获取指针光标名称。 |
| `GroupId` | 获取当前组 ID。 |
| `Highest` | 获取 highest 原始值。 |
| `Id` | 获取业务 ID。 |
| `Key` | 获取稳定键。 |
| `Lowest` | 获取 lowest 原始值。 |
| `Name` | 获取显示名称。 |
| `Open` | 获取 open 原始值。 |
| `Selected` | 获取初始选中种子。 |
| `Values` | 获取隔离的 OHLC 与辅助维向量。 |

## 方法

### `GetBlur`

创建 blur 的隔离副本。

### `GetEmphasis`

创建 emphasis 的隔离副本。

### `GetItemStyle`

创建专用常态样式的隔离副本。

### `GetLabel`

创建标签的隔离副本。

### `GetSelect`

创建 select 的隔离副本。

### `GetTooltip`

创建 Tooltip 的隔离副本。
