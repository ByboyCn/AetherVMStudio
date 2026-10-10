# ChartAxisLineSymbolPair

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 ECharts 标准物理轴线起点和终点可独立配置的符号。

## 构造函数

### `ChartAxisLineSymbolPair(TCYM.UI.Chart.Model.ChartAxisLineSymbol,TCYM.UI.Chart.Model.ChartAxisLineSymbol)`

创建一对经过枚举有效性验证的轴线端点符号。

| 参数 | 说明 |
| --- | --- |
| `start` | 标准物理轴线起点的符号；X 为左端，Y 为下端。 |
| `end` | 标准物理轴线终点的符号；X 为右端，Y 为上端。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `End` | 获取标准物理轴线终点的符号。 |
| `Start` | 获取标准物理轴线起点的符号。 |

## 方法

### `Both(TCYM.UI.Chart.Model.ChartAxisLineSymbol)`

创建两个端点使用相同符号的值。

| 参数 | 说明 |
| --- | --- |
| `symbol` | 同时应用到逻辑起点和逻辑终点的符号。 |

**返回：** 双端相同的符号对。
