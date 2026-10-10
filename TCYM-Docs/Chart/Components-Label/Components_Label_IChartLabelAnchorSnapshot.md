# IChartLabelAnchorSnapshot

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Components.Label`　**Chart 版本**：`0.1.1.25`

## 概述

让可变自定义标签锚点在 descriptor 提交时产生独立不可变快照。

## 方法

### `CreateLabelAnchorSnapshot`

创建与当前几何等价且实现 `IChartImmutableLabelAnchor` 的独立快照。

**返回：** 不得返回当前实例、空值或可变锚点。
