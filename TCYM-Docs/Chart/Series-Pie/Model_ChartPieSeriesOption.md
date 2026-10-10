# ChartPieSeriesOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Apache ECharts 6.1 `series.pie` 的 presence-aware 配置节点。该节点不绑定
Cartesian 或 Polar 坐标系；布局使用系列自身的 box、center 与 radius。

## 构造函数

### `ChartPieSeriesOption`

创建空 Pie 补丁并安装精确的 normal label 与三种交互状态类型。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AnimationDelay` | 获取或设置首次进入动画延迟。 |
| `AnimationDelayCallback` | 获取或设置逐项首次进入动画延迟回调。 |
| `AnimationDelayUpdate` | 获取或设置更新动画延迟。 |
| `AnimationDelayUpdateCallback` | 获取或设置逐项更新动画延迟回调。 |
| `AnimationDuration` | 获取或设置首次进入动画时长；空值继承有效默认值。 |
| `AnimationDurationCallback` | 获取或设置逐项首次进入动画时长回调。 |
| `AnimationDurationUpdate` | 获取或设置更新动画时长。 |
| `AnimationDurationUpdateCallback` | 获取或设置逐项更新动画时长回调。 |
| `AnimationEasing` | 获取或设置首次进入动画缓动名称。 |
| `AnimationEasingUpdate` | 获取或设置更新动画缓动名称。 |
| `AnimationThreshold` | 获取或设置允许动画的非负数据量阈值。 |
| `AnimationType` | 获取或设置首次显示时采用 expansion 或 scale 动画。 |
| `AnimationTypeUpdate` | 获取或设置更新时采用 transition 或 expansion 动画。 |
| `AvoidLabelOverlap` | 获取或设置是否运行 Pie 外部标签避让。 |
| `Blur` | 获取或设置精确的 Pie blur 状态。 |
| `Bottom` | 获取或设置 Pie 布局 box 下边距。 |
| `Center` | 获取或设置相对布局 box 的 Pie 圆心。 |
| `Clockwise` | 获取或设置扇区是否按顺时针方向排列。 |
| `ColorBy` | 获取或设置调色板按系列或数据项分配颜色。 |
| `Cursor` | 获取或设置命中 Pie 扇区时建议使用的原生指针光标名称。 |
| `DefaultCoordinateSystemType` | 获取当前具体系列在 `CoordinateSystem` 未指定时采用的坐标系类型；<br />默认返回空，具体 line、bar、scatter 等系列应覆盖为自身真实默认值。 |
| `Emphasis` | 获取或设置精确的 Pie emphasis 状态。 |
| `EmptyCircleStyle` | 获取或设置空圆样式；赋空或空对象显式重置整块公共 itemStyle。 |
| `EndAngle` | 获取或设置自动整周或明确有限角度形式的终止角。 |
| `Height` | 获取或设置 Pie 布局 box 的有限非负高度。 |
| `HoverLayerThreshold` | 获取或设置启用独立悬停图层的非负阈值；正无穷表示永不启用。 |
| `Label` | 获取或设置常态 Pie 标签；赋空或空对象显式重置整块。 |
| `LabelLine` | 获取或设置常态 Pie 标签引导线；赋空或空对象显式重置整块。 |
| `Left` | 获取或设置 Pie 布局 box 左边距。 |
| `LegendHoverLink` | 获取或设置 Legend 悬停是否联动 emphasis。 |
| `MinAngle` | 获取或设置数据项分配到的有限非负最小角度（度）。 |
| `MinShowLabelAngle` | 获取或设置允许显示标签及引导线的有限非负最小可见角度。 |
| `PadAngle` | 获取或设置扇区之间的有限非负间隔角（度）。 |
| `PercentPrecision` | 获取或设置百分比席位计算使用的 0～20 位小数精度。 |
| `Radius` | 获取或设置相对布局 box 最短边一半的 Pie 内外半径。 |
| `Right` | 获取或设置 Pie 布局 box 右边距。 |
| `RoseType` | 获取或设置玫瑰图半径或等角面积模式；空值表示普通 Pie。 |
| `Select` | 获取或设置精确的 Pie select 状态。 |
| `SelectedOffset` | 获取或设置选中扇区沿中线外移的有限非负像素量。 |
| `SeriesType` | 获取系列注册表使用的类型名，例如 `line` 或 `bar`。 |
| `ShowEmptyCircle` | 获取或设置没有有效数据项时是否绘制空圆。 |
| `StartAngle` | 获取或设置有限的起始角度（度）。 |
| `StillShowZeroSum` | 获取或设置所有有效数据值为零时是否仍按等角展示。 |
| `Tooltip` | 获取或设置系列级 CommonTooltip；赋空或空对象显式重置整块。 |
| `Top` | 获取或设置 Pie 布局 box 上边距。 |
| `Width` | 获取或设置 Pie 布局 box 的有限非负宽度。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
