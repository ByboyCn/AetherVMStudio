# IChartPolarCoordinateSystem

> **类型**：interface　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

定义二维极坐标系面向系列的最小公共能力。通用坐标值的 `X`
表示半径数据，`Y` 表示角度数据。

## 说明

`RadiusScale` 的输出单位是像素半径，`AngleScale` 的输出单位是度。
零度位于中心点正右方，正角度沿数学逆时针方向旋转；在屏幕向下为正的 Y 轴上表现为向上旋转。
未夹紧比例尺外插出的负像素半径按 ECharts 规范化为其绝对值，并把角度偏移一百八十度；
该映射不是双射，像素反算只恢复规范的非负半径分支。
显式 endAngle 保持原始 range 方向；像素反算选择哪个 360 度分支由
`EffectiveAngleInverse` 独立决定。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AngleScale` | 获取把角度数据映射为角度度数的不可变比例尺。 |
| `Center` | 获取极坐标系的有限像素中心点。 |
| `EffectiveAngleInverse` | 获取 angleAxis.inverse 与 clockwise 合成后的有效反向标志；它不改写显式 angle range。 |
| `InnerRadius` | 获取圆环内边界的非负像素半径。 |
| `IsEmpty` | 获取任一比例尺是否没有有效数据域。 |
| `OuterRadius` | 获取圆环外边界的非负像素半径。 |
| `RadiusScale` | 获取把半径数据映射为像素半径的不可变比例尺。 |

## 方法

### `TryDataToPoint(TCYM.UI.Chart.CoordinateSystems.ChartCoordinateValue,SkiaSharp.SKPoint@)`

尝试把半径、角度数据转换为有限像素点，并规范化比例尺外插出的负像素半径。

| 参数 | 说明 |
| --- | --- |
| `value` | X 为半径数据、Y 为角度数据的通用坐标值。 |
| `point` | 成功时得到有限像素点；失败时两个分量均为 NaN。 |

**返回：** 两个比例尺均能转换且结果可表示为有限像素坐标时返回 `true`。

### `TryPointToData(SkiaSharp.SKPoint,TCYM.UI.Chart.CoordinateSystems.ChartCoordinateValue@)`

尝试把有限像素点反向转换为半径、角度数据。

| 参数 | 说明 |
| --- | --- |
| `point` | 待转换的像素点；允许位于圆环外部。 |
| `value` | 成功时 X 为半径数据、Y 为角度数据；失败时两个维度均为空。 |

**返回：** 两个比例尺均能执行反向转换时返回 `true`。
