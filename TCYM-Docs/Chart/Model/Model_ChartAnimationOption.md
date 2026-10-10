# ChartAnimationOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示全局动画配置。每个 setter 独立记录 presence，便于 `setOption` 只合并调用方
实际提交的动画字段。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Delay` | 获取或设置动画启动延迟（毫秒）。 |
| `Duration` | 获取或设置首次进入动画时长（毫秒）。 |
| `Easing` | 获取或设置缓动函数名称。 |
| `Enabled` | 获取或设置是否启用动画。 |
| `UpdateDelay` | 获取或设置数据更新动画启动延迟（毫秒）。 |
| `UpdateDuration` | 获取或设置数据更新动画时长（毫秒）。 |
| `UpdateEasing` | 获取或设置数据更新动画缓动函数名称。 |

## 方法

### `Clone`

创建值与 presence 日志均独立的动画选项副本。

**返回：** 内容等价的新实例。
