# ChartRoundedRectElement

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

绘制四角半径可独立配置、且半径可随 emphasis、blur、select 组合状态变化的矩形。
非零圆角的绘制与命中从同一条 Skia 路径解析；四角全零时复用普通矩形路径，
保持既有直角矩形的精确像素兼容。

## 属性

| 名称 | 说明 |
| --- | --- |
| `BlurBorderRadius` | 获取或设置 blur 状态四角半径覆盖。 |
| `BorderRadius` | 获取或设置 normal 状态四角半径；百分比相对于当前矩形短边解析。 |
| `EmphasisBorderRadius` | 获取或设置 emphasis 状态四角半径覆盖。 |
| `EmphasisZ2` | 获取或设置 emphasis 状态的次级绘制层级。 |
| `NormalZ2` | 获取或设置 normal/blur 状态的次级绘制层级。 |
| `SelectBorderRadius` | 获取或设置 select 状态四角半径覆盖。 |
| `SelectZ2` | 获取或设置 select 状态的次级绘制层级。 |

## 方法

### `CreateResolvedPath`

按当前组合状态创建与绘制、命中共用的圆角矩形路径。

**返回：** 由调用方释放的路径。
