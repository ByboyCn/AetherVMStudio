# ChartVisualMapOption

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

定义 continuous 与 piecewise VisualMap 共用的目标、维度、视觉通道和控制器布局字段。
所有 setter 均记录 presence，支持增量 SetOption、显式 null 与 Reset。

## 说明

此基类只作为两个内置密封选项的公共集合与读取类型；VisualMap 子类型协议不开放外部继承。
请直接使用 `ChartVisualMapContinuousOption` 或
`ChartVisualMapPiecewiseOption`。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Align` | 获取或设置控制器对齐方式。 |
| `ComponentType` | 获取组件注册与合并所使用的类型名。 |
| `Dimension` | 获取或设置全部普通目标共用的维度索引或名称。 |
| `Formatter` | 获取或设置支持 {value}/{value2} 的数值标签模板。 |
| `HoverLink` | 获取或设置控制器 hover 是否联动目标数据项。 |
| `InRange` | 获取或设置 inRange 状态的四类映射通道。 |
| `Inverse` | 获取或设置是否反转控制器显示顺序。 |
| `ItemHeight` | 获取或设置控制器长边或 piece 高度。 |
| `ItemWidth` | 获取或设置控制器短边尺寸。 |
| `Max` | 获取或设置映射值域上界。 |
| `Min` | 获取或设置映射值域下界。 |
| `Orient` | 获取或设置控制器排列方向。 |
| `OutOfRange` | 获取或设置 outOfRange 状态的四类映射通道。 |
| `Precision` | 获取或设置标签数值精度，范围为 0～20。 |
| `SeriesId` | 获取或设置目标系列 ID；空值表示不按 ID 筛选。 |
| `SeriesIndex` | 获取或设置目标系列索引；空值表示不按索引筛选。 |
| `SeriesTargets` | 获取或整体设置带独立维度的目标系列；非空列表存在时覆盖 SeriesIndex、SeriesId 与 Dimension。 |
| `Text` | 获取或整体设置高值、低值端点文本。 |
| `TextGap` | 获取或设置控制器与端点文本之间的非负间距。 |

## 方法

### `Reset`

显式清除全部 VisualMap 专属字段和子类型字段。
