# ChartOptionValidationModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

装配 M1.7 内置 option 校验器及调用方追加校验器。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取内置 option 校验模块在注册表中的稳定模块键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry,TCYM.UI.Chart.Core.IChartOptionValidator[])`

把内置校验器及追加校验器作为一个稳定事务注册到指定注册表。

| 参数 | 说明 |
| --- | --- |
| `registry` | 接收校验处理器的注册表。 |
| `validators` | 在内置校验器之后参与全局排序的追加校验器。 |

**返回：** 传入的注册表，便于链式装配。

**说明：** 会先完整冻结校验器参数，再与稳定模块键一起原子提交；重复模块或任一步失败都不会修改注册表。

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

把内置 option 校验器注册到指定注册表。

| 参数 | 说明 |
| --- | --- |
| `registry` | 接收校验处理器的注册表。 |

**返回：** 传入的注册表，便于链式装配。
