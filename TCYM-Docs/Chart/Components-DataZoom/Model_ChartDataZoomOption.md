# ChartDataZoomOption

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

定义全部 dataZoom 子类型共享的数据窗口、目标轴与过滤配置。
setter 会记录字段 presence，使 `SetOption` 能区分未提供字段与显式恢复默认值。

## 说明

M1.8 内置运行时只执行 inside、Cartesian value/time/log 轴以及 Filter/None；其他子类型、轴系或
过滤模式会产生稳定诊断并保持未缩放，供后续里程碑扩展。

## 属性

| 名称 | 说明 |
| --- | --- |
| `ComponentType` | 获取组件注册与合并所使用的类型名。 |
| `Disabled` | 获取或设置是否禁用当前 dataZoom 组件。 |
| `End` | 获取或设置窗口终点百分比，取值范围为 0～100。 |
| `FilterMode` | 获取或设置窗口外数据的处理模式；M1.8 内置运行时只执行 Filter 与 None，其他合法枚举值<br />会诊断并保持未缩放。 |
| `MaxSpan` | 获取或设置窗口允许的最大百分比跨度，取值范围为 0～100。显式双击完整复位在同代约束下<br />保持 0～100，直到普通窗口变更或新的 MinSpan/MaxSpan 补丁恢复约束。 |
| `MinSpan` | 获取或设置窗口允许的最小百分比跨度，取值范围为 0～100。显式双击完整复位在同代约束下<br />保持 0～100，直到普通窗口变更或新的 MinSpan/MaxSpan 补丁恢复约束。 |
| `Start` | 获取或设置窗口起点百分比，取值范围为 0～100。 |
| `XAxisIndex` | 获取或设置目标 X 轴索引。可直接赋单个整数、整数数组或 collection expression；<br />赋 `null` 表示未指定本维度，X/Y 均为空值时自动选择 X0；<br />空集合表示本维度明确不绑定任何轴，不会触发自动回退。 |
| `YAxisIndex` | 获取或设置目标 Y 轴索引。可直接赋单个整数、整数数组或 collection expression；<br />赋 `null` 表示未指定本维度，X/Y 均为空值时自动选择 X0；<br />空集合表示本维度明确不绑定任何轴，不会触发自动回退。 |
| `ZoomLock` | 获取或设置是否禁用 inside 滚轮缩放并保留平移；双击完整复位和公开 dataZoom action<br />不受此交互锁限制。 |

## 方法

### `Reset`

显式清除 dataZoom 公共字段和当前子类型字段。组件身份、通用布局以及
`Show` 等基类字段不受影响。
