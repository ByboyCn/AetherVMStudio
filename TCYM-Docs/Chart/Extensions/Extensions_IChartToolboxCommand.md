# IChartToolboxCommand

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Extensions`　**Chart 版本**：`0.1.1.25`

## 概述

定义未来 toolbox feature 可通过固定 action 桥执行的强类型命令。
命令实现由普通虚调用直接执行，不使用名称查找、反射或对象负载分派。

## 方法

### `Execute(TCYM.UI.Chart.Extensions.ChartToolboxCommandContext)`

在当前 Engine 的 action 事务中执行命令。

| 参数 | 说明 |
| --- | --- |
| `context` | 绑定当前 Engine 与精确 action invocation 的命令上下文。 |

**返回：** 命令成功后需要重新运行的图表阶段。
