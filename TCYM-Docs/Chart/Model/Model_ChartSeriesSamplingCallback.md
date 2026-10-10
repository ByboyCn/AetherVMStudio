# ChartSeriesSamplingCallback

> **类型**：delegate　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Bar、Line 等数值系列共享的自定义采样聚合回调。回调按只读采样帧计算一个代表值，
不获得也不修改系列的可变运行时状态。采样帧保留原数据中的 `NaN`；
返回 NaN 表示该桶为断口，返回正无穷或负无穷会严格拒绝当前构建候选。
