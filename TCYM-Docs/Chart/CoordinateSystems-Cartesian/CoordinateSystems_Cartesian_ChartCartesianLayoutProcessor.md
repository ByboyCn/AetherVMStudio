# ChartCartesianLayoutProcessor

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

统一解析全部 Cartesian grid 与坐标轴，并在单次 Layout 回调中发布比例尺、几何、查询和坐标系。

## 说明

本处理器是 M1.2 唯一的直角坐标布局写入者。组件 view 和后续系列只能读取
`Layout`，不得再次从 option 推导坐标。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Order` | 获取处理器在同一阶段内的执行顺序；数值较小者先执行。 |
| `Stage` | 获取处理器所属的管线阶段。 |

## 方法

### `Process(TCYM.UI.Chart.Core.ChartBuildContext)`

使用当前回调作用域处理图表候选状态。

| 参数 | 说明 |
| --- | --- |
| `context` | 仅在本次处理器回调期间具备对应写权限的构建上下文。 |
