# ChartMarkLineEndpointsDataItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示正式的 `[start, end]` 任意方向 markLine 数据项。

## 构造函数

### `ChartMarkLineEndpointsDataItem(TCYM.UI.Chart.Model.ChartMarkLineEndpointOption,TCYM.UI.Chart.Model.ChartMarkLineEndpointOption)`

从两个非空端点创建 markLine 数据项。

| 参数 | 说明 |
| --- | --- |
| `start` | 起点配置。 |
| `end` | 终点配置。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `End` | 获取或设置终点；赋空会被拒绝。 |
| `Start` | 获取或设置起点；赋空会被拒绝。 |

## 方法

### `Clone`

创建两个端点和身份均隔离的副本。

**返回：** 内容等价的新端点对。
