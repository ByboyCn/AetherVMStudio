# ChartCartesianModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

集中装配 M1.2 直角坐标底座的处理器、视图与坐标系工厂。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取 Cartesian 公共底座在注册表中的稳定模块键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

把直角坐标底座注册到指定扩展注册表。

| 参数 | 说明 |
| --- | --- |
| `registry` | 接收模块扩展的注册表。 |

**返回：** 传入的注册表，便于继续链式装配其他模块。

**说明：** 写入前会预检坐标系工厂、三个组件 View 和四个处理器，常见冲突不会留下部分模块。
