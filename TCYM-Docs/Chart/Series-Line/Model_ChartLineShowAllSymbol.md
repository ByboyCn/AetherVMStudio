# ChartLineShowAllSymbol

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

指定类目轴上折线 symbol 的展示策略。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `All` | 始终显示全部 symbol，对应 ECharts 的 `true`。 |
| `Auto` | 在空间允许时显示全部 symbol，否则跟随标签间隔策略。 |
| `FollowLabelInterval` | 始终跟随标签间隔策略，对应 ECharts 的 `false`。 |
