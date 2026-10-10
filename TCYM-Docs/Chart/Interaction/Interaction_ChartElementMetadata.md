# ChartElementMetadata

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Interaction`　**Chart 版本**：`0.1.1.25`

## 概述

场景元素关联的组件、系列和数据项身份。命中测试通过该对象把轻量场景节点
映射回 tooltip、事件分发和状态联动所需的图表语义。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ComponentId` | 获取组件显式标识。 |
| `ComponentIndex` | 获取组件索引；未关联组件时为 -1。 |
| `ComponentType` | 获取组件主类型；未关联组件时为 `null`。 |
| `DataIndex` | 获取原始数据中的稳定索引；未关联数据项时为 -1。 |
| `DataIndexInside` | 获取系列当前公开 presentation 中的索引；未关联数据项时为 -1。 |
| `DataType` | 获取系列内部数据类型；普通数据为main，关系图使用node或edge。 |
| `Name` | 获取命中项的显示名称。 |
| `Payload` | 获取随事件传递的领域负载。使用数据源负载时，应遵守图表数据的不可变或快照契约。 |
| `Percent` | 获取饼图、漏斗图等比例系列共享的可选百分比；不提供比例语义的系列返回<br />`null`。 |
| `PrimaryValue` | 获取系列确定的主要显示值；向量通常对应 value encode 维度。 |
| `SeriesId` | 获取系列显式标识。 |
| `SeriesIndex` | 获取系列索引；未关联系列时为 -1。 |
| `SeriesInteractionTarget` | 获取公共系列 focus/blurScope 协调器使用的稳定交互目标；为空表示图元不参加系列失焦联动。 |
| `SeriesType` | 获取系列类型；未关联系列时为 `null`。 |
| `TooltipTarget` | 获取独立于业务 `Payload` 的 tooltip 稳定命中身份；为空表示该图元不参与 item tooltip。 |
| `Value` | 获取保持原始标量或向量语法形状的命中项值。 |
