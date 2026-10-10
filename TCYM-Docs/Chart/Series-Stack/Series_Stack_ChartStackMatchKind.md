# ChartStackMatchKind

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Series.Stack`　**Chart 版本**：`0.1.1.25`

## 概述

标识堆叠项在不同系列之间使用的匹配身份。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `DimensionValue` | 按离散 base 维度身份匹配；显式 Polar category 使用解析后的域内 ordinal，同一系列中的<br />重复身份采用最后一次出现，无法解析的显式 category 不参与跨系列匹配。 |
| `RawIndex` | 在不存在可用离散维度时按 lineage 根 rawIndex 匹配。 |
