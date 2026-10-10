# ChartScatterModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

原子安装 Cartesian/显式 Polar Scatter 的 Normalize、性能四态、Layout、Visual、validator 与生产 View。
数据、schema、extent、stack 与 DataZoom 继续由系列公共底座提供，不注册重复的 Scatter Data processor。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取 Scatter module 的稳定原子注册键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

原子注册八项 Scatter 契约；重复 module/entry 冲突会整批回滚。
自定义 Registry 必须先完整安装系列公共底座与所需 Cartesian/Polar 模块。
