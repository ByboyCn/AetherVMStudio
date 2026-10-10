# ChartGaugeAxisLabelRotation

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Gauge `axisLabel.rotate` 的数值或关键字联合值。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Degrees` | 获取明确角度；自动旋转类别返回空。 |
| `Kind` | 获取旋转类别。 |
| `Radial` | 获取径向自动旋转。 |
| `Tangential` | 获取切向自动旋转。 |

## 方法

### `FromDegrees(Single)`

从有限角度创建旋转值。
