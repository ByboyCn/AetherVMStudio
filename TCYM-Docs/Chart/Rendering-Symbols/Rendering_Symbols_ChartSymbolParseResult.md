# ChartSymbolParseResult

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Rendering.Symbols`　**Chart 版本**：`0.1.1.25`

## 概述

表示符号文本解析为强类型声明的结果。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Declaration` | 获取成功解析的强类型声明；失败时为 `null`。 |
| `Diagnostic` | 获取失败诊断；成功时为 `null`。 |
| `IsSuccess` | 获取解析是否成功。 |
