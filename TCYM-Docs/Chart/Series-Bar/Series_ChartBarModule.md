# ChartBarModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

消费基础模块已注册的公共 Cartesian stack，并原子装配 Bar option 归一化、基础轴统计、
Layout/Visual、能力边界校验与生产 View。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取生产 Bar 模块在注册表中的稳定模块键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

把 Bar Normalize、基础轴统计、Layout/Visual、option validator 与生产 View 作为一个事务注册。

| 参数 | 说明 |
| --- | --- |
| `registry` | 接收 Bar 契约的注册表。 |

**返回：** 传入的注册表，便于链式装配。

**说明：** 重复模块键、处理器键或校验处理器键会使整批注册失败，不会留下半模块。
当前生产路径已开放普通 Cartesian 公共 stack、跨系列柱槽、视觉、Tooltip、Legend 与 Mark 集成；
Polar 与光标等延期能力仍由 validator 以精确诊断阻断或声明延期；transition group
仅在显式启用 universal transition 时由共享 M3.7 管线消费，未启用时保持惰性。
