# PropertyAccessorRegistry

> **类型**：类　**分类**：Binding　**框架版本**：`0.1.1.24`

## 概述

在 AOT/裁剪场景下为属性访问提供无反射的委托注册表。 应用可在启动时调用 Register 为参与绑定的类型/属性注册 getter/setter， 绑定系统将优先使用这里的访问器，避免运行时反射失败。

## 方法

### Register(string, , V>, , V>?)

```csharp
void Register(string propertyName,  Func<T, V> getter,  Action<T, V>? setter = null)
```

为类型 T 的属性注册访问器。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `propertyName` | `string` |  |
| `Func<T` | `` |  |
| `getter` | `V>` |  |
| `Action<T` | `` |  |
| `setter` | `V>?` |  |

### Register(Assembly, string, , V>, , V>?)

```csharp
void Register(Assembly owner, string propertyName,  Func<T, V> getter,  Action<T, V>? setter = null)
```

以指定程序集为所有者注册生成访问器，支持可卸载预览程序集精确注销。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `owner` | `Assembly` |  |
| `propertyName` | `string` |  |
| `Func<T` | `` |  |
| `getter` | `V>` |  |
| `Action<T` | `` |  |
| `setter` | `V>?` |  |

### TryGet(Type, string, , object?>?, , object?>?)

```csharp
bool TryGet(Type type, string propertyName,  out Func<object, object?>? getter,  out Action<object, object?>? setter)
```

尝试获取访问器。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `type` | `Type` |  |
| `propertyName` | `string` |  |
| `out Func<object` | `` |  |
| `getter` | `object?>?` |  |
| `out Action<object` | `` |  |
| `setter` | `object?>?` |  |

### Clear()

```csharp
void Clear()
```

清空已注册的属性访问器。 设计时宿主在循环加载可卸载程序集时需要移除旧类型引用。

### Unregister(Assembly)

```csharp
void Unregister(Assembly owner)
```

注销指定程序集拥有的全部访问器。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `owner` | `Assembly` |  |
