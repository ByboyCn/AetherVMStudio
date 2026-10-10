# IChartDataItemSelection

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

为系列公共选择管线公开数据项快照中的只读选择语义，而不要求管线识别具体系列快照类型。

## 说明

实现通常同时满足 `IChartImmutableDataValue`，或由
`IChartDataValueSnapshot` 在数据捕获阶段生成不可变实现。公共选择管线不会使用
反射发现成员，因此该契约可安全用于裁剪和 NativeAOT。

## 属性

| 名称 | 说明 |
| --- | --- |
| `SelectDisabled` | 获取数据项声明的 `select.disabled` 值；空值表示继承系列级设置。 |
| `Selected` | 获取数据项的初始选择种子；`true` 表示初始选中，空值或<br />`false` 表示不提供选中种子。 |
