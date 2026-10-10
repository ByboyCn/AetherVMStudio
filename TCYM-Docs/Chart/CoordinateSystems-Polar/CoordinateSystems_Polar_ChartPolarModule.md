# ChartPolarModule

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

集中装配公共 Polar option、数据坐标布局、组件渲染、工厂、点查询与系列绑定。
本模块仍不加入默认注册表；显式提交完整模块后才开放基础 Polar Line 运行时。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ModuleKey` | 获取 Polar 公共组件模块在注册表中的稳定模块键。 |

## 方法

### `Register(TCYM.UI.Chart.Core.ChartRegistry)`

把 Polar option、坐标运行时与三个公共组件 View 作为单一原子模块注册。

| 参数 | 说明 |
| --- | --- |
| `registry` | 接收模块扩展的注册表。 |

**返回：** 传入的注册表，便于继续链式装配。

**说明：** 本模块显式注册后可以构建、查询并绘制 polar/radiusAxis/angleAxis 公共组件，并向支持
Polar 的系列提供完整坐标运行时。默认 Registry 保持不包含本模块；仅注册同名坐标系工厂
不等价于提交本模块，也不会通过依赖模块键的系列能力门禁。
