# ChartSymbolDeclaration

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Rendering.Symbols`　**Chart 版本**：`0.1.1.25`

## 概述

表示已经完成语法归一化的强类型符号声明；实例不持有 Skia 资源，可安全跨 Engine 共享。

## 属性

| 名称 | 说明 |
| --- | --- |
| `BuiltInKind` | 获取内置几何种类；非内置声明返回 `null`。 |
| `IsEmpty` | 获取声明是否带有 ECharts `emptyXxx` 空心语义。 |
| `Kind` | 获取声明大类。 |
| `None` | 获取不创建场景元素的符号声明。 |
| `Source` | 获取去掉 `path://` 或 `image://` 前缀后的载荷；内置与无图形声明返回<br />`null`。 |

## 方法

### `BuiltIn(TCYM.UI.Chart.Rendering.Symbols.ChartBuiltInSymbolKind,Boolean)`

创建内置几何声明。

| 参数 | 说明 |
| --- | --- |
| `kind` | 内置几何种类。 |
| `isEmpty` | 是否采用空心语义。 |

**返回：** 可重复用于创建独立场景元素的不可变声明。

### `Image(String)`

创建外部图片声明。

| 参数 | 说明 |
| --- | --- |
| `source` | 不含 `image://` 前缀的图片源标识。 |

**返回：** 仅能通过调用方注入的 `IChartImageResolver` 解析的不可变声明。

### `Path(String)`

创建 SVG path data 声明。

| 参数 | 说明 |
| --- | --- |
| `pathData` | 不含 `path://` 前缀的 SVG path data。 |

**返回：** 可交给 `ChartSymbolFactory` 实例化的不可变声明。
