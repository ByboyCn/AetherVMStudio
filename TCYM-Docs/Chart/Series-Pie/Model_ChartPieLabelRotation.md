# ChartPieLabelRotation

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Pie label.rotate 的有限角度、布尔兼容值或 radial/tangential 关键字。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Degrees` | 获取明确角度；关键字旋转返回空。 |
| `Kind` | 获取旋转类别。 |
| `Radial` | 获取径向旋转值。 |
| `Tangential` | 获取自动翻转的切向旋转值。 |
| `TangentialNoFlip` | 获取不自动翻转的切向旋转值。 |

## 方法

### `FromDegrees(Single)`

从有限角度创建旋转值。

| 参数 | 说明 |
| --- | --- |
| `degrees` | 顺时针角度。 |

**返回：** 明确角度旋转。
