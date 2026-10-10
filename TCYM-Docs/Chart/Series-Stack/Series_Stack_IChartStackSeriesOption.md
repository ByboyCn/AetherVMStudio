# IChartStackSeriesOption

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Series.Stack`　**Chart 版本**：`0.1.1.25`

## 概述

由声明公共堆叠配置的系列选项实现，向共享处理器公开最小配置；具体系列只有在其累计几何
节点开放后才会被处理器消费。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Stack` | 获取堆叠分组键；空字符串或 `null` 表示不参与堆叠。 |
| `StackOrder` | 获取当前堆叠兼容组采用的系列累计顺序。 |
| `StackStrategy` | 获取当前系列选择前驱累计值时采用的正负策略。 |
