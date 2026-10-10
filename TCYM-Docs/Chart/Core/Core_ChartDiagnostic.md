# ChartDiagnostic

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

表示一条结构化图表诊断。实现复用原有 Code 字符串槽保存可选路径，保持 M0 公开值类型的四字段
布局、构造函数与四项解构签名不变。

## 构造函数

### `ChartDiagnostic(TCYM.UI.Chart.Core.ChartDiagnosticSeverity,String,String,Exception)`

使用 M0 兼容的四参数签名创建诊断。

| 参数 | 说明 |
| --- | --- |
| `Severity` | 诊断严重程度；名称保持 M0 positional record 构造参数契约。 |
| `Code` | 供程序识别的稳定代码；名称保持 M0 positional record 构造参数契约。 |
| `Message` | 面向开发者的说明；名称保持 M0 positional record 构造参数契约。 |
| `Exception` | 关联的可选异常；名称保持 M0 positional record 构造参数契约。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Code` | 获取或在 record 初始化表达式中替换供程序识别的稳定代码，同时保留已有路径。 |
| `Exception` | 获取或在 record 初始化表达式中替换关联的可选异常。 |
| `Location` | 获取 `OptionPath` 的通用位置别名，便于诊断宿主统一展示来源。 |
| `Message` | 获取或在 record 初始化表达式中替换面向开发者的说明。 |
| `OptionPath` | 获取可选的 ECharts 风格 option 路径，例如 `series[1].encode.x[0]`；<br />非 option 输入产生的运行时诊断保持为空。 |
| `Severity` | 获取或在 record 初始化表达式中替换诊断严重程度。 |

## 方法

### `Deconstruct(TCYM.UI.Chart.Core.ChartDiagnosticSeverity@,String@,String@,Exception@)`

按 M0 兼容顺序解构诊断，不把新增定位信息插入旧签名。

| 参数 | 说明 |
| --- | --- |
| `severity` | 接收诊断严重程度。 |
| `code` | 接收稳定代码。 |
| `message` | 接收开发者说明。 |
| `exception` | 接收可选异常。 |

### `ToString`

使用 M0 positional record 的四项文本格式输出诊断；可选定位信息不会改变旧日志或快照文本。

**返回：** 仅包含 Severity、Code、Message 与 Exception 的兼容文本。
