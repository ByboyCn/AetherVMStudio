# ChartPolarCoordinateSystemFactory

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

从统一 Polar 布局制品为一个组件创建唯一二维坐标系。工厂不重新解析 option，确保转换、查询、
后续组件 View 和系列布局消费同一份中心、半径和比例尺事实。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Type` | 获取该工厂注册的坐标系类型。 |

## 方法

### `Create(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Model.ChartComponentOption,Int32)`

根据当前构建上下文和组件配置创建坐标系。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前候选构建上下文。 |
| `option` | 声明坐标系的组件配置。 |
| `componentIndex` | 组件在同一主类型中的索引。 |

**返回：** 新建的坐标系序列；每个实例的 `Id` 必须唯一。

**说明：** 当 `Type` 为 `cartesian2d` 时，工厂必须为目标 grid 的每个 X×Y
轴对返回一个实例，顺序为 X 轴组件索引升序、其内 Y 轴组件索引升序。ID 可自由选择；
但必须非空且在图表内唯一。每个实例的类型必须仍为 `cartesian2d`，并使用目标
grid 的最终内容边界。公共布局会按该顺序发布显式轴对映射，不从 ID 文本反向推导，
也不接受缺少轴对或额外的输出实例。
