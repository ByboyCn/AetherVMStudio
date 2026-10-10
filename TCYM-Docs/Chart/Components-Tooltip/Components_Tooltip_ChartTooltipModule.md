# ChartTooltipModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

集中装配 M1.6 Tooltip 的归一化、只读来源、动作状态机、交互控制器与 PostRender 覆盖层。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取 Tooltip 组件在注册表中的稳定模块键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

把完整 Tooltip 模块注册到指定扩展注册表。

| 参数 | 说明 |
| --- | --- |
| `registry` | 接收 Tooltip 扩展的注册表。 |

**返回：** 传入注册表，便于继续链式装配。

**说明：** 写入前会预检全部稳定 action、处理器与 controller，避免常见冲突留下半注册状态。
注册实例本身不保存 Engine-local 显示状态，因而可以由多个 Engine 安全共享。
