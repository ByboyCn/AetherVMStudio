# UIRouterView

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

**继承 / 实现**：`UIView, IDisposable, IUIElementDisposalPreflight`

## 概述

路由承载容器。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Router` | `UIRouter?` | 路由器实例。 |

## 方法

### this()

```csharp
UIRouterView(UIRouter router) : this()
```

创建路由承载容器并绑定指定路由器。

### Dispose()

```csharp
void Dispose()
```

释放承载容器及其页面子树，从全局导航范围移除对应路由器， 并清空路由器的页面缓存和导航状态。

### VerifyCanDispose()

```csharp
void VerifyCanDispose()
```

在拥有型释放拆除父子关系前验证路由器当前允许销毁宿主。
