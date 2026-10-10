# UIBindingEngine

> **类型**：类　**分类**：Binding　**框架版本**：`0.1.1.24`

**继承 / 实现**：`IDisposable`

## 概述

管理一个 UIElement 拥有的活动 BindingExpression。

## 方法

### AddBinding(BindingExpression)

```csharp
void AddBinding(BindingExpression binding)
```

添加一个已构造的旧式 BindingExpression。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `binding` | `BindingExpression` |  |

### UpdateSourceFromTarget(object, string)

```csharp
void UpdateSourceFromTarget(object target, string targetProperty)
```

由旧控件路径通知指定目标属性回写到源。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `target` | `object` |  |
| `targetProperty` | `string` |  |

### ClearBindings()

```csharp
void ClearBindings()
```

清除全部绑定并解除订阅。

### Dispose()

```csharp
void Dispose()
```
