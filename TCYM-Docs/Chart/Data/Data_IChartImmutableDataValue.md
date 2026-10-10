# IChartImmutableDataValue

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

标记整个可达对象图均为深度不可变的自定义引用值。捕获数据快照时可安全共享实现对象。

## 说明

这是显式信任契约：从该对象可达的每个对象也必须不可变。可变值应改为实现
`IChartDataValueSnapshot`。
