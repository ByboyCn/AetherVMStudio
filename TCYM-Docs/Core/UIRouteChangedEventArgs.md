# UIRouteChangedEventArgs

> **类型**：类　**分类**：Core　**框架版本**：`0.1.1.24`

**继承 / 实现**：`EventArgs`

## 概述

路由切换事件参数。

## 属性

| 名称 | 类型 | 说明 |
| --- | --- | --- |
| `FromRoute` | `UIRouteRecord?` | 切换前的路由配置。首次进入应用时可能为 <c>null</c>。 |
| `ToRoute` | `UIRouteRecord` | 切换后的路由配置。 |
| `FromPath` | `string?` | 路由切换前的路径。 首次进入应用时可能为 <c>null</c>。 |
| `ToPath` | `string` | 路由切换后的目标路径。 |
| `FromPage` | `UIElement?` | 路由切换前的页面实例。 首次进入应用时可能为 <c>null</c>。 |
| `ToPage` | `UIElement` | 路由切换后的页面实例。 |
