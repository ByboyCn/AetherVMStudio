# BindableProperty<TTarget, TValue>

> **类型**：类　**分类**：Binding　**框架版本**：`0.1.1.24`

**继承 / 实现**：`IBindableProperty`

## 概述

描述目标控件上的一个强类型可绑定 CLR 属性。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Name` | `string` |  |
| `TargetType` | `Type` |  |
| `ValueType` | `Type` |  |
| `DefaultMode` | `BindingMode` |  |
| `DefaultUpdateSourceTrigger` | `BindingUpdateSourceTrigger` |  |
| `Invalidation` | `BindingInvalidation` |  |
| `SupportsTargetNotifications` | `bool` |  |
| `CanRead` | `bool` |  |
| `CanWrite` | `bool` |  |

## 方法

### Register(string, , TValue>, , TValue>?, BindingMode, BindingUpdateSourceTrigger)

```csharp
BindableProperty<TTarget, TValue> Register(string name,  Func<TTarget, TValue> getter,  Action<TTarget, TValue>? setter = null, BindingMode defaultMode = BindingMode.OneWay, BindingUpdateSourceTrigger defaultUpdateSourceTrigger = BindingUpdateSourceTrigger.Default)
```

创建一个强类型目标属性描述符。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `name` | `string` |  |
| `Func<TTarget` | `` |  |
| `getter` | `TValue>` |  |
| `Action<TTarget` | `` |  |
| `setter` | `TValue>?` |  |
| `defaultMode` | `BindingMode` |  |
| `defaultUpdateSourceTrigger` | `BindingUpdateSourceTrigger` |  |

### Register(string, , TValue>, , TValue>?, BindingMode, BindingUpdateSourceTrigger, BindingInvalidation, bool)

```csharp
BindableProperty<TTarget, TValue> Register(string name,  Func<TTarget, TValue> getter,  Action<TTarget, TValue>? setter, BindingMode defaultMode, BindingUpdateSourceTrigger defaultUpdateSourceTrigger, BindingInvalidation invalidation, bool supportsTargetNotifications)
```

创建一个包含界面失效和目标变化通知元数据的强类型目标属性描述符。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `name` | `string` |  |
| `Func<TTarget` | `` |  |
| `getter` | `TValue>` |  |
| `Action<TTarget` | `` |  |
| `setter` | `TValue>?` |  |
| `defaultMode` | `BindingMode` |  |
| `defaultUpdateSourceTrigger` | `BindingUpdateSourceTrigger` |  |
| `invalidation` | `BindingInvalidation` |  |
| `supportsTargetNotifications` | `bool` |  |

### GetValue(object)

```csharp
object? GetValue(object target)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `target` | `object` |  |

### SetValue(object, object?)

```csharp
void SetValue(object target, object? value)
```

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `target` | `object` |  |
| `value` | `object?` |  |

### ToString()

```csharp
string ToString()
```
