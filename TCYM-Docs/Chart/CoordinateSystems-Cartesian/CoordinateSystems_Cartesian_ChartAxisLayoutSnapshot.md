# ChartAxisLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

表示一根直角坐标轴已经完成计算的深度不可变布局。比例尺通过
`IChartImmutableArtifact` 契约安全共享，刻度集合在构造时复制并封装为只读视图。

## 构造函数

### `ChartAxisLayoutSnapshot(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,String,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisPosition,Double,Boolean,Int32,SkiaSharp.SKPoint,SkiaSharp.SKPoint,TCYM.UI.Chart.CoordinateSystems.Scales.IChartScale,Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisTickLayoutSnapshot},Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisMinorTickLayoutSnapshot},Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisBandBoundaryLayoutSnapshot},Nullable{Double})`

创建额外携带有效连续轴几何起点的完整不可变布局快照。

| 参数 | 说明 |
| --- | --- |
| `identity` | 坐标轴身份。 |
| `gridId` | 所属网格的稳定布局标识。 |
| `position` | 坐标轴相对于网格所在的一侧。 |
| `offset` | 坐标轴相对其默认边界向外移动的有限像素距离。 |
| `inverse` | 配置语义中的轴向反转标志。 |
| `renderOrder` | 同层多轴的稳定绘制顺序。 |
| `axisLineStart` | 轴线起点。 |
| `axisLineEnd` | 轴线终点。 |
| `scale` | 已经绑定当前像素范围的深度不可变比例尺。 |
| `ticks` | 待复制的主刻度布局序列。 |
| `minorTicks` | 待复制的次刻度布局序列。 |
| `bandBoundaryTicks` | category band 的边界刻度。 |
| `effectiveStartValue` | 具体系列几何使用的有效起点。 |

### `ChartAxisLayoutSnapshot(TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisIdentity,String,TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisPosition,Double,Boolean,Int32,SkiaSharp.SKPoint,SkiaSharp.SKPoint,TCYM.UI.Chart.CoordinateSystems.Scales.IChartScale,Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisTickLayoutSnapshot},Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisMinorTickLayoutSnapshot},Collections.Generic.IEnumerable{TCYM.UI.Chart.CoordinateSystems.Cartesian.ChartAxisBandBoundaryLayoutSnapshot})`

创建一根坐标轴的完整不可变布局快照。

| 参数 | 说明 |
| --- | --- |
| `identity` | 坐标轴身份。 |
| `gridId` | 所属网格的稳定布局标识。 |
| `position` | 坐标轴相对于网格所在的一侧。 |
| `offset` | 坐标轴相对其默认边界向外移动的有限像素距离。 |
| `inverse` | 配置语义中的轴向反转标志。 |
| `renderOrder` | 同层多轴的稳定绘制顺序。 |
| `axisLineStart` | 轴线起点。 |
| `axisLineEnd` | 轴线终点。 |
| `scale` | 已经绑定当前像素范围的深度不可变比例尺。 |
| `ticks` | 待复制的主刻度布局序列。 |
| `minorTicks` | 待复制的次刻度布局序列；为空时表示没有次刻度。 |
| `bandBoundaryTicks` | category band 的 N+1 条边界刻度；其他比例尺为空。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AxisLineEnd` | 获取轴线终点。 |
| `AxisLineStart` | 获取轴线起点。 |
| `BandBoundaryTicks` | 获取 category band 的只读 N+1 边界刻度；语义主刻度仍位于<br />`Ticks`，查询层不会把 synthetic 末边界当作分类值。 |
| `EffectiveStartValue` | 获取具体系列几何使用的有效连续轴起点；当前轴不需要起点时为空。 |
| `GridId` | 获取所属网格的稳定布局标识。 |
| `Identity` | 获取坐标轴身份。 |
| `Inverse` | 获取配置语义中的轴向反转标志。 |
| `MinorTicks` | 获取构造时复制的只读次刻度布局。 |
| `Offset` | 获取坐标轴相对其默认边界向外移动的像素距离。 |
| `OutwardNormal` | 获取由轴位置确定的单位外法线。 |
| `Position` | 获取坐标轴相对于网格所在的一侧。 |
| `RenderOrder` | 获取同层多轴的稳定绘制顺序。 |
| `Scale` | 获取已经绑定当前像素范围的深度不可变比例尺。 |
| `Ticks` | 获取构造时复制的只读主刻度布局。 |
