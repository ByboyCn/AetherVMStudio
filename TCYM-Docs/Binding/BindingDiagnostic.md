# BindingDiagnostic

> **类型**：类　**分类**：Binding　**框架版本**：`0.1.1.24`

## 概述

描述一次 Binding 运行时诊断。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `exception` | `BindingDiagnostic(             string id,             BindingDiagnosticSeverity severity,             string message,             Exception?` | 创建诊断。 |
| `Id` | `string` | 稳定诊断编号。 |
| `Severity` | `BindingDiagnosticSeverity` | 严重级别。 |
| `Message` | `string` | 用户可读消息。 |
| `Exception` | `Exception?` | 可选异常。 |

## 方法

### ToString()

```csharp
string ToString()
```
