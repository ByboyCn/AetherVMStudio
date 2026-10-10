# ChartGridOuterBoundsMode

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

指定 grid 外边界约束的解析模式，对应 ECharts 6 的 `outerBoundsMode`。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `Auto` | 自动使用 outerBounds；兼容 containLabel 时可退化为 Same。 |
| `None` | 不限制轴标签或轴名称超出 grid 基础矩形。 |
| `Same` | 外边界与 grid 的基础布局矩形相同。 |
