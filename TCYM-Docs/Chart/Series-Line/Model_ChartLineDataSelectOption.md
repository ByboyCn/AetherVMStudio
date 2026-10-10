# ChartLineDataSelectOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示单个 Line 数据项的 select 差异；精确公开 disabled、label、itemStyle 和 endLabel。

## 属性

| 名称 | 说明 |
| --- | --- |
| `EndLabel` | 获取或设置逐项 select 终点标签；赋空显式重置整块标签。 |

## 方法

### `Clone`

创建逐项 select disabled、公共视觉状态和终点标签均隔离的副本。

**返回：** 内容等价的新逐项 select 状态。
