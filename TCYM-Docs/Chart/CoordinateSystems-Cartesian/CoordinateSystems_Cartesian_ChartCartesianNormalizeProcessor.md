# ChartCartesianNormalizeProcessor

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

在配置归一化阶段为独立坐标轴补齐一个隐式 grid，使直角坐标布局始终面对显式组件模型。

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
