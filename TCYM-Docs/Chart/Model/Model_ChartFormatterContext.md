# ChartFormatterContext

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

传递给标签格式化器的数据上下文快照。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Color` | 获取当前数据项的可选确定颜色。 |
| `ComponentType` | 获取当前组件主类型。 |
| `Culture` | 获取数字和时间格式化使用的只读区域性快照。 |
| `Data` | 获取已隔离的原始领域对象。 |
| `DataIndex` | 获取原始数据索引；非数据项上下文为 -1。 |
| `DataIndexInside` | 获取系列当前公开 presentation 中的索引；非数据项上下文为 -1。 |
| `DimensionNames` | 获取与当前数据存储顺序一致的只读维度名称快照。 |
| `DimensionValues` | 获取与维度名称对应的只读维度值快照。 |
| `Encode` | 获取 encode 通道到维度名称序列的深度只读快照。 |
| `Name` | 获取数据项或组件名称。 |
| `Percent` | 获取当前数据项的可选百分比数值。 |
| `PrimaryValue` | 获取系列确定的主显示值；向量通常取 value encode 对应维度。 |
| `RawData` | 获取已隔离的原始领域对象；这是与公共强类型参数命名一致的<br />`Data` 兼容别名。 |
| `SeriesIndex` | 获取系列索引；非系列上下文为 -1。 |
| `SeriesName` | 获取当前系列名称。 |
| `SeriesType` | 获取当前系列子类型。 |
| `Value` | 获取保持原始输入语法形状的标量或向量值。 |
