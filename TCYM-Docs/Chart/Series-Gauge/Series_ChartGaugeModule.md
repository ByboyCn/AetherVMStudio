# ChartGaugeModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

原子安装基础 Gauge 的 Normalize、Data、Layout、Visual、validator 与生产 View。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取 Gauge module 的稳定原子注册键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

原子注册六项基础 Gauge 契约；重复 module 或 entry 冲突会整批回滚。

| 参数 | 说明 |
| --- | --- |
| `registry` | 待安装的注册表。 |

**返回：** 同一个注册表实例。
