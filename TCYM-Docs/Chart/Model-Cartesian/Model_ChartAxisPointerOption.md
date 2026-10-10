# ChartAxisPointerOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示单个轴上的 axisPointer 显示、吸附、值和视觉样式。

## 属性

| 名称 | 说明 |
| --- | --- |
| `LineStyle` | 获取或设置 line/cross 指示线样式；空或未修改实例表示重置。 |
| `ShadowStyle` | 获取或设置 shadow 指示区域样式；空或未修改实例表示重置。 |
| `Show` | 获取或设置 axisPointer 是否显示；空值表示自动。 |
| `Snap` | 获取或设置指示器是否吸附到最近有效轴值。 |
| `Status` | 获取或设置指示器显式显示状态。 |
| `TriggerTooltip` | 获取或设置 axisPointer 更新是否触发 axis tooltip。 |
| `Type` | 获取或设置 axisPointer 几何类型。 |
| `Value` | 获取或设置指示器显式轴值；赋空恢复自动值。 |
| `Z` | 获取或设置 axisPointer 在同一画布层中的绘制顺序。 |

## 方法

### `Clone`

创建线条和颜色集合完全隔离的 axisPointer 副本。

**返回：** 独立副本。

### `Reset`

显式恢复整个 axisPointer 默认值。
