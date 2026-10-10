# ChartDiagnostics

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

收集最近一次图表构建及其后续清理过程产生的诊断信息。

## 构造函数

### `ChartDiagnostics`

初始化空的诊断集合。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Items` | 获取按报告顺序排列的只读诊断列表。 |

## 方法

### `Error(String,String,Exception,String)`

记录一条带 option 路径的错误级诊断。

| 参数 | 说明 |
| --- | --- |
| `code` | 供程序识别的稳定诊断代码。 |
| `message` | 面向开发者的说明。 |
| `exception` | 导致错误的可选异常。 |
| `optionPath` | 定位输入节点或字段的稳定 option 路径。 |

### `Error(String,String,Exception)`

记录一条错误级诊断。

| 参数 | 说明 |
| --- | --- |
| `code` | 供程序识别的稳定诊断代码。 |
| `message` | 面向开发者的说明。 |
| `exception` | 导致错误的可选异常。 |

### `Info(String,String,String)`

记录一条带 option 路径的信息级诊断。

| 参数 | 说明 |
| --- | --- |
| `code` | 供程序识别的稳定诊断代码。 |
| `message` | 面向开发者的说明。 |
| `optionPath` | 定位输入节点或字段的稳定 option 路径。 |

### `Info(String,String)`

记录一条信息级诊断。

| 参数 | 说明 |
| --- | --- |
| `code` | 供程序识别的稳定诊断代码。 |
| `message` | 面向开发者的说明。 |

### `Report(TCYM.UI.Chart.Core.ChartDiagnostic)`

记录一条已经完成结构化的诊断。

| 参数 | 说明 |
| --- | --- |
| `diagnostic` | 待追加的诊断值。 |

### `Warning(String,String,String)`

记录一条带 option 路径的警告级诊断。

| 参数 | 说明 |
| --- | --- |
| `code` | 供程序识别的稳定诊断代码。 |
| `message` | 面向开发者的说明。 |
| `optionPath` | 定位输入节点或字段的稳定 option 路径。 |

### `Warning(String,String)`

记录一条警告级诊断。

| 参数 | 说明 |
| --- | --- |
| `code` | 供程序识别的稳定诊断代码。 |
| `message` | 面向开发者的说明。 |
