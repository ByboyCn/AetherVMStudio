# ChartRadarDataItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

带稳定身份和逐项样式的 Radar 原始多维向量。

## 构造函数

### `ChartRadarDataItem(Collections.Generic.IEnumerable{TCYM.UI.Chart.Data.ChartValue})`

从指标顺序的非空向量创建数据项。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AreaStyle` | 获取或设置逐项 AreaStyle 补丁。 |
| `Blur` | 获取或设置逐项 Blur 补丁。 |
| `Emphasis` | 获取或设置逐项 Emphasis 补丁。 |
| `Id` | 获取或设置业务稳定身份。 |
| `ItemStyle` | 获取或设置逐项 ItemStyle 补丁。 |
| `Key` | 获取或设置优先于 Id 的显式稳定键。 |
| `Label` | 获取或设置逐项 Label 补丁。 |
| `LineStyle` | 获取或设置逐项 LineStyle 补丁。 |
| `Name` | 获取或设置显示名和图例名。 |
| `Select` | 获取或设置逐项 Select 补丁。 |
| `Selected` | 获取或设置公共选择初始种子。 |
| `Symbol` | 获取或设置符号声明。 |
| `SymbolKeepAspect` | 获取或设置符号是否保持宽高比。 |
| `SymbolOffset` | 获取或设置符号二维偏移。 |
| `SymbolRotate` | 获取或设置符号顺时针角度。 |
| `SymbolSize` | 获取或设置符号尺寸。 |
| `Values` | 获取构造时捕获的只读值向量。 |

## 方法

### `Clone`

创建值、样式与身份隔离的可变副本。

### `CreateDataValueSnapshot`

创建与当前值内容等价、可安全发布的深度不可变快照。

**返回：** 独立的不可变快照；不得返回 `null` 或 provider 自身。

### `CreateSnapshot`

捕获公共数据管线可安全持有的不可变配置。
