# ChartCandlestickSeriesOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 6.1 `series.candlestick` 的 presence-aware 配置节点。当前生产管线支持
完整静态 Cartesian 方向与四状态视觉、category/value/time/log 轴、inverse、宽度、doji、
Grid clip、Label/Legend/Tooltip/VisualMap/Mark、选择、focus/blur、cursor、silent、DataZoom、
Brush、多系列窗口联动，以及 Normal/NormalProgressive/Large/LargeProgressive retained View。
compact 路径的逐项能力和动画/Universal Transition 会按公开限制给出稳定诊断。

## 构造函数

### `ChartCandlestickSeriesOption`

创建四个图元样式作用域彼此独立的空 Candlestick 补丁。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AnimationDelay` | 获取或设置首次进入动画的非负固定延迟（毫秒）。 |
| `AnimationDelayCallback` | 获取或设置按 inside 数据索引解析首次延迟的回调；这里只保存而不执行。 |
| `AnimationDelayUpdate` | 获取或设置更新动画的非负固定延迟（毫秒）。 |
| `AnimationDelayUpdateCallback` | 获取或设置按 inside 数据索引解析更新延迟的回调；这里只保存而不执行。 |
| `AnimationDuration` | 获取或设置首次进入动画的非负固定时长（毫秒）。 |
| `AnimationDurationCallback` | 获取或设置按 inside 数据索引解析首次时长的回调；这里只保存而不执行。 |
| `AnimationDurationUpdate` | 获取或设置更新动画的非负固定时长（毫秒）。 |
| `AnimationDurationUpdateCallback` | 获取或设置按 inside 数据索引解析更新时长的回调；这里只保存而不执行。 |
| `AnimationEasing` | 获取或设置首次动画 easing 名称；合法性由 option validator 诊断。 |
| `AnimationEasingUpdate` | 获取或设置更新动画 easing 名称；合法性由 option validator 诊断。 |
| `AnimationThreshold` | 获取或设置超过后直接提交动画终态的非负数据量阈值。 |
| `BarMaxWidth` | 获取或设置有限非负像素或百分比形式的最大 candle 宽度。 |
| `BarMinWidth` | 获取或设置有限非负像素或百分比形式的最小 candle 宽度。 |
| `BarWidth` | 获取或设置有限非负像素或百分比形式的显式 candle 宽度。 |
| `Blur` | 获取或设置精确的 Candlestick blur 状态。 |
| `Clip` | 获取或设置是否裁剪到最终坐标系边界。 |
| `ColorBy` | 获取或设置调色板按系列或数据项分配的策略。 |
| `Cursor` | 获取或设置命中图元时建议使用的原生指针光标名称。 |
| `DefaultCoordinateSystemType` | 获取当前具体系列在 `CoordinateSystem` 未指定时采用的坐标系类型；<br />默认返回空，具体 line、bar、scatter 等系列应覆盖为自身真实默认值。 |
| `Emphasis` | 获取或设置精确的 Candlestick emphasis 状态。 |
| `HoverLayerThreshold` | 获取或设置悬停图层阈值；正无穷表示永不启用。 |
| `ItemStyle` | 获取或设置 normal Candlestick 专用 itemStyle；公共 setter 同样安全。 |
| `Large` | 获取或设置是否允许使用 large 聚合路径。 |
| `LargeThreshold` | 获取或设置进入 large 路径的非负数据量阈值。 |
| `Layout` | 获取或设置两轴均为连续轴时的基础轴排列方向；任一 category 轴始终优先作为基础轴，<br />因而会覆盖相冲突的显式方向。空值由布局阶段按轴类型推断。 |
| `LegendHoverLink` | 获取或设置 Legend 悬停联动开关。 |
| `Progressive` | 获取或设置每个 progressive 分块的非负数据项数。 |
| `ProgressiveChunkMode` | 获取或设置 progressive 的分块遍历顺序。 |
| `ProgressiveThreshold` | 获取或设置启动 progressive 的非负数据量阈值。 |
| `Select` | 获取或设置精确的 Candlestick select 状态。 |
| `SeriesType` | 获取系列注册表使用的类型名，例如 `line` 或 `bar`。 |
| `Tooltip` | 获取或设置系列级 CommonTooltip；赋空显式重置整个块。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
