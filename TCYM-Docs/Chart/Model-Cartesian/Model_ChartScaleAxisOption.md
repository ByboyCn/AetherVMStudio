# ChartScaleAxisOption

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Cartesian 与 Polar 比例轴共享的 ECharts 风格补丁。所有可空标量均保留“未提交”和“显式恢复自动值”
的区别；嵌套块独立记录 presence，读取默认实例本身没有副作用。

## 说明

受当前公共组件基类契约限制，本类型会继承 Left、Top、Right、Bottom、Width 和 Height，
但这些 box-layout 字段对坐标轴不生效。具体轴类型通过各自的坐标组件 ID/索引决定归属。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AlignTicks` | 获取或设置是否把当前 value/log 轴的主刻度与同 grid、同维度的稳定目标轴对齐。<br />空值保留自动/未提交语义；显式配置 Interval 的轴不会被二次改写。 |
| `AxisLabel` | 获取或设置独立轴标签块；不复用 series label 语义。 |
| `AxisLine` | 获取或设置主轴线块；空或未修改实例表示显式重置。 |
| `AxisPointer` | 获取或设置单轴 axisPointer 块；空或未修改实例表示显式重置。 |
| `AxisTick` | 获取或设置主刻度块；空或未修改实例表示显式重置。 |
| `BoundaryGap` | 获取或设置分类 band 或连续数据域双端间隙。 |
| `ContainShape` | 获取或设置轴是否尽量把系列形状包含在轴范围内；空值由具体坐标族采用自身有效默认值。 |
| `Data` | 获取或设置 category 轴数据。集合写操作或整体赋值都会把当前列表作为整组补丁；空集合或<br />空引用可显式清除先前分类。整体赋值会先防御性复制输入，因此来源集合后续变化不会污染轴选项。<br />ChartValue 的对象载荷已在创建时满足不可变或快照契约。 |
| `Interval` | 获取或设置严格正有限固定主刻度间隔；空值表示自动。 |
| `Inverse` | 获取或设置是否反向排列轴数据域。 |
| `LogBase` | 获取或设置 log 轴大于一的有限对数底数。 |
| `Maximum` | 获取或设置固定、dataMax 或自动的轴最大边界；空值表示自动。 |
| `MaximumInterval` | 获取或设置严格正有限最大主刻度间隔。 |
| `Minimum` | 获取或设置固定、dataMin 或自动的轴最小边界；空值表示自动。 |
| `MinimumInterval` | 获取或设置非负有限最小主刻度间隔。 |
| `MinorSplitLine` | 获取或设置次分隔线块；空或未修改实例表示显式重置。 |
| `MinorTick` | 获取或设置次刻度块；空或未修改实例表示显式重置。 |
| `NameGap` | 获取或设置轴名称与轴线之间的非负有限像素间距。 |
| `NameLocation` | 获取或设置轴名称相对于轴线的停靠位置。 |
| `NameRotate` | 获取或设置轴名称顺时针旋转角度；空值表示按位置自动。 |
| `NameTextStyle` | 获取或设置完整轴名称文本样式。样式字体按借用资源处理，画刷和值在选项克隆时深度快照；<br />显式赋空会恢复新的默认样式。 |
| `NameTruncate` | 获取或设置轴名称截断配置；显式赋空或未修改实例会在合并时恢复自动宽度和默认省略号。 |
| `Scale` | 获取或设置 value 轴是否不再强制自动域包含零。 |
| `SplitArea` | 获取或设置交替分隔区域块；空或未修改实例表示显式重置。 |
| `SplitLine` | 获取或设置主分隔线块；空或未修改实例表示显式重置。 |
| `SplitNumber` | 获取或设置期望主刻度分段数，范围为 1 到 1000。 |
| `StartValue` | 获取或设置 ECharts Numeric Axis 的有限 `startValue`；空值显式恢复自动起点。<br />显式 `Minimum` 优先于该值，Bar 等需要基线的系列仍可请求轴类型默认起点。 |
| `TriggerEvent` | 获取或设置轴图元是否产生组件级交互事件。 |
| `Type` | 获取或设置轴类型；空值由解析器按 Data presence 推断 category 或 value。 |
