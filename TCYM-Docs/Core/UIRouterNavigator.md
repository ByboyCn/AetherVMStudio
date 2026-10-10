# UIRouterNavigator

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

全局路由导航入口。 <para> 已绑定到 <see cref="UIRouterView"/> 的路由器会自动加入导航范围， 因而业务代码不需要持有创建页面时的 <see cref="UIRouter"/> 实例。 </para>

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `CurrentRouter` | `UIRouter?` | 最近成功导航的活动路由器；尚无活动路由时返回最近挂载的路由器。 |
| `CurrentPath` | `string?` | 当前活动路由的路径。 |
| `CurrentFullPath` | `string?` | 当前活动路由的组合完整路径。 嵌套路由会自动拼接其所在父路由页面的当前路径，例如内层 <c>/demo/svg</c> 位于外层 <c>/app</c> 时返回 <c>/app/demo/svg</c>。 |

## 方法

### Navigate(string, bool)

```csharp
bool Navigate(string path, bool replace = false)
```

使用类似 React navigate 的方式导航到路径。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` | 目标完整路径。 |
| `replace` | `bool` | 是否替换当前历史记录。 |

**返回：** 成功找到并切换到目标路由时返回 <c>true</c>；否则返回 <c>false</c>。

### NavigateById(string, bool)

```csharp
bool NavigateById(string id, bool replace = false)
```

使用路由 ID 导航。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `id` | `string` | 目标路由 ID。 |
| `replace` | `bool` | 是否替换当前历史记录。 |

**返回：** 成功找到并切换到目标路由时返回 <c>true</c>；否则返回 <c>false</c>。

### NavigateAsync(string, bool)

```csharp
Task<bool> NavigateAsync(string path, bool replace = false)
```

从任意线程导航到路径。后台线程调用时会自动切换到 UI 线程。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` | 目标完整路径。 |
| `replace` | `bool` | 是否替换当前历史记录。 |

**返回：** 表示导航结果的异步任务；成功切换路由时结果为 <c>true</c>。

### NavigateByIdAsync(string, bool)

```csharp
Task<bool> NavigateByIdAsync(string id, bool replace = false)
```

从任意线程按路由 ID 导航。后台线程调用时会自动切换到 UI 线程。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `id` | `string` | 目标路由 ID。 |
| `replace` | `bool` | 是否替换当前历史记录。 |

**返回：** 表示导航结果的异步任务；成功切换路由时结果为 <c>true</c>。

### Preload(string)

```csharp
bool Preload(string path)
```

提前创建已挂载路由器中的指定页面，但不导航、不写入历史，也不触发该页面的路由进入生命周期。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` | 本地路径或当前已挂载分支中的组合完整路径。 |

**返回：** 路由已拥有可复用页面或成功创建预加载页时返回 <c>true</c>。

### PreloadById(string)

```csharp
bool PreloadById(string id)
```

按路由 ID 提前创建页面，但不导航、不写入历史。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `id` | `string` | 已挂载路由器中的目标路由 ID。 |

**返回：** 路由已拥有可复用页面或成功创建预加载页时返回 <c>true</c>。

### PreloadAsync(string)

```csharp
Task<bool> PreloadAsync(string path)
```

从任意线程预加载指定路径；后台线程调用时会自动切换到 UI 线程。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` | 本地路径或当前已挂载分支中的组合完整路径。 |

**返回：** 表示预加载结果的异步任务。

### PreloadByIdAsync(string)

```csharp
Task<bool> PreloadByIdAsync(string id)
```

从任意线程按路由 ID 预加载页面；后台线程调用时会自动切换到 UI 线程。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `id` | `string` | 已挂载路由器中的目标路由 ID。 |

**返回：** 表示预加载结果的异步任务。

### DiscardPreloaded(string)

```csharp
bool DiscardPreloaded(string path)
```

释放指定路径尚未被导航消费的预加载页，并取消该路由尚未开始的自动预加载。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` | 本地路径或当前已挂载分支中的组合完整路径。 |

**返回：** 找到并完整释放预加载页时返回 <c>true</c>。

### DiscardPreloadedById(string)

```csharp
bool DiscardPreloadedById(string id)
```

按路由 ID 释放尚未被导航消费的预加载页，并取消尚未开始的自动预加载。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `id` | `string` | 已挂载路由器中的目标路由 ID。 |

**返回：** 找到并完整释放预加载页时返回 <c>true</c>。

### Push(string)

```csharp
bool Push(string path)
```

按本地路径或组合完整路径执行 push。 组合完整路径会逐层进入父路由，并在新挂载的子路由器中继续解析。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` | 需要压入历史记录的目标完整路径。 |

**返回：** 成功找到并切换到目标路由时返回 <c>true</c>。

### Replace(string)

```csharp
bool Replace(string path)
```

按本地路径或组合完整路径执行 replace。 组合完整路径会逐层进入父路由，并在新挂载的子路由器中继续解析。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` | 用于替换当前历史记录的目标完整路径。 |

**返回：** 成功找到并切换到目标路由时返回 <c>true</c>。

### PushById(string)

```csharp
bool PushById(string id)
```

在当前活动路由分支中查找 ID 并执行 push。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `id` | `string` | 需要压入历史记录的目标路由 ID。 |

**返回：** 成功找到并切换到目标路由时返回 <c>true</c>。

### ReplaceById(string)

```csharp
bool ReplaceById(string id)
```

在当前活动路由分支中查找 ID 并执行 replace。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `id` | `string` | 用于替换当前历史记录的目标路由 ID。 |

**返回：** 成功找到并切换到目标路由时返回 <c>true</c>。

### Back()

```csharp
bool Back()
```

在当前活动路由器中返回。

**返回：** 存在上一条历史记录并成功返回时返回 <c>true</c>。

### Forward()

```csharp
bool Forward()
```

在当前活动路由器中前进。

**返回：** 存在下一条历史记录并成功前进时返回 <c>true</c>。

### TryResolve(string, UIRouter?, UIRouteRecord?)

```csharp
bool TryResolve(string path, UIRouter? router, UIRouteRecord? route)
```

尝试解析本地路径或组合完整路径对应的已挂载路由器和路由配置。 组合路径末段也可以使用当前活动分支中的唯一路由 ID 别名。 该方法不会为了解析路径而创建尚未挂载的父页面。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `path` | `string` | 需要解析的完整路径。 |
| `router` | `UIRouter?` | 解析成功时返回负责该路径的路由器。 |
| `route` | `UIRouteRecord?` | 解析成功时返回对应的路由配置。 |

**返回：** 找到对应路由器和路由配置时返回 <c>true</c>。
