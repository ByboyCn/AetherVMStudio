# ChartRadarLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Radar`　**Chart 版本**：`0.1.1.25`

## 概述

按声明顺序保存全部 Radar 组件，不从坐标 ID 文本反向解析归属。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Radars` | 获取全部 Radar 布局。 |

## 方法

### `TryResolve(String,Nullable{Int32},TCYM.UI.Chart.CoordinateSystems.Radar.ChartRadarLayoutItem@)`

按业务 ID 优先、否则索引默认零解析 Radar；无匹配时返回假。
