# UIRouter

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

轻量级路由器（桌面端内存路由）。 特性： 1. 支持 push / replace / back / forward。 2. 支持页面缓存（keep-alive）。 3. 缓存页不移除节点，仅切换 display:none / 原始 display；非缓存页离开时移除并释放。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Routes` | `IReadOnlyList<UIRouteRecord>` | 已注册的根路由配置。 |
| `CurrentPath` | `string?` | 当前路由路径。 |
| `CurrentPage` | `UIElement?` | 当前显示页面。 |
| `CurrentRoute` | `UIRouteRecord?` | 当前命中的路由配置。 |
| `OnRouteChanged` | `event Action<UIRouteChangedEventArgs>?` | 路由变化事件。 |
| `OnRouteChangedAsync` | `event Func<UIRouteChangedEventArgs, Task>?` | 路由切换完成后触发的异步通知。订阅者按注册顺序执行， 单个订阅者的异常通过 <see cref="UISystem.UnhandledException"/> 上报。 |

## 方法

### BindHost(UIView)

```csharp
void BindHost(UIView host)
```

绑定承载容器（RouterView）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `host` | `UIView` | 页面承载容器。 |

### Register(UIRouteRecord)

```csharp
UIRouter Register(UIRouteRecord record)
```

注册路由。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `record` | `UIRouteRecord` |  |

### Register(IEnumerable<UIRouteRecord>)

```csharp
UIRouter Register(IEnumerable<UIRouteRecord> records)
```

注册声明式路由表，并递归注册其中的子路由。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `records` | `IEnumerable<UIRouteRecord>` |  |

### Register(string, Func<UIElement>, bool)

```csharp
UIRouter Register(string path, Func<UIElement> factory, bool keepAlive = true)
```

注册路由（便捷重载）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` |  |
| `factory` | `Func<UIElement>` |  |
| `keepAlive` | `bool` |  |

### PushById(string)

```csharp
bool PushById(string id)
```

根据路由 ID 导航（push）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `id` | `string` |  |

### ReplaceById(string)

```csharp
bool ReplaceById(string id)
```

根据路由 ID 导航（replace）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `id` | `string` |  |

### Preload(string)

```csharp
bool Preload(string path)
```

在不改变当前页面、导航历史和路由生命周期的前提下，提前创建指定路径的页面。 预加载页保持脱离元素树，并在该路由第一次成功导航时被一次性消费。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` | 当前路由器内已经注册的路径。 |

**返回：** 路由已拥有可复用页面或成功创建预加载页时返回 <c>true</c>。

### PreloadById(string)

```csharp
bool PreloadById(string id)
```

按路由 ID 提前创建页面，但不改变当前页面、历史和生命周期。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `id` | `string` | 当前路由器中已注册的路由 ID。 |

**返回：** 路由已拥有可复用页面或成功创建预加载页时返回 <c>true</c>。

### DiscardPreloaded(string)

```csharp
bool DiscardPreloaded(string path)
```

释放指定路径尚未被导航消费的预加载页，并取消本次宿主绑定期间尚未开始的自动预加载。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` | 当前路由器内已经注册的路径。 |

**返回：** 找到并完整释放预加载页时返回 <c>true</c>；不存在或当前不能安全释放时返回 <c>false</c>。

### DiscardPreloadedById(string)

```csharp
bool DiscardPreloadedById(string id)
```

按路由 ID 释放尚未被导航消费的预加载页，并取消尚未开始的自动预加载。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `id` | `string` | 当前路由器中已注册的路由 ID。 |

**返回：** 找到并完整释放预加载页时返回 <c>true</c>。

### TryGetRoute(string, UIRouteRecord?)

```csharp
bool TryGetRoute(string path, UIRouteRecord? route)
```

按完整路径获取路由配置。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` |  |
| `route` | `UIRouteRecord?` |  |

### TryGetRouteById(string, UIRouteRecord?)

```csharp
bool TryGetRouteById(string id, UIRouteRecord? route)
```

按 ID 获取路由配置。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `id` | `string` |  |
| `route` | `UIRouteRecord?` |  |

### Push(string)

```csharp
bool Push(string path)
```

导航（push）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` |  |

### Replace(string)

```csharp
bool Replace(string path)
```

导航（replace）。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` |  |

### ReplaceCurrentPage(UIElement)

```csharp
bool ReplaceCurrentPage(UIElement page)
```

在保持当前路由路径不变的前提下，替换当前显示页面实例。 适用于需要原地热替换当前路由页的场景。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `page` | `UIElement` |  |

### Back()

```csharp
bool Back()
```

返回上一页。

### Forward()

```csharp
bool Forward()
```

前进。


---

# UIRouter

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`
