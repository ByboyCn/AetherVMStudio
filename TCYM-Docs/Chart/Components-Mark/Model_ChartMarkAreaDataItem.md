# ChartMarkAreaDataItem

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示正式的 `[start, end]` markArea 数据项。公开构造器和属性始终要求两个端点，因而
无法把单轴对象或任意长度数组误传为区域数据。

## 构造函数

### `ChartMarkAreaDataItem(TCYM.UI.Chart.Model.ChartMarkAreaEndpointOption,TCYM.UI.Chart.Model.ChartMarkAreaEndpointOption)`

从两个非空端点创建 markArea 数据项。

| 参数 | 说明 |
| --- | --- |
| `start` | 区域第一角端点。 |
| `end` | 区域对角端点。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `End` | 获取或设置区域对角端点；赋空会被拒绝。 |
| `Start` | 获取或设置区域第一角端点；赋空会被拒绝。 |

## 方法

### `Clone`

创建两个端点、身份和所有自定义值载荷均隔离的副本。

**返回：** 内容等价的新区域数据项。
