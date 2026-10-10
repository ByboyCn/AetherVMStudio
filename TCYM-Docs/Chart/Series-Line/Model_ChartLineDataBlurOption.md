# ChartLineDataBlurOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示单个 Line 数据项的 blur 差异；只公开 label、itemStyle 和 endLabel。

## 属性

| 名称 | 说明 |
| --- | --- |
| `EndLabel` | 获取或设置逐项 blur 终点标签；赋空显式重置整块标签。 |

## 方法

### `Clone`

创建逐项 blur 公共视觉状态和终点标签均隔离的副本。

**返回：** 内容等价的新逐项 blur 状态。
