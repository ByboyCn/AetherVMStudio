# ChartAxisLineSymbolOffset

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示标准物理轴线起点和终点沿轴向可独立配置的有限偏移。

## 构造函数

### `ChartAxisLineSymbolOffset(Single,Single)`

创建双端符号的有符号轴向像素偏移。

| 参数 | 说明 |
| --- | --- |
| `start` | 物理起点沿标准轴正方向的有限偏移；正值向轴内移动。 |
| `end` | 物理终点沿标准轴正方向的有限偏移；正值向轴外移动。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `End` | 获取物理终点沿标准轴正方向的偏移。 |
| `Start` | 获取物理起点沿标准轴正方向的偏移。 |
