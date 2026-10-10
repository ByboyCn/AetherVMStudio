# ChartTooltipDisplayState

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

标识单个 Tooltip 组件当前的可观察显示阶段。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `Formatting` | 同步占位或默认内容可见，等待异步 formatter 完成。 |
| `Hidden` | 没有可绘制内容。 |
| `PendingHide` | 内容继续可见，等待 pointer hideDelay 到期。 |
| `PendingShow` | 等待 pointer showDelay 到期，尚不绘制内容。 |
| `Visible` | 内容已经可见且没有待完成格式化。 |
