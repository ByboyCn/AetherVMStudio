# ChartLegendDataItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

描述 Legend `data` 中一个显式项目及其逐项视觉覆盖。

## 构造函数

### `ChartLegendDataItem`

创建名称为空的项目；空名称可在 plain Legend 中表示显式换行项。

### `ChartLegendDataItem(String)`

创建具有指定 selection key/显示名的项目。

| 参数 | 说明 |
| --- | --- |
| `name` | 项目名称；允许空字符串，不允许空引用。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Icon` | 获取或设置内置 symbol、`path://` 或继承图标声明。 |
| `InactiveBorderColor` | 获取或设置未选中图标的边框画刷。 |
| `InactiveBorderWidth` | 获取或设置未选中图标的有限非负边框宽度；空值表示 auto。 |
| `InactiveColor` | 获取或设置未选中文字和图标使用的画刷。 |
| `ItemStyle` | 获取或设置逐项图标样式；赋空恢复空补丁。 |
| `LineStyle` | 获取或设置逐项线条图标样式；赋空恢复空补丁。 |
| `Name` | 获取或设置项目名称；该名称同时是 ECharts 兼容的选择键。 |
| `RichInheritPlainStyle` | 获取或设置 rich run 是否继承普通文字字段。 |
| `SymbolKeepAspect` | 获取或设置 path 图标是否保持原始宽高比。 |
| `SymbolRotate` | 获取或设置图标顺时针旋转角度；空值继承顶层或 presentation。 |
| `TextRich` | 获取逐项 rich 文本样式字典。 |
| `TextStyle` | 获取或设置逐项文字样式；赋空恢复空补丁。 |
| `TooltipShow` | 获取或设置是否为本项目发布 Legend tooltip metadata。 |

## 方法

### `Clone`

创建画刷、样式与 rich 字典均隔离的项目副本。

**返回：** 内容等价的新项目。
