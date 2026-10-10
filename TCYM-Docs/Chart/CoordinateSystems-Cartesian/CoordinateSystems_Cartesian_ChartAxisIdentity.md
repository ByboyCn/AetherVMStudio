# ChartAxisIdentity

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

描述一根坐标轴在有效配置中的只读身份。

## 构造函数

### `ChartAxisIdentity(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisDimension,Int32,String)`

创建由维度、同类组件索引和可选公开 ID 组成的坐标轴身份。

| 参数 | 说明 |
| --- | --- |
| `dimension` | 坐标轴负责的逻辑维度。 |
| `componentIndex` | 坐标轴在相同主类型组件中的零基索引。 |
| `componentId` | 用户配置的可选非空白组件 ID。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `ComponentId` | 获取用户配置的可选组件 ID。 |
| `ComponentIndex` | 获取坐标轴在相同主类型组件中的零基索引。 |
| `ComponentType` | 获取该维度对应的标准组件主类型。 |
| `Dimension` | 获取坐标轴负责的逻辑维度。 |
