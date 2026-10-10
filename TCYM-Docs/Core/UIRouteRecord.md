# UIRouteRecord

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

## 概述

声明式路由配置项。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `Id` | `string?` | 路由唯一标识。设置后可通过 <see cref="UIRouter.PushById"/> 导航。 |
| `Path` | `required string` | 路由路径。根路由通常使用绝对路径；子路由可使用相对路径。 |
| `FullPath` | `string` | 注册后解析得到的完整路径。子路由可用它进行绝对路径导航。 |
| `Name` | `string?` | 用于菜单、面包屑等 UI 的显示名称。 |
| `Element` | `Func<UIElement>?` | 页面工厂。在实际进入路由或预加载时按需调用；非 KeepAlive 页面释放后再次进入会重新创建。 |
| `Factory` | `Func<UIElement>?` | 页面工厂的兼容名称。新代码推荐使用 <see cref="Element"/>。 |
| `Children` | `IReadOnlyList<UIRouteRecord>` | 子路由。相对路径会自动与父路由路径拼接。 |
| `KeepAlive` | `bool` | 是否缓存页面实例（keep-alive）。 |
| `PreloadOnIdle` | `bool` | 是否在界面空闲时自动预加载此路由，默认关闭。 路由器须已挂载到活动页面分支；输入和 UI 工作队列处理完毕，且无待处理布局、重绘或动画时， 才在 UI 线程创建页面。每次空闲机会最多创建一个页面。 每个宿主绑定周期内仅自动尝试一次，失败、访问后离开或主动丢弃均不会自动重新创建。 预加载不改变 <see cref="KeepAlive"/> 的释放行为；需要重试时可显式调用 <see cref="UIRouter.Preload(string)"/>。 |
| `ShowLoading` | `bool` | 是否在首次创建路由页面前显示加载遮罩，默认关闭。 命中 KeepAlive 缓存或预加载实例时不显示；开启后会先呈现加载帧，再同步创建页面。 |
| `LoadingElement` | `Func<UIElement>` | 加载组件工厂，默认创建 <see cref="ControlLoading"/>。 每次需要显示加载状态时创建新组件，导航成功或失败后由路由器释放； 自定义工厂应返回未挂载、未释放的新实例，例如 <c>() =&gt; new ControlLoading()</c>。 |
| `ReclaimMemoryOnLeave` | `bool` | 当此路由未启用 <see cref="KeepAlive"/> 且页面离开时，是否在 UI 空闲后执行一次 进程级内存整理。该模式会压缩托管堆，并在 Windows 下整理进程工作集；适合注销登录、 退出大型业务模块等低频边界，不建议用于普通子页面切换。 |
