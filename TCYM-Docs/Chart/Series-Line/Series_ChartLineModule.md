# ChartLineModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

原子装配 Line option、sampling、Cartesian/基础 Polar Layout/Visual、公共 presentation 和生产 SeriesView。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取生产 Line 模块在注册表中的稳定模块键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

把 Line Normalize、sampling、基础 Layout/Visual、option validator 与生产 View
作为一个事务注册到指定注册表。

| 参数 | 说明 |
| --- | --- |
| `registry` | 接收 Line 契约的注册表。 |

**返回：** 传入的注册表，便于链式装配。

**说明：** 重复模块键、处理器键或校验处理器键会使整批注册失败，不会留下半模块。
基础 Polar Line 还要求同一注册表已经完整提交 `ChartPolarModule`；
默认注册表不会隐式安装该可选坐标模块。
