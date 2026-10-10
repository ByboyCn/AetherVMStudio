# BindingExpression

> **类型**：类　**分类**：Binding　**框架版本**：`0.1.1.24`

**继承 / 实现**：`IDisposable`

## 概述

一个已解析并可激活的 Binding 运行时表达式。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `mode` | `BindingExpression(             object source,             string sourceProperty,             object target,             string targetProperty,             BindingMode` |  |
| `Source` | `object` | 绑定源实例。 |
| `SourceProperty` | `string` | 源路径显示名称。 |
| `Target` | `object` | 绑定目标实例。 |
| `TargetProperty` | `string` | 目标属性名称。 |
| `Mode` | `BindingMode` | 有效绑定模式。 |

## 方法

### UpdateTarget()

```csharp
void UpdateTarget()
```

把当前源值更新到目标。

### UpdateSource()

```csharp
void UpdateSource()
```

把当前目标值回写到源。

### Dispose()

```csharp
void Dispose()
```
