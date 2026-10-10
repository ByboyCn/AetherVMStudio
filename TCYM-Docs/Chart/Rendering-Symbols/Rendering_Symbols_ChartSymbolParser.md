# ChartSymbolParser

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Rendering.Symbols`　**Chart 版本**：`0.1.1.25`

## 概述

把 ECharts 风格 symbol 文本解析为不持有资源的强类型声明。

## 方法

### `Parse(String)`

解析 ECharts 风格符号文本。

| 参数 | 说明 |
| --- | --- |
| `value` | 内置名称、`emptyXxx`、`path://...` 或 `image://...`。 |

**返回：** 成功时携带强类型声明，失败时携带稳定诊断且不抛出输入异常。
