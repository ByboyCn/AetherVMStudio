# ChartCandlestickDataItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示前四维固定为 open、close、lowest、highest，并可携带辅助维的 K 线数据项。

## 构造函数

### `ChartCandlestickDataItem(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue})`

使用至少四项的 OHLC 与辅助维向量创建数据项。

| 参数 | 说明 |
| --- | --- |
| `values` | 前四项为 OHLC，后续项为辅助维。 |

### `ChartCandlestickDataItem(TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue)`

使用规范 OHLC 四值创建数据项。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 获取或设置逐项 blur；赋空重置整个块。 |
| `ChildGroupId` | 获取或设置 universal transition 子组 ID。 |
| `Close` | 获取 close 原始值。 |
| `Cursor` | 获取或设置建议的原生指针光标名称。 |
| `Emphasis` | 获取或设置逐项 emphasis；赋空重置整个块。 |
| `GroupId` | 获取或设置 universal transition 当前组 ID。 |
| `Highest` | 获取 highest 原始值。 |
| `Id` | 获取或设置业务 ID。 |
| `ItemStyle` | 获取或设置专用常态样式；赋空重置整个块。 |
| `Key` | 获取或设置优先于 ID 和 Name 的稳定键。 |
| `Label` | 获取或设置逐项标签；赋空重置整个块。 |
| `Lowest` | 获取 lowest 原始值。 |
| `Name` | 获取或设置显示名称。 |
| `Open` | 获取 open 原始值。 |
| `Select` | 获取或设置逐项 select；赋空重置整个块。 |
| `Selected` | 获取或设置初始选中种子。 |
| `Tooltip` | 获取或设置逐项 Tooltip；赋空重置整个块。 |
| `Values` | 获取隔离的 OHLC 与辅助维只读向量。 |

## 方法

### `Clone`

创建值、身份和全部嵌套块均隔离的可变副本。

### `CreateDataValueSnapshot`

创建与当前值内容等价、可安全发布的深度不可变快照。

**返回：** 独立的不可变快照；不得返回 `null` 或 provider 自身。

### `CreateSnapshot`

创建可安全共享的深度不可变逐项快照。
