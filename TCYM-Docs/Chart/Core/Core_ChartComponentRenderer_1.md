# ChartComponentRenderer&lt;T1&gt;

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

为旧式组件渲染器提供强类型配置检查的基类。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ComponentType` | 获取渲染器支持的组件子类型。 |

## 方法

### `Render(TCYM.UI.Chart.Core.ChartBuildContext,,Int32)`

由派生类渲染强类型组件配置。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前构建上下文。 |
| `option` | 已验证类型的组件配置。 |
| `componentIndex` | 组件在相同主类型中的索引。 |

### `Render(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Model.ChartComponentOption,Int32)`

验证配置类型后调用强类型渲染方法。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前构建上下文。 |
| `option` | 组件配置。 |
| `componentIndex` | 组件在相同主类型中的索引。 |
