# ChartEventArgs

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Interaction`　**Chart 版本**：`0.1.1.25`

## 概述

与 ECharts 常用事件字段对齐的图表交互事件参数。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Button` | 获取触发事件的鼠标按钮。 |
| `ComponentId` | 获取命中组件的显式标识。 |
| `ComponentIndex` | 获取命中组件的索引；未命中时为 -1。 |
| `ComponentType` | 获取命中组件的主类型。 |
| `Data` | 获取命中元素附带的领域负载。 |
| `DataIndex` | 获取命中项在原始数据中的稳定索引；未命中时为 -1。 |
| `DataIndexInside` | 获取命中项在系列当前公开 presentation 中的索引；未命中时为 -1。 |
| `DataType` | 获取命中项的数据集合类型；普通数据为main，关系图使用node或edge。 |
| `DeviceType` | 获取产生事件的指针设备类型。 |
| `Handled` | 获取或设置事件是否已被处理。 |
| `Modifiers` | 获取事件发生时按下的修饰键。 |
| `Name` | 获取命中项名称。 |
| `Percent` | 获取饼图、漏斗图等比例系列共享的可选百分比；不提供比例语义的系列返回<br />`null`。 |
| `PrimaryValue` | 获取系列确定的主要显示值；向量通常对应 value encode 维度。 |
| `SeriesId` | 获取命中系列的显式标识。 |
| `SeriesIndex` | 获取命中系列的索引；未命中时为 -1。 |
| `SeriesType` | 获取命中系列的类型。 |
| `TooltipTarget` | 获取独立于业务负载的只读 tooltip 稳定命中身份。 |
| `Type` | 获取事件类型。 |
| `Value` | 获取保持原始标量或向量语法形状的命中项值。 |
| `WheelDelta` | 获取滚轮增量；非滚轮事件为 0。 |
| `X` | 获取事件在图表内容区中的 X 像素坐标。 |
| `Y` | 获取事件在图表内容区中的 Y 像素坐标。 |
