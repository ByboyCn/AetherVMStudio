# ChartCartesianCoordinateSystemFactory

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

根据布局阶段发布的统一直角布局快照，为一个 grid 创建全部 X 轴与 Y 轴的笛卡尔积坐标系。

## 说明

工厂不重新计算网格、比例尺或坐标轴归属，确保布局、组件视图、查询和系列最终读取同一份几何事实。
返回值在方法内完成物化，不会把构建上下文或制品访问门面泄漏到调用作用域之外。

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
