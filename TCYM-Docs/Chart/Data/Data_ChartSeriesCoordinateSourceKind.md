# ChartSeriesCoordinateSourceKind

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Data`　**Chart 版本**：`0.1.1.25`

## 概述

标识解析后 encode 通道的数据来源及其可选标量语法条件。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `RawIndex` | 值由数据项的稳定 rawIndex 合成，不占用存储维度。 |
| `ScalarDimension` | 仅当原始项是标量语法时读取指定存储维度，否则返回空值。 |
| `ScalarRawIndex` | 仅当原始项是标量语法时合成 rawIndex，否则返回空值。 |
| `ScalarRawIndexOrDimension` | 标量语法合成 rawIndex，向量语法读取指定存储维度。 |
| `StoredDimension` | 值来自处理后数据项中的一个显式存储维度。 |
