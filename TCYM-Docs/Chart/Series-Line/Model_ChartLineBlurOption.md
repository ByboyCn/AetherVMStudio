# ChartLineBlurOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Line blur 状态；精确公开路径、面积、label、itemStyle 和 endLabel，
不公开 emphasis/select 的 disabled、blurScope、focus 或 scale。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AreaStyle` | 获取或设置 blur 面积样式；赋空显式重置整块样式。 |
| `EndLabel` | 获取或设置 blur 终点标签；赋空显式重置整块标签。 |
| `LineStyle` | 获取或设置 blur 折线路径样式；赋空显式重置整块样式。 |

## 方法

### `Clone`

创建 blur 路径、面积、终点标签和公共视觉状态均隔离的副本。

**返回：** 内容等价的新 blur 状态。
