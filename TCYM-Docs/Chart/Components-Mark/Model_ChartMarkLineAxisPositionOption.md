# ChartMarkLineAxisPositionOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 6.1 markLine 单对象分支的严格一维位置。该分支只允许 X/Y 轴简写或统计请求，
不公开只属于二端点分支的 coord、屏幕位置、relativeTo、Polar 轴或显示值覆盖。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Statistic` | 获取或设置没有轴简写时使用的 min/max/average/median 统计请求。 |
| `ValueDimension` | 获取或设置统计目标维名称。 |
| `ValueIndex` | 获取或设置统计目标维索引；同时提供 `ValueDimension` 时该索引优先。 |
| `XAxis` | 获取或设置 Cartesian X 轴数据简写值。 |
| `YAxis` | 获取或设置 Cartesian Y 轴数据简写值。 |

## 方法

### `Clone`

创建轴值、统计请求和自定义值载荷均隔离的副本。

**返回：** 内容等价的新一维位置。
