# ChartViewUpdate

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

描述传给持久视图的一次更新。

## 构造函数

### `ChartViewUpdate(TCYM.UI.Chart.Core.ChartUpdateFlags,Boolean,Int64)`

描述传给持久视图的一次更新。

| 参数 | 说明 |
| --- | --- |
| `Flags` | 此次更新覆盖的阶段。 |
| `IsInitial` | 是否为该视图实例的首次更新。 |
| `Version` | 完成后将发布的引擎版本。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Flags` | 此次更新覆盖的阶段。 |
| `IsInitial` | 是否为该视图实例的首次更新。 |
| `IsReactivated` | 获取该持久视图是否在上一轮被隐藏、并于本轮重新进入有效场景。<br />重激活不等同于首次创建，视图可据此拒绝使用隐藏前的陈旧 presentation 做普通 diff。 |
| `Version` | 完成后将发布的引擎版本。 |
