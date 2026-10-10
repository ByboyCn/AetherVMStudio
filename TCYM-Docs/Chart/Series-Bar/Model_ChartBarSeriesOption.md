# ChartBarSeriesOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 6.1 `series.bar` 的 presence-aware 配置节点。当前生产路径已开放普通
Cartesian stack、分槽、视觉、Tooltip、Legend 与 Mark 集成；延期配置仍保留精确 presence 并诊断。

## 构造函数

### `ChartBarSeriesOption`

创建空 Bar 补丁并安装精确的三种交互状态类型。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AnimationDelay` | 获取或设置首次 Bar 动画延迟覆盖，单位毫秒。 |
| `AnimationDelayCallback` | 获取或设置逐项首次 Bar 动画延迟 callback；显式赋空会清除已合并 callback。 |
| `AnimationDelayUpdate` | 获取或设置 Bar 数据更新动画延迟覆盖，单位毫秒。 |
| `AnimationDelayUpdateCallback` | 获取或设置逐项 Bar 更新动画延迟 callback；显式赋空会清除已合并 callback。 |
| `AnimationDuration` | 获取或设置首次 Bar 动画时长覆盖，单位毫秒。 |
| `AnimationDurationCallback` | 获取或设置逐项首次 Bar 动画时长 callback；显式赋空会清除已合并 callback。 |
| `AnimationDurationUpdate` | 获取或设置 Bar 数据更新动画时长覆盖，单位毫秒。 |
| `AnimationDurationUpdateCallback` | 获取或设置逐项 Bar 更新动画时长 callback；显式赋空会清除已合并 callback。 |
| `AnimationEasing` | 获取或设置首次 Bar 动画缓动名称覆盖。 |
| `AnimationEasingUpdate` | 获取或设置 Bar 数据更新动画缓动名称覆盖。 |
| `AnimationThreshold` | 获取或设置允许逐项动画的非负处理后数据量阈值。 |
| `BackgroundStyle` | 获取或设置柱槽背景样式；赋空显式重置整块样式。背景 borderRadius 的 ECharts 兼容输入<br />只允许 Pixel，Percent 由 Bar validator 报告而不静默解释。 |
| `BarCategoryGap` | 获取或设置有限非负像素或类别带百分比形式的类别间距。 |
| `BarGap` | 获取或设置柱槽间距；数值表示相对柱宽的直接比例，百分比表示百分数，二者都不是像素。 |
| `BarMaxWidth` | 获取或设置有限非负像素或类别带百分比形式的最大柱宽。 |
| `BarMinAngle` | 获取或设置切向 Polar Bar 的有限非负最小角度（度）。 |
| `BarMinHeight` | 获取或设置 Cartesian 或径向 Polar Bar 的有限非负最小屏幕长度。 |
| `BarMinWidth` | 获取或设置有限非负像素或类别带百分比形式的最小柱宽。 |
| `BarWidth` | 获取或设置有限非负像素或类别带百分比形式的显式柱宽。 |
| `Blur` | 获取或设置 Bar blur 状态。 |
| `Clip` | 获取或设置是否把 Bar 前景与背景裁剪到最终坐标系边界。 |
| `ColorBy` | 获取或设置调色板按整个系列还是按数据项分配颜色。 |
| `Cursor` | 获取或设置命中该 Bar 系列图元时建议使用的原生指针光标名称。 |
| `DataGroupId` | 获取或设置系列级 universal transition 数据组身份。 |
| `DefaultCoordinateSystemType` | 获取当前具体系列在 `CoordinateSystem` 未指定时采用的坐标系类型；<br />默认返回空，具体 line、bar、scatter 等系列应覆盖为自身真实默认值。 |
| `Emphasis` | 获取或设置 Bar emphasis 状态；公共输入会安全投影为精确 Bar 类型。 |
| `HoverLayerThreshold` | 获取或设置启用独立悬停图层的数据量阈值；正无穷表示永不启用。 |
| `Large` | 获取或设置是否允许 Cartesian Bar 使用 large 聚合路径。 |
| `LargeThreshold` | 获取或设置进入 large 聚合路径的非负数据量阈值。 |
| `LegendHoverLink` | 获取或设置 Legend 悬停是否联动强调该 Bar 系列。 |
| `Progressive` | 获取或设置 large Cartesian 路径每个 progressive 分块的非负项数；普通 Bar 不消费该值。 |
| `ProgressiveChunkMode` | 获取或设置 large progressive 的取模（`mod`）分块顺序。 |
| `ProgressiveThreshold` | 获取或设置允许启动 large progressive 的非负数据量阈值。 |
| `RealtimeSort` | 获取或设置 Cartesian category base axis 是否启用实时排序。 |
| `RoundCap` | 获取或设置切向 Polar Bar 是否使用圆形端帽。 |
| `Sampling` | 获取或设置 Cartesian Bar 的降采样算法；Polar 不消费该值。 |
| `SamplingCallback` | 获取或设置系列中立的自定义采样回调。非空回调优先于 `Sampling` 选择的<br />内置算法；显式赋空仅清除回调，不改变内置算法。 |
| `Select` | 获取或设置 Bar select 状态。 |
| `SeriesType` | 获取系列注册表使用的类型名，例如 `line` 或 `bar`。 |
| `ShowBackground` | 获取或设置是否为能够建立柱槽布局的数据项绘制完整背景。 |
| `Stack` | 获取或设置公共 stack 分组键；空值或空字符串表示不参与堆叠。 |
| `StackOrder` | 获取或设置 Cartesian stack 按系列正序或倒序累计。 |
| `StackStrategy` | 获取或设置 Cartesian stack 的同号、全部、正数或负数堆叠策略。 |
| `Tooltip` | 获取或设置系列级 CommonTooltip 覆盖；赋空显式重置整个块。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
