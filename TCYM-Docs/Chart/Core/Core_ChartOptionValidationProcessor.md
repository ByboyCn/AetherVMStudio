# ChartOptionValidationProcessor

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

在 Normalize 阶段末尾按稳定顺序执行 option 校验器，并统一提供异常隔离与结果去重。

## 构造函数

### `ChartOptionValidationProcessor(Collections.Generic.IEnumerable{TCYM.UI.Chart.Core.IChartOptionValidator})`

初始化冻结校验器名称、顺序和注册次序的处理器。

| 参数 | 说明 |
| --- | --- |
| `validators` | 要协调执行的校验器；序列与其中的元素均不能为空。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Order` | 获取处理器在同一阶段内的执行顺序；数值较小者先执行。 |
| `Stage` | 获取处理器所属的管线阶段。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ProcessorOrder` | 获取该处理器的保留顺序。自定义 Normalize 处理器必须使用更小的顺序，<br />才能让校验器观察其最终输出。 |

## 方法

### `Process(TCYM.UI.Chart.Core.ChartBuildContext)`

逐个隔离校验器，把成功回调的候选按稳定顺序提交；相同严重程度、代码、消息与位置只保留首项。

| 参数 | 说明 |
| --- | --- |
| `context` | 当前 Normalize 构建上下文。 |
