# BindingPathRegistry

> **类型**：类　**分类**：Binding　**框架版本**：`0.1.1.24`

## 概述

Generator 生成的 Binding 路径访问器注册入口。

## 方法

### Register(Assembly, string, , TValue>, , TValue>?)

```csharp
void Register(Assembly owner, string propertyName,  Func<T, TValue> getter,  Action<T, TValue>? setter = null)
```

注册一个强类型属性访问器。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `owner` | `Assembly` |  |
| `propertyName` | `string` |  |
| `Func<T` | `` |  |
| `getter` | `TValue>` |  |
| `Action<T` | `` |  |
| `setter` | `TValue>?` |  |

### Unregister(Assembly)

```csharp
void Unregister(Assembly owner)
```

注销指定程序集拥有的全部路径访问器。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `owner` | `Assembly` |  |
