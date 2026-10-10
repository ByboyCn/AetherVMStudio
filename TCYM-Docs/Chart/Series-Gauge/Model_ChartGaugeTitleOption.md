# ChartGaugeTitleOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Gauge 标题。ECharts 6.1 类型保留 formatter/valueAnimation，但 GaugeView
不消费这两个字段；M11.1 因而只保留 presence 和委托引用。

## 方法

### `Clone`

创建标题文本、样式和 presence 日志均隔离的副本。
