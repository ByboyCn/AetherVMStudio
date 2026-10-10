# ChartLineWidth

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示折线宽度的非负像素值或 emphasis `bolder` 联合类型。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Bolder` | 获取 emphasis 相对加粗宽度。 |
| `IsBolder` | 获取当前宽度是否要求相对 normal 宽度加粗。 |
| `Kind` | 获取宽度类别。 |
| `Pixels` | 获取明确像素宽度；`bolder` 类别返回空。 |

## 方法

### `FromPixels(Single)`

从非负有限像素数创建明确宽度。

| 参数 | 说明 |
| --- | --- |
| `pixels` | 像素宽度。 |

**返回：** 数值宽度联合值。
