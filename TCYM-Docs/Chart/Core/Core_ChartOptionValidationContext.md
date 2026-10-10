# ChartOptionValidationContext

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

为一个 option 校验器提供隔离输入与事务化诊断收集；校验器抛出异常时，本次回调已经报告的
局部结果与对 option 副本的误修改都会被丢弃，其他校验器仍可继续。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Option` | 获取当前 Normalize 候选的独立副本。校验器应把它视为只读对象；即使误改，<br />修改也不会进入 Engine 的待发布模型。 |
| `Registry` | 获取当前模块注册表，用于验证坐标系等开放字符串是否已经注册。 |

## 方法

### `Error(String,String,Exception,String)`

报告一条错误级 option 诊断。

| 参数 | 说明 |
| --- | --- |
| `code` | 稳定诊断代码。 |
| `message` | 面向开发者的说明。 |
| `exception` | 关联的可选异常。 |
| `optionPath` | 可选的 ECharts 风格 option 路径。 |

### `Info(String,String,String)`

报告一条信息级 option 诊断。

| 参数 | 说明 |
| --- | --- |
| `code` | 稳定诊断代码。 |
| `message` | 面向开发者的说明。 |
| `optionPath` | 可选的 ECharts 风格 option 路径。 |

### `Report(TCYM.UI.Chart.Core.ChartDiagnostic)`

报告一条完整的结构化 option 诊断。

| 参数 | 说明 |
| --- | --- |
| `diagnostic` | 待加入当前校验器候选结果的诊断。 |

### `Report(TCYM.UI.Chart.Core.ChartDiagnosticSeverity,String,String,Exception,String)`

构造并记录指定严重程度的诊断。

| 参数 | 说明 |
| --- | --- |
| `severity` | 诊断严重程度。 |
| `code` | 稳定诊断代码。 |
| `message` | 面向开发者的说明。 |
| `exception` | 关联的可选异常。 |
| `optionPath` | 可选 option 路径。 |

### `Warning(String,String,String)`

报告一条警告级 option 诊断。

| 参数 | 说明 |
| --- | --- |
| `code` | 稳定诊断代码。 |
| `message` | 面向开发者的说明。 |
| `optionPath` | 可选的 ECharts 风格 option 路径。 |
