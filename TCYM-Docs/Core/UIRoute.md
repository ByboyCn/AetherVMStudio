# UIRoute

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

声明式路由配置辅助方法。

## 方法

### LazyLoad(Func<TElement>)

```csharp
Func<UIElement> LazyLoad(Func<TElement> factory)
```

创建延迟页面工厂。页面实例会在路由首次命中时创建。

**参数：**

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `factory` | `Func<TElement>` |  |

### LazyLoad()

```csharp
Func<UIElement> LazyLoad()
```

为具有公共无参构造函数的页面创建延迟页面工厂。
