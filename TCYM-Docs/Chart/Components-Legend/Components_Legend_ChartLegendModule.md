# ChartLegendModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Components.Legend`　**Chart 版本**：`0.1.1.25`

## 概述

集中装配 M1.5 Legend 的处理器、持久 View、action 与无状态交互控制器。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取 Legend 组件在注册表中的稳定模块键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

把完整 Legend 模块注册到指定扩展注册表。

| 参数 | 说明 |
| --- | --- |
| `registry` | 接收 Legend 扩展的注册表。 |

**返回：** 传入注册表，便于继续链式装配。

**说明：** 写入前会预检 View、处理器、action 与 controller 的全部稳定注册，避免常见冲突留下半注册状态。
所有已注册实例均不保存 Engine-local 状态，可由多个 Engine 安全共享。
