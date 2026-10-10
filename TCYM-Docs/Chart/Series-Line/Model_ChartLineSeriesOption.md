# ChartLineSeriesOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 6.1 `series.line` 的 presence-aware 配置节点。
本类型只定义 option、数据绑定和状态契约；实际折线路径从 M2.2 开始由生产 View 消费。

## 构造函数

### `ChartLineSeriesOption`

创建空 Line 补丁，并为三个交互状态安装 Line 专属状态类型。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AnimationDelay` | 获取或设置 Line/area 揭示与 symbol/普通 label 进入共用的首次延迟（毫秒）；<br />空值继承全局 `Animation` 配置。 |
| `AnimationDelayUpdate` | 获取或设置 Line/area 数据更新过渡延迟（毫秒）；空值继承全局<br />`UpdateDelay`。 |
| `AnimationDuration` | 获取或设置 Line/area 首次揭示时长及 symbol/普通 label 错峰基准时长（毫秒）；<br />空值继承全局 `Animation` 配置。 |
| `AnimationDurationUpdate` | 获取或设置 Line/area 数据更新过渡时长（毫秒）；空值继承全局<br />`UpdateDuration`。 |
| `AnimationEasing` | 获取或设置 Line 首次动画缓动名称；该字段不会改变全局<br />`Animation` 默认值。 |
| `AnimationEasingUpdate` | 获取或设置 Line/area 数据更新过渡缓动名称；空值继承全局<br />`UpdateEasing`。 |
| `AnimationThreshold` | 获取或设置允许动画的最大处理后数据项数量；超过该非负阈值时直接提交终态。<br />ECharts 6.1 的系列默认值为 2000。 |
| `AreaStyle` | 获取或设置面积填充样式。赋入非空实例会启用面积，赋空会显式关闭面积并清除旧样式；<br />直接修改 getter 返回实例的字段也会启用面积。 |
| `Blur` | 获取或设置 Line blur 状态；该状态不公开仅属于 emphasis 的缩放。 |
| `Clip` | 获取或设置是否把折线、面积和 symbol 裁剪到坐标系边界。 |
| `ConnectNulls` | 获取或设置是否跨越空值连接相邻有效数据点。 |
| `DefaultCoordinateSystemType` | 获取当前具体系列在 `CoordinateSystem` 未指定时采用的坐标系类型；<br />默认返回空，具体 line、bar、scatter 等系列应覆盖为自身真实默认值。 |
| `Emphasis` | 获取或设置精确的 Line emphasis 状态；经系列基类入口写入的公共 emphasis 字段会安全投影。 |
| `EndLabel` | 获取或设置终点标签；赋空显式恢复整块 Line 默认值。 |
| `HoverLayerThreshold` | 获取或设置启用独立悬停图层的数据量阈值；正无穷表示永不启用。 |
| `IsAreaStyleEnabled` | 获取当前补丁或合并结果是否启用了面积填充。 |
| `LegendHoverLink` | 获取或设置 Legend 悬停是否联动强调该系列。 |
| `LineStyle` | 获取或设置常态折线路径样式；赋空显式恢复整块 Line 默认值。 |
| `Progressive` | 获取或设置非负渐进绘制参数（每帧批量数）。Line 的 ECharts 默认值为 0，即关闭；<br />当前正数仅保留 option 兼容性并报告稳定诊断，不会执行分帧绘制。 |
| `Sampling` | 获取或设置 Cartesian Line 的生产大数据降采样算法；默认<br />`None` 保留全部处理后数据项。 |
| `SamplingCallback` | 获取或设置系列中立的自定义采样回调。非空回调优先于 `Sampling` 选择的<br />内置算法；显式赋空仅清除回调，不改变内置算法。 |
| `Select` | 获取或设置 Line select 状态；该状态不公开路径、面积或 emphasis 缩放。 |
| `SeriesType` | 获取系列注册表使用的类型名，例如 `line` 或 `bar`。 |
| `ShowAllSymbol` | 获取或设置类目轴 symbol 的自动、跟随间隔或全部显示策略。 |
| `ShowSymbol` | 获取或设置是否显示数据项 symbol。 |
| `Smooth` | 获取或设置布尔值或 0～1 张力形式的平滑配置。 |
| `SmoothMonotone` | 获取或设置平滑曲线的单调维度约束。 |
| `Stack` | 获取或设置 line/bar 共用公共 stack 系统使用的分组键；空值或空字符串表示不参与堆叠。 |
| `StackOrder` | 获取或设置同一 stack 分组按系列正序或倒序累计。 |
| `StackStrategy` | 获取或设置同一 stack 分组中正负值的堆叠策略。 |
| `Step` | 获取或设置阶梯线模式。 |
| `Symbol` | 获取或设置公共 symbol 类型、`path://` 路径或 `image://` URI；<br />显式赋空恢复 `emptyCircle` 默认值。 |
| `SymbolCallback` | 获取或设置逐有效数据项执行的 symbol callback；callback 返回空值、无效声明或抛出异常时<br />回退到 `Symbol`，逐项显式 symbol 最终仍具有最高优先级。 |
| `SymbolKeepAspect` | 获取或设置 image symbol 是否保持原始宽高比。 |
| `SymbolOffset` | 获取或设置 symbol 的像素或百分比二维偏移。 |
| `SymbolRotate` | 获取或设置 symbol 的顺时针有限旋转角度（度）。 |
| `SymbolSize` | 获取或设置 symbol 的单值或二维尺寸。 |
| `SymbolSizeCallback` | 获取或设置逐有效数据项执行的 symbolSize callback；callback 返回空值或抛出异常时<br />回退到 `SymbolSize`，逐项显式尺寸最终仍具有最高优先级。 |
| `TriggerEvent` | 获取或设置折线路径、面积或两者的事件命中范围。 |
| `TriggerLineEvent` | 获取或设置 ECharts 6.0.1 起废弃的旧事件开关。旧值 `true`<br />同时启用折线路径和面积事件，等价于 `LineAndArea`。 |
| `UniversalTransitionDivideShape` | 获取或设置 universal transition 的形状拆分策略。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
