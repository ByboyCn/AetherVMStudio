# ChartTooltipBoxPosition

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

保存 Tooltip box position 的四侧可选像素或百分比长度。

## 构造函数

### `ChartTooltipBoxPosition(Nullable{TCYM.UI.Chart.Model.ChartLength},Nullable{TCYM.UI.Chart.Model.ChartLength},Nullable{TCYM.UI.Chart.Model.ChartLength},Nullable{TCYM.UI.Chart.Model.ChartLength})`

创建 box position，并验证每个已提供侧边。

| 参数 | 说明 |
| --- | --- |
| `left` | 可选左侧位置。 |
| `top` | 可选顶部位置。 |
| `right` | 可选右侧位置。 |
| `bottom` | 可选底部位置。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Bottom` | 获取底部位置。 |
| `IsEmpty` | 获取是否没有指定任何侧边。 |
| `Left` | 获取左侧位置。 |
| `Right` | 获取右侧位置。 |
| `Top` | 获取顶部位置。 |
