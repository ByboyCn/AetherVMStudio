# ChartMarkModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

原子装配公共 markPoint、markLine 与 markArea 的 option 默认值、数据制品和诊断契约；
M2.10.6 同时为 Cartesian/Polar markPoint、Cartesian/Polar 二端点 markLine 与 Cartesian markArea
注册布局、视觉和独立系列附属 View；Polar markArea 保持不支持并给出稳定诊断。

## 说明

三种 Mark 均通过系列 attachment 独立渲染，不侵入具体系列 View；调用方必须显式安装本模块。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取公共 Mark 模块在注册表中的稳定模块键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

把 Mark 规范化、数据、三种布局、视觉、附属 View 与校验器作为一个事务注册。

| 参数 | 说明 |
| --- | --- |
| `registry` | 接收公共 Mark 契约的注册表。 |

**返回：** 传入的注册表，便于链式装配。

**说明：** 数据制品处理器固定在 Layout 20；Point/Line/Area 的 Layout 与 Visual 顺序分别由处理器自身声明，
且 Visual 必须晚于系列视觉、早于 Legend 800/Tooltip 900。重复模块键、处理器键或 attachment 键会使整批注册失败。
