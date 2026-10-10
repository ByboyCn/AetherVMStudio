# BindablePropertyCatalog

> **类型**：类　**分类**：Binding　**框架版本**：`0.1.1.24`

## 概述

保存 Generator 注册的可绑定目标属性元数据，供设计器和工具链无反射读取。

## 方法

### Register(Assembly, IBindableProperty)

```csharp
void Register(Assembly owner, IBindableProperty property)
```

以指定程序集为所有者注册目标属性描述符。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `owner` | `Assembly` |  |
| `property` | `IBindableProperty` |  |

### GetProperties(Type)

```csharp
IReadOnlyList<IBindableProperty> GetProperties(Type targetType)
```

返回目标类型可使用的全部可绑定属性，包括基类声明。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `targetType` | `Type` |  |

### TryGetProperty(Type, string, IBindableProperty?)

```csharp
bool TryGetProperty(Type targetType, string propertyName, IBindableProperty? property)
```

查找目标类型上的指定可绑定属性，包括基类声明。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `targetType` | `Type` |  |
| `propertyName` | `string` |  |
| `property` | `IBindableProperty?` |  |

### Unregister(Assembly)

```csharp
void Unregister(Assembly owner)
```

注销指定程序集拥有的全部目标属性描述符。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `owner` | `Assembly` |  |
