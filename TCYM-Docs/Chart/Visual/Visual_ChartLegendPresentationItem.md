# ChartLegendPresentationItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Visual`　**Chart 版本**：`0.1.1.25`

## 概述

描述一个系列贡献给公共 Legend 的不可变显示项、视觉和选择目标。

## 构造函数

### `ChartLegendPresentationItem(String,String,String,TCYM.UI.Chart.Visual.ChartLegendVisualStyle,TCYM.UI.Chart.Visual.ChartLegendVisualStyle,TCYM.UI.Chart.Visual.ChartLegendTarget,Boolean,Single,Boolean)`

创建一个携带系列 symbol 旋转和 Legend hover 联动策略的 presentation 项。

| 参数 | 说明 |
| --- | --- |
| `key` | 在所属系列 presentation 内稳定且唯一的非空键。 |
| `name` | ECharts Legend 选择与 formatter 使用的非空显示名称。 |
| `icon` | 可选图标关键字或路径描述。 |
| `itemStyle` | 图标主体视觉；空值使用共享空视觉。 |
| `lineStyle` | 图标线段视觉；空值使用共享空视觉。 |
| `target` | 选择状态最终控制的系列或数据项目标。 |
| `drawLineThroughSymbol` | 是否先在完整图标边界中绘制水平线段，再把 symbol 绘制在线段上层。 |
| `symbolRotate` | Legend 未显式覆盖 symbolRotate 时继承的系列 symbol 顺时针旋转角度。 |
| `hoverLink` | Legend item hover 是否联动当前目标的 emphasis。 |

### `ChartLegendPresentationItem(String,String,String,TCYM.UI.Chart.Visual.ChartLegendVisualStyle,TCYM.UI.Chart.Visual.ChartLegendVisualStyle,TCYM.UI.Chart.Visual.ChartLegendTarget,Boolean)`

创建一个可选择在 symbol 下层绘制水平线段的 Legend presentation 项。

| 参数 | 说明 |
| --- | --- |
| `key` | 在所属系列 presentation 内稳定且唯一的非空键。 |
| `name` | ECharts Legend 选择与 formatter 使用的非空显示名称。 |
| `icon` | 可选图标关键字或路径描述。 |
| `itemStyle` | 图标主体视觉；空值使用共享空视觉。 |
| `lineStyle` | 图标线段视觉；空值使用共享空视觉。 |
| `target` | 选择状态最终控制的系列或数据项目标。 |
| `drawLineThroughSymbol` | 是否先在完整图标边界中绘制水平线段，再把 symbol 绘制在线段上层。 |

### `ChartLegendPresentationItem(String,String,String,TCYM.UI.Chart.Visual.ChartLegendVisualStyle,TCYM.UI.Chart.Visual.ChartLegendVisualStyle,TCYM.UI.Chart.Visual.ChartLegendTarget)`

创建一个 Legend presentation 项。

| 参数 | 说明 |
| --- | --- |
| `key` | 在所属系列 presentation 内稳定且唯一的非空键。 |
| `name` | ECharts Legend 选择与 formatter 使用的非空显示名称。 |
| `icon` | 可选图标关键字或路径描述。 |
| `itemStyle` | 图标主体视觉；空值使用共享空视觉。 |
| `lineStyle` | 图标线段视觉；空值使用共享空视觉。 |
| `target` | 选择状态最终控制的系列或数据项目标。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `DrawLineThroughSymbol` | 获取是否在 symbol 下层绘制贯穿完整图标边界的水平线段。 |
| `HoverLink` | 获取 Legend item hover 是否联动当前目标的 emphasis。 |
| `Icon` | 获取可选图标关键字或路径描述。 |
| `ItemStyle` | 获取不可变图标主体视觉。 |
| `Key` | 获取所属系列 presentation 内的稳定唯一键。 |
| `LineStyle` | 获取不可变图标线段视觉。 |
| `Name` | 获取 Legend 显示、formatter 和选择字典使用的名称。 |
| `SymbolRotate` | 获取 Legend 未显式覆盖时继承的系列 symbol 顺时针旋转角度。 |
| `Target` | 获取当前项控制的系列或数据项目标。 |
