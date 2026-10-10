# ChartTitleModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Components.Title`　**Chart 版本**：`0.1.1.25`

## 概述

集中装配 M1.4 Title 的 Normalize、Layout 与持久 View。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取 Title 组件在注册表中的稳定模块键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

把 Title 模块注册到指定扩展注册表。

| 参数 | 说明 |
| --- | --- |
| `registry` | 接收 Title 扩展的注册表。 |

**返回：** 传入注册表，便于继续链式装配。

**说明：** 模块键、View 键与处理器稳定键会在同一注册表锁内完整预检并一次提交。
