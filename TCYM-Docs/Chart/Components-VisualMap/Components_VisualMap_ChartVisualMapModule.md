# ChartVisualMapModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Components.VisualMap`　**Chart 版本**：`0.1.1.25`

## 概述

原子装配 continuous/piecewise VisualMap 的默认值、双阶段编码、组件 View、action 与交互控制器。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取 VisualMap 在 Registry 中的稳定模块键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

把完整 VisualMap 模块注册到指定 Registry。

| 参数 | 说明 |
| --- | --- |
| `registry` | 接收 VisualMap 生产能力的注册表。 |

**返回：** 传入的注册表，便于继续链式装配。

**说明：** 模块中的实例均不保存 Engine-local 状态；range、piece selection 和拖动会话存入所属
Engine 的 runtime state。注册前会预检全部稳定键，失败不会留下半注册模块。
