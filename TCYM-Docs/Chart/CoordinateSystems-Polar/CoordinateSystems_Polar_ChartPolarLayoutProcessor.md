# ChartPolarLayoutProcessor

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

统一解析全部 Polar 组件的 reference box、中心、半径、角域与两根比例尺，并通过注册工厂发布
坐标快照和精确点查询。组件 View、系列布局和 Tooltip 不得再次从 option 推导这些几何值。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Order` | 获取处理器在同一阶段内的执行顺序；数值较小者先执行。 |
| `Stage` | 获取处理器所属的管线阶段。 |

## 方法

### `Process(TCYM.UI.Chart.Core.ChartBuildContext)`

构建并原子发布当前候选中的全部 Polar 运行时制品。

| 参数 | 说明 |
| --- | --- |
| `context` | 已经完成 Normalize、Data 和公共聚合的布局上下文。 |
