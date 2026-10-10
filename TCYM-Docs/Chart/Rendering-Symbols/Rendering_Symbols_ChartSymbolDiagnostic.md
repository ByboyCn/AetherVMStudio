# ChartSymbolDiagnostic

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Rendering.Symbols`　**Chart 版本**：`0.1.1.25`

## 概述

描述一次可恢复的符号解析或创建失败。

## 构造函数

### `ChartSymbolDiagnostic(String,String,Exception)`

描述一次可恢复的符号解析或创建失败。

| 参数 | 说明 |
| --- | --- |
| `Code` | 稳定、可供测试和上层诊断转发的代码。 |
| `Message` | 面向开发者的失败说明。 |
| `Exception` | 可选的原始异常；普通无效输入不携带异常。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Code` | 稳定、可供测试和上层诊断转发的代码。 |
| `Exception` | 可选的原始异常；普通无效输入不携带异常。 |
| `Message` | 面向开发者的失败说明。 |
