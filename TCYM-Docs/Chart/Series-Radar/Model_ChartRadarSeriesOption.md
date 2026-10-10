# ChartRadarSeriesOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

一个共享 Radar 坐标中的多维向量系列，支持 presence-aware 合并。

## 构造函数

### `ChartRadarSeriesOption`

创建空 Radar 补丁；默认不会启用面积填充。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AreaStyle` | 获取或设置面积样式；显式赋空关闭面积，赋空对象启用默认填充。 |
| `Blur` | 获取或设置整条向量的淡化样式。 |
| `ColorBy` | 获取或设置颜色按系列或数据项分配。 |
| `ConnectNulls` | 获取或设置是否跨越缺失指标连接有效顶点；这是 TCYM 扩展。 |
| `DefaultCoordinateSystemType` | 获取当前具体系列在 `CoordinateSystem` 未指定时采用的坐标系类型；<br />默认返回空，具体 line、bar、scatter 等系列应覆盖为自身真实默认值。 |
| `Emphasis` | 获取或设置整条向量的强调样式。 |
| `LegendHoverLink` | 获取或设置图例悬停是否联动数据项。 |
| `LineStyle` | 获取或设置轮廓线样式；空块恢复默认线。 |
| `RadarId` | 获取或设置组件业务标识。 |
| `RadarIndex` | 获取或设置组件零基索引。 |
| `Select` | 获取或设置整条向量的选择样式。 |
| `SeriesType` | 获取系列注册表使用的类型名，例如 `line` 或 `bar`。 |
| `Symbol` | 获取或设置内置、path:// 或 image:// 符号声明。 |
| `SymbolKeepAspect` | 获取或设置符号是否保持原始宽高比。 |
| `SymbolOffset` | 获取或设置符号的二维偏移。 |
| `SymbolRotate` | 获取或设置符号顺时针旋转角度。 |
| `SymbolSize` | 获取或设置每个指标符号的逻辑像素尺寸。 |
| `Tooltip` | 获取或设置系列 Tooltip presence 补丁。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
