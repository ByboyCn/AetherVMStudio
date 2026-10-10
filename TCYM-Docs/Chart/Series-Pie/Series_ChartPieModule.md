# ChartPieModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

原子装配 Pie option 归一化、Data/Layout/Visual、诚实能力边界与生产 View。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取生产 Pie 模块在注册表中的稳定模块键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

把 Pie Normalize、Data/Layout/Visual、validator 与生产 View 作为一个事务注册。

| 参数 | 说明 |
| --- | --- |
| `registry` | 接收 Pie 契约的注册表。 |

**返回：** 传入的注册表，便于链式装配。

**说明：** 重复模块键、处理器键或校验处理器键会使整批注册失败，不会留下半模块。
本模块依赖 `ChartSeriesFoundationModule` 提供 Data schema、Legend
pre-layout mask 与公共交互制品；自定义注册表必须先安装该基础模块。
M4.2 起默认注册表安装本模块；M4.3 已开放 normal Pie/Donut 的 advanced angle、
percent、zero/empty，rose 与后续能力继续由 validator/candidate guard 精确阻断。
