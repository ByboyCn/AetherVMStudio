# ChartPolarAxisLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Polar`　**Chart 版本**：`0.1.1.25`

## 概述

保存一根 Radius 或 Angle 轴的最终比例尺和所属 Polar 身份。

## 构造函数

### `ChartPolarAxisLayoutSnapshot(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,String,TCYM.UI.Chart.Model.ChartAxisType,Boolean,Boolean,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisScaleBuildResult,Int32)`

创建一根已经完成域与 range 解析的 Polar 轴布局。

| 参数 | 说明 |
| --- | --- |
| `identity` | Radius 或 Angle 轴规范身份。 |
| `polarId` | 所属 Polar 稳定布局 ID。 |
| `axisType` | 有效轴类型。 |
| `optionInverse` | 调用方声明的 inverse。 |
| `effectiveInverse` | 轴模型的有效 inverse；Angle 已经合并 clockwise。 |
| `scaleBuildResult` | 统一 ScaleBuilder 输出。 |
| `renderOrder` | 同维度稳定绘制顺序。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AxisType` | 获取有效轴类型。 |
| `EffectiveInverse` | 获取轴模型的有效 inverse。Radius 与 `OptionInverse` 相同；Angle 还会与<br />clockwise 做异或合并。反向 radius pair 还会独立影响物理 range，实际方向应读取<br />`Scale` 的 Range.Span。 |
| `Identity` | 获取轴规范身份。 |
| `Inverse` | 获取轴模型的有效 inverse；保留短名称供布局消费者读取。 |
| `OptionInverse` | 获取 option 原始声明的 inverse。 |
| `PolarId` | 获取所属 Polar 稳定布局 ID。 |
| `RenderOrder` | 获取同维度稳定绘制顺序。 |
| `Scale` | 获取最终不可变比例尺。 |
| `ScaleBuildResult` | 获取统一比例尺构建结果。 |
