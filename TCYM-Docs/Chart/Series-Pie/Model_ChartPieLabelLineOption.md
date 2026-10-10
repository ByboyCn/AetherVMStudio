# ChartPieLabelLineOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Pie labelLine 的 presence-aware 配置；描边字段复用公共
`ChartLineStyleOption`。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Length` | 获取或设置引导线第一段的非负像素或视口宽度百分比长度。 |
| `Length2` | 获取或设置引导线第二段的非负像素或视口宽度百分比长度。 |
| `LineStyle` | 获取或设置引导线描边；赋空或空对象显式重置整块描边。 |
| `MaxSurfaceAngle` | 获取或设置引导线与扇区表面法线之间允许的 0～180 度最大角。 |
| `MinTurnAngle` | 获取或设置两段引导线之间允许的 0～180 度最小转角。 |
| `Show` | 获取或设置是否显示标签引导线。 |
| `Smooth` | 获取或设置布尔或明确强度的引导线平滑策略。 |

## 方法

### `Clone`

创建标量、描边与 presence 日志均隔离的副本。

**返回：** 内容等价的新 Pie labelLine。

### `Reset`

显式重置整块 Pie labelLine。
