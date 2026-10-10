# IChartBrushSnapshot

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

可变自定义画刷的快照契约。返回值必须是独立、非释放型且实现
`IChartImmutableBrush` 的画刷。

## 方法

### `CreateBrushSnapshot`

创建与当前视觉状态等价的深度不可变画刷快照。

**返回：** 不与源画刷共享可变状态的新实例。
