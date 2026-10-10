# ChartPolarRadius

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Polar 内外半径。单值 ECharts `radius` 应使用 `FromOuter`，
它会把内半径规范化为零。

## 构造函数

### `ChartPolarRadius(TCYM.UI.Chart.Model.ChartLength,TCYM.UI.Chart.Model.ChartLength)`

创建一个内外半径范围；布局阶段负责按解析后的像素值交换反向范围。

| 参数 | 说明 |
| --- | --- |
| `inner` | 非负有限内半径。 |
| `outer` | 非负有限外半径。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Default` | 获取 ECharts Polar 的默认半径 `[0, '80%']`。 |
| `Inner` | 获取内半径。 |
| `Outer` | 获取外半径。 |

## 方法

### `FromOuter(TCYM.UI.Chart.Model.ChartLength)`

把 ECharts 单值半径规范化为零内半径和指定外半径。

| 参数 | 说明 |
| --- | --- |
| `outer` | 非负有限外半径。 |

**返回：** 内半径为零像素的半径范围。
