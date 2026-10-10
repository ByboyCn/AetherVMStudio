# ChartTextResolver

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Text`　**Chart 版本**：`0.1.1.25`

## 概述

集中执行 callback、模板和默认内容的优先级及异常降级。

## 字段

| 名称 | 说明 |
| --- | --- |
| `CallbackFailureDiagnosticCode` | callback 失败时使用的稳定诊断代码。 |
| `TemplateFailureDiagnosticCode` | 模板求值失败时使用的稳定诊断代码。 |

## 方法

### `Resolve(TCYM.UI.Chart.Text.ChartFormatterParameters@,TCYM.UI.Chart.Text.ChartTextFormatter,TCYM.UI.Chart.Text.ChartTextTemplate,TCYM.UI.Chart.Text.ChartTextContent,TCYM.UI.Chart.Core.ChartDiagnostics,String)`

按 callback、编译模板、默认内容的顺序解析文本；callback 或模板异常会记录警告并直接回退默认内容。

| 参数 | 说明 |
| --- | --- |
| `parameters` | 当前 formatter 参数快照。 |
| `callback` | 最高优先级的同步强类型 formatter。 |
| `template` | 已编译且可复用的字符串模板。 |
| `defaultContent` | 没有 formatter 或 formatter 失败时使用的默认内容。 |
| `diagnostics` | 接收 formatter 警告的诊断集合。 |
| `diagnosticContext` | 用于定位组件或数据项的稳定上下文。 |

**返回：** callback 的非空结果、模板结果或默认内容。
