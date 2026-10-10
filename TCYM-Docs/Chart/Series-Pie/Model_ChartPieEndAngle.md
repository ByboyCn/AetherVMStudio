# ChartPieEndAngle

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Pie `endAngle` 的 `auto` 或有限角度联合值。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Auto` | 获取自动整周值。 |
| `Degrees` | 获取明确角度；自动整周时返回空。 |
| `Kind` | 获取当前联合值的类别。 |

## 方法

### `FromDegrees(Single)`

从有限角度创建明确终止角。

| 参数 | 说明 |
| --- | --- |
| `degrees` | 角度值。 |

**返回：** 明确角度联合值。
