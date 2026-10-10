# ChartGaugeSeriesOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Apache ECharts 6.1 `series.gauge` 当前完整的 presence-aware option 节点。
M11.1 冻结 option/data ABI；生产 View 与高级字段消费按 M11.2 及后续节点开放。

## 构造函数

### `ChartGaugeSeriesOption`

创建空 Gauge 补丁并安装精确的 typed emphasis 状态。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Anchor` | 获取或设置 Gauge 中心锚点；赋空或空对象显式重置整块。 |
| `AnimationDelay` | 获取或设置首次进入动画延迟；空值继承全局值。 |
| `AnimationDelayCallback` | 获取或设置按最终InsideIndex解析的首次进入动画延迟回调。 |
| `AnimationDelayUpdate` | 获取或设置更新动画延迟；空值继承全局值。 |
| `AnimationDelayUpdateCallback` | 获取或设置按最终InsideIndex解析的更新动画延迟回调。 |
| `AnimationDuration` | 获取或设置首次进入动画时长；空值继承全局值。 |
| `AnimationDurationCallback` | 获取或设置按最终InsideIndex解析的首次进入动画时长回调。 |
| `AnimationDurationUpdate` | 获取或设置更新动画时长；空值继承全局值。 |
| `AnimationDurationUpdateCallback` | 获取或设置按最终InsideIndex解析的更新动画时长回调。 |
| `AnimationEasing` | 获取或设置首次进入动画缓动名称。 |
| `AnimationEasingUpdate` | 获取或设置更新动画缓动名称。 |
| `AnimationThreshold` | 获取或设置数据项数超过后关闭动画的阈值；空值使用官方默认2000。 |
| `AxisLabel` | 获取或设置 Gauge 刻度标签；赋空或空对象显式重置整块。 |
| `AxisLine` | 获取或设置 Gauge 轴弧；赋空或空对象显式重置整块。 |
| `AxisTick` | 获取或设置 Gauge 次刻度；赋空或空对象显式重置整块。 |
| `Center` | 获取或设置相对布局区域的 Gauge 圆心。 |
| `Clockwise` | 获取或设置值增大时是否沿顺时针方向旋转。 |
| `ColorBy` | 获取或设置调色板按整个系列还是按数据项分配颜色。 |
| `DefaultCoordinateSystemType` | 获取当前具体系列在 `CoordinateSystem` 未指定时采用的坐标系类型；<br />默认返回空，具体 line、bar、scatter 等系列应覆盖为自身真实默认值。 |
| `Detail` | 获取或设置 Gauge 数值详情；赋空或空对象显式重置整块。 |
| `Emphasis` | 获取或设置 typed Gauge emphasis；公共基类赋值会安全投影为该具体类型。 |
| `EndAngle` | 获取或设置有限终止角度（度）。 |
| `LegendHoverLink` | 获取或设置 Legend 悬停是否联动强调该 Gauge 系列。 |
| `Maximum` | 获取或设置有限值域上限。 |
| `Minimum` | 获取或设置有限值域下限。 |
| `Pointer` | 获取或设置 Gauge 指针；赋空或空对象显式重置整块。 |
| `Progress` | 获取或设置 Gauge 当前值进度弧；赋空或空对象显式重置整块。 |
| `Radius` | 获取或设置相对布局区域最短边一半的 Gauge 半径。 |
| `SeriesType` | 获取系列注册表使用的类型名，例如 `line` 或 `bar`。 |
| `SplitLine` | 获取或设置 Gauge 主分隔线；赋空或空对象显式重置整块。 |
| `SplitNumber` | 获取或设置正数主刻度分段数量。 |
| `StartAngle` | 获取或设置有限起始角度（度）。 |
| `Title` | 获取或设置 Gauge 标题。formatter/valueAnimation 按 ECharts 类型保留，但 6.1<br />GaugeView 不消费；赋空或空对象显式重置整块。 |
| `Tooltip` | 获取或设置系列级 CommonTooltip 覆盖；赋空显式重置整个块。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
