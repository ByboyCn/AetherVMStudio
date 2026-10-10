# ChartMarkOption

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 markPoint、markLine 和 markArea 共用的嵌套组件字段。字段保持 presence-aware，默认值只由
显式 Mark 模块在 effective option 中物化。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Animation` | 获取或设置该标记是否启用动画；仍受宿主系列和全局动画总开关约束。 |
| `AnimationDelay` | 获取或设置首次动画延迟，单位毫秒。 |
| `AnimationDelayCallback` | 获取或设置逐项首次动画延迟回调；与 `AnimationDelay` 独立保存，运行时优先级<br />由 Mark 动画模块决定。 |
| `AnimationDelayUpdate` | 获取或设置更新动画延迟，单位毫秒。 |
| `AnimationDelayUpdateCallback` | 获取或设置逐项更新动画延迟回调；与 `AnimationDelayUpdate` 独立保存，运行时<br />优先级由 Mark 动画模块决定。 |
| `AnimationDuration` | 获取或设置首次动画时长，单位毫秒。 |
| `AnimationDurationCallback` | 获取或设置逐项首次动画时长回调；与 `AnimationDuration` 独立保存，运行时优先级<br />由 Mark 动画模块决定。 |
| `AnimationDurationUpdate` | 获取或设置更新动画时长，单位毫秒。 |
| `AnimationDurationUpdateCallback` | 获取或设置逐项更新动画时长回调；与 `AnimationDurationUpdate` 独立保存，运行时<br />优先级由 Mark 动画模块决定。 |
| `AnimationEasing` | 获取或设置首次动画缓动名称。 |
| `AnimationEasingUpdate` | 获取或设置更新动画缓动名称。 |
| `AnimationThreshold` | 获取或设置超过后关闭标记动画的数据量阈值。 |
| `Silent` | 获取或设置该标记是否忽略交互；宿主系列静默时最终仍保持静默。 |
| `Tooltip` | 获取或设置 mark 专属 Tooltip；赋空显式重置该子块。 |
| `Z` | 获取或设置同一画布层内的绘制顺序。 |
| `ZLevel` | 获取或设置独立画布层级。 |

## 方法

### `Reset`

显式清除整个 mark 块及其派生数据和样式。
