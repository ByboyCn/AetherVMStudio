# ChartSeriesDataType

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Series`　**Chart 版本**：`0.1.1.25`

## 概述

标识系列内部的一类数据集合。值采用区分大小写的开放字符串协议；内置常量覆盖 ECharts
的主数据、节点和边，未来关系类系列可增加自己的稳定类型而不修改枚举 ABI。

## 构造函数

### `ChartSeriesDataType(String)`

创建一个开放的系列数据类型值。

| 参数 | 说明 |
| --- | --- |
| `value` | 区分大小写且非空白的稳定类型名。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Edge` | 获取关系图等系列的边数据类型。 |
| `Main` | 获取默认主数据类型。 |
| `Node` | 获取关系图等系列的节点数据类型。 |
| `Value` | 获取区分大小写的稳定字符串；结构默认值返回 `main`。 |

## 方法

### `Equals(Object)`

### `Equals(TCYM.UI.Chart.Series.ChartSeriesDataType)`

### `GetHashCode`

### `ToString`
