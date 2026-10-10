# ChartItemStyleBrushCallback

> **类型**：delegate　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

按单个有效数据项解析 Cartesian Bar 系列 normal itemStyle 的填充画刷。
返回空值表示保留已由静态样式或调色板解析的当前值；需要清除时应在
静态字段上显式赋空。其他系列与 background/state/逐项作用域当前不执行该回调。
