# ChartScatterSeriesOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 6.1 `series.scatter` 的 presence-aware 配置节点。普通 Cartesian
Symbol/Visual/Label、四种性能模式、普通动画与 Universal Transition 均由生产管线消费。

## 构造函数

### `ChartScatterSeriesOption`

创建空 Scatter 补丁并安装精确的 emphasis、blur 与 select 状态类型。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AnimationDelay` | 获取或设置首次 Scatter 动画延迟覆盖，单位毫秒。 |
| `AnimationDelayCallback` | 获取或设置逐项首次 Scatter 动画延迟 callback。 |
| `AnimationDelayUpdate` | 获取或设置 Scatter 更新动画延迟覆盖，单位毫秒。 |
| `AnimationDelayUpdateCallback` | 获取或设置逐项 Scatter 更新动画延迟 callback。 |
| `AnimationDuration` | 获取或设置首次 Scatter 动画时长覆盖，单位毫秒。 |
| `AnimationDurationCallback` | 获取或设置逐项首次 Scatter 动画时长 callback。 |
| `AnimationDurationUpdate` | 获取或设置 Scatter 更新动画时长覆盖，单位毫秒。 |
| `AnimationDurationUpdateCallback` | 获取或设置逐项 Scatter 更新动画时长 callback。 |
| `AnimationEasing` | 获取或设置首次 Scatter 动画缓动名称覆盖。 |
| `AnimationEasingUpdate` | 获取或设置 Scatter 更新动画缓动名称覆盖。 |
| `AnimationThreshold` | 获取或设置允许逐项动画的非负处理后数据量阈值。 |
| `Blur` | 获取或设置 Scatter blur 状态。 |
| `Clip` | 获取或设置是否把 Scatter symbol 裁剪到坐标系边界。 |
| `ColorBy` | 获取或设置调色板按整个系列还是按数据项分配颜色。 |
| `Cursor` | 获取或设置命中 Scatter 图元时建议使用的原生指针光标名称。 |
| `DefaultCoordinateSystemType` | 获取当前具体系列在 `CoordinateSystem` 未指定时采用的坐标系类型；<br />默认返回空，具体 line、bar、scatter 等系列应覆盖为自身真实默认值。 |
| `Emphasis` | 获取或设置 Scatter emphasis 状态；公共输入会安全投影为精确类型。 |
| `HoverLayerThreshold` | 获取或设置启用独立悬停图层的数据量阈值；正无穷表示永不启用。 |
| `Large` | 获取或设置是否允许 Scatter 使用 large 聚合路径。 |
| `LargeThreshold` | 获取或设置进入 large 路径的非负数据量阈值。 |
| `LegendHoverLink` | 获取或设置 Legend 悬停是否联动强调该 Scatter 系列。 |
| `Progressive` | 获取或设置 progressive 每个分块的非负数据项数。 |
| `ProgressiveChunkMode` | 获取或设置 progressive 的连续或取模（`mod`）分块顺序。 |
| `ProgressiveThreshold` | 获取或设置允许启动 progressive 的非负数据量阈值。 |
| `Select` | 获取或设置 Scatter select 状态。 |
| `SeriesType` | 获取系列注册表使用的类型名，例如 `line` 或 `bar`。 |
| `Stack` | 获取或设置公共 stack 分组键；空值或空字符串表示不参与堆叠。 |
| `StackOrder` | 获取或设置 stack 按系列正序或倒序累计。 |
| `StackStrategy` | 获取或设置 stack 的同号、全部、正数或负数堆叠策略。 |
| `Symbol` | 获取或设置 symbol 名称、`path://` 路径或 `image://` URI。 |
| `SymbolCallback` | 获取或设置逐有效数据项执行的 symbol callback。 |
| `SymbolKeepAspect` | 获取或设置 image symbol 是否保持源宽高比。 |
| `SymbolOffset` | 获取或设置 symbol 的有限像素或百分比二维偏移。 |
| `SymbolOffsetCallback` | 获取或设置逐有效数据项执行的 symbolOffset callback。 |
| `SymbolRotate` | 获取或设置 symbol 的顺时针有限旋转角度（度）。 |
| `SymbolRotateCallback` | 获取或设置逐有效数据项执行的 symbolRotate callback。 |
| `SymbolSize` | 获取或设置 symbol 的单值或二维有限非负尺寸。 |
| `SymbolSizeCallback` | 获取或设置逐有效数据项执行的 symbolSize callback。 |
| `Tooltip` | 获取或设置系列级 CommonTooltip 覆盖；赋空显式重置整个块。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
