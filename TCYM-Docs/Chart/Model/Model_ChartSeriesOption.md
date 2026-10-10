# ChartSeriesOption

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

所有系列选项的基类，集中管理数据绑定、encode、常态样式与交互状态。嵌套块均保留各自
presence 日志，避免一个局部补丁重置未提交字段。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | 获取或设置 blur 状态选项；赋空会显式重置该状态。 |
| `CoordinateSystem` | 获取或设置系列使用的坐标系类型；为空可恢复系列默认坐标系。 |
| `Data` | 获取或设置二维 inline 数据。显式赋 `null` 会移除 inline 数据，<br />允许系列重新使用 dataset 绑定。 |
| `DataGroupId` | 获取或设置系列级 universal-transition 数据组身份；空或空字符串不会覆盖数据项 ID 回退。 |
| `DatasetId` | 获取或设置绑定的 dataset ID；解析时优先于索引。 |
| `DatasetIndex` | 获取或设置绑定的 dataset 索引。 |
| `DataSource` | 获取或设置通用系列原始数据。除二维表外还可承载 hierarchical/graph source；<br />Engine 会在 processor 运行前捕获不可变快照。赋空同样记录 presence。 |
| `DefaultCoordinateSystemType` | 获取当前具体系列在 `CoordinateSystem` 未指定时采用的坐标系类型；<br />默认返回空，具体 line、bar、scatter 等系列应覆盖为自身真实默认值。 |
| `Emphasis` | 获取或设置 emphasis 状态选项；赋空会显式重置该状态。 |
| `Encode` | 获取或设置视觉通道到维度的映射。赋空等价于显式清空 encode，而不是“不提交”。 |
| `ItemStyle` | 获取或设置常态图元样式；赋空会显式重置整块样式。 |
| `Label` | 获取或设置常态标签选项；赋空会显式重置整块标签配置。 |
| `LabelLayout` | 获取或设置公共中央标签终局布局。当前由 Cartesian Bar 和普通 Cartesian Scatter<br />消费；其他系列会保留配置并由 validator 报告范围诊断。赋空或赋新空对象均显式重置<br />整块，赋值时立即深复制，不借用调用方可变实例。 |
| `MainType` | 获取节点参与顶层合并与注册表匹配的主类型。 |
| `MarkArea` | 获取或设置当前系列的 markArea 配置；读取默认实例不会制造补丁，赋空会显式重置整个块。 |
| `MarkLine` | 获取或设置当前系列的 markLine 配置；读取默认实例不会制造补丁，赋空会显式重置整个块。 |
| `MarkPoint` | 获取或设置当前系列的 markPoint 配置；读取默认实例不会制造补丁，赋空会显式重置整个块。 |
| `PolarId` | 获取或设置绑定的 Polar 组件业务 ID；显式赋空可恢复按索引绑定。 |
| `PolarIndex` | 获取或设置绑定的 Polar 组件同主类型索引；`PolarId` 非空时优先按 ID 解析。 |
| `Select` | 获取或设置 select 状态选项；赋空会显式重置该状态。 |
| `SelectedMode` | 获取或设置 ECharts 风格的数据项选择模式。未指定时有效行为为<br />`Disabled`，但仍保留旧版 Line 数据项<br />`Selected=true` 的初始视觉兼容；显式设置 `Disabled` 会同时关闭该兼容种子。 |
| `SeriesLayoutBy` | 获取或设置 dataset 的行或列如何形成逻辑系列数据。显式赋 `null`<br />会恢复自动/默认绑定行为。 |
| `SeriesType` | 获取系列注册表使用的类型名，例如 `line` 或 `bar`。 |
| `SubType` | 获取 `MainType` 下的具体子类型。系列使用 `line`、`bar` 等值；<br />多数组件不需要子类型。 |
| `UniversalTransitionDelayCallback` | 获取或设置 universal transition 的逐项附加延迟回调。回调异常或返回负值只会取消<br />当次通用过渡候选，不会取消普通系列更新动画。 |
| `UniversalTransitionDivideShape` | 获取或设置一对多或多对一 universal transition 的图形拆分策略。未指定时由具体系列决定<br />有效默认值，公共基类不会通过 Normalize 写回默认值而污染 presence。 |
| `UniversalTransitionEnabled` | 获取或设置是否启用 universal transition；未指定或显式设为 `false`<br />时均不参与通用过渡，但二者在增量合并中保持不同的 presence 语义。 |
| `UniversalTransitionSeriesKey` | 获取或设置关联前后系列的单一键或无序键集合；未指定时依次使用系列 ID、名称，<br />最后使用不含系列类型的稳定全局索引键。 |
| `XAxisId` | 获取或设置绑定的 X 轴业务 ID；显式赋空可恢复按索引绑定，单 X 轴时可与<br />`XAxisIndex` 一起省略并默认绑定索引 0。 |
| `XAxisIndex` | 获取或设置绑定的 X 轴同主类型索引；`XAxisId` 非空时优先按 ID 解析，<br />ID 和索引均省略时默认绑定索引 0。 |
| `YAxisId` | 获取或设置绑定的 Y 轴业务 ID；显式赋空可恢复按索引绑定，单 Y 轴时可与<br />`YAxisIndex` 一起省略并默认绑定索引 0。 |
| `YAxisIndex` | 获取或设置绑定的 Y 轴同主类型索引；`YAxisId` 非空时优先按 ID 解析，<br />ID 和索引均省略时默认绑定索引 0。 |
