# ChartPolarComponentLayoutProcessor

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

从 M2.9.2 权威 Polar 布局冻结轴组件绘制所需的纯托管几何与文本；本处理器不创建场景节点或原生路径。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Order` | 获取处理器在同一阶段内的执行顺序；数值较小者先执行。 |
| `Stage` | 获取处理器所属的管线阶段。 |

## 方法

### `Process(TCYM.UI.Chart.Core.ChartBuildContext)`

构建并发布当前候选中的全部 Polar 组件绘制布局。

| 参数 | 说明 |
| --- | --- |
| `context` | 已经包含 M2.9.2 最终 Polar 布局的候选上下文。 |
