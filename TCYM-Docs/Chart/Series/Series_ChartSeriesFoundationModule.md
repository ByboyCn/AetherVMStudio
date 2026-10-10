# ChartSeriesFoundationModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

集中装配所有具体系列共享的数据 schema、连续轴范围贡献、category 域、Legend
可见性、公共 stack 与轴域聚合处理器。本模块不注册任何具体 series 类型。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取公共系列底座在注册表中的稳定模块键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

把公共系列底座注册到指定注册表。

| 参数 | 说明 |
| --- | --- |
| `registry` | 接收处理器的注册表。 |

**返回：** 传入的注册表，便于链式装配。

**说明：** 写入前会预检全部内置处理器类型和稳定 action 键，避免冲突留下不完整的系列管线。
