# ChartLineTriggerEvent

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

指定折线、面积或两者是否参与系列级事件命中。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `Area` | 只有面积区域触发事件，对应 ECharts 的 `area`。 |
| `Line` | 只有折线路径触发事件，对应 ECharts 的 `line`。 |
| `LineAndArea` | 折线路径和面积区域都触发事件，对应 ECharts 的 `true`。 |
| `None` | 折线路径和面积均不额外触发事件，对应 ECharts 的 `false`。 |
