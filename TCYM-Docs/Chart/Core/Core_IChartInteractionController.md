# IChartInteractionController

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

tooltip、axisPointer、dataZoom、roam、drag 等模块使用的交互控制器。
控制器在图元事件之前按顺序执行，并且可以处理没有命中具体图元的视口事件。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Order` | 获取控制器的执行顺序；数值较小者先执行。 |

## 方法

### `Handle(TCYM.UI.Chart.Core.ChartBuildContext,TCYM.UI.Chart.Core.ChartPointerEvent)`

处理原始指针事件，并可更新处理状态或捕获请求。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前已发布状态的只读回调上下文。 |
| `pointerEvent` | 包含命中结果和可写处理状态的事件。 |
