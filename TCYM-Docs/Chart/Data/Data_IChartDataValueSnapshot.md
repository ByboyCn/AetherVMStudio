# IChartDataValueSnapshot

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

为可变自定义数据值提供独立、深度不可变的表示。

## 说明

返回对象不能是 provider 自身，且必须为已知不可变标量，或实现
`IChartImmutableDataValue` 的非 `IDisposable` 引用。
为保证 NativeAOT 行为可预测，契约不支持 provider 链或反射深拷贝。

## 方法

### `CreateDataValueSnapshot`

创建与当前值内容等价、可安全发布的深度不可变快照。

**返回：** 独立的不可变快照；不得返回 `null` 或 provider 自身。
