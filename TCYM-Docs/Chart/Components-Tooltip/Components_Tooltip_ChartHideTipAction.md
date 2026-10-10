# ChartHideTipAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

立即隐藏手动 Tooltip；自动交互隐藏仍遵守 hideDelay。

## 构造函数

### `ChartHideTipAction(String,String,Nullable{Int32})`

创建可选定目标组件的手动隐藏请求。

| 参数 | 说明 |
| --- | --- |
| `tooltipId` | 目标 Tooltip 显式 Id。 |
| `tooltipName` | 目标 Tooltip 显式 Name。 |
| `tooltipIndex` | 目标 Tooltip 同类索引。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | ECharts 兼容的 action 与事件类型。 |
