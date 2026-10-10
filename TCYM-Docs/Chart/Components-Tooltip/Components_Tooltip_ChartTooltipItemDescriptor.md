# ChartTooltipItemDescriptor

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

描述 series 或公共组件发布给 Tooltip 的单个不可变 item。descriptor 自身只保存稳定 key，
独立命中身份由 Interaction 层绑定；可选 Tooltip override 在每次跨制品、请求和状态边界时深复制。

## 构造函数

### `ChartTooltipItemDescriptor(String,TCYM.UI.Chart.Components.Tooltip.ChartTooltipFormatterParameters,TCYM.UI.Chart.Components.Tooltip.ChartTooltipContent,TCYM.UI.Chart.Components.Tooltip.ChartTooltipSeriesPresentation,Nullable{TCYM.UI.Chart.Data.ChartDataKey},Nullable{SkiaSharp.SKRect},String,TCYM.UI.Chart.Components.Tooltip.ChartTooltipFormatter,TCYM.UI.Chart.Components.Tooltip.ChartTooltipAsyncFormatter,TCYM.UI.Chart.Components.Tooltip.ChartTooltipValueFormatter,TCYM.UI.Chart.Model.ChartTooltipPosition,TCYM.UI.Chart.Rendering.ChartBrush,Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Tooltip.ChartTooltipAxisDataPoint},Int32,TCYM.UI.Chart.Model.ChartTooltipOption)`

创建不可变 Tooltip item descriptor。

| 参数 | 说明 |
| --- | --- |
| `key` | owner 内稳定且非空的 descriptor key。 |
| `parameters` | 已隔离的 formatter 参数。 |
| `defaultContent` | formatter 缺失、失败或返回空时使用的内容。 |
| `series` | 可选系列 presentation。 |
| `dataKey` | 可选数据项稳定身份，用于和 Interaction 命中目标匹配。 |
| `targetBounds` | 可选命中图元包围盒快照。 |
| `formatterTemplate` | ECharts a/b/c/d/e 模板。 |
| `formatter` | 同步强类型 formatter。 |
| `asyncFormatter` | 可取消异步 formatter。 |
| `valueFormatter` | 默认 markup 的值 formatter。 |
| `position` | item 级 position 覆盖。 |
| `preferredBorderColor` | item tooltip 自动边框画刷。 |
| `axisPoints` | 供 axis nearest 索引使用的不可变数据点。 |
| `stableOrder` | owner 内稳定零基顺序。 |
| `optionOverride` | 可选 item 级 Tooltip presence patch；构造器会深复制，且不会采用该补丁的 RuntimeUid。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `AsyncFormatter` | 获取可取消异步 formatter。 |
| `AxisPoints` | 获取供 axis trigger nearest 查询使用的只读数据点集合。 |
| `DataKey` | 获取可选数据项稳定身份。Interaction 层应使用该值匹配命中目标；<br />`Key` 仅用于 owner 内区分 descriptor。 |
| `DefaultContent` | 获取 formatter 回退内容。 |
| `Formatter` | 获取同步 formatter。 |
| `FormatterTemplate` | 获取 ECharts a/b/c/d/e 模板。 |
| `Key` | 获取 owner 内稳定 key。 |
| `OptionOverride` | 获取与 descriptor 隔离的 item 级 Tooltip presence patch 副本；修改返回值不会回写 descriptor。 |
| `Parameters` | 获取已隔离 formatter 参数。 |
| `Position` | 获取 item 级位置覆盖。 |
| `PreferredBorderColor` | 获取已快照的自动边框画刷。 |
| `Series` | 获取可选系列 presentation。 |
| `StableOrder` | 获取 owner 内稳定顺序。 |
| `TargetBounds` | 获取可选命中图元包围盒。 |
| `ValueFormatter` | 获取值 formatter。 |
