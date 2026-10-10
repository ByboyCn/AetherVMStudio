# ChartBrushValueRange

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示一个由两个强类型图表值组成的 Brush 坐标闭区间。

## 构造函数

### `ChartBrushValueRange(TCYM.UI.Chart.Data.ChartValue,TCYM.UI.Chart.Data.ChartValue)`

创建闭区间；端点顺序由目标轴解析阶段规范化。

| 参数 | 说明 |
| --- | --- |
| `start` | 第一个强类型端点。 |
| `end` | 第二个强类型端点。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `End` | 获取调用方提供的第二个端点。 |
| `Start` | 获取调用方提供的第一个端点。 |
