# ChartAxisType

> **类型**：enum　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

指定直角坐标轴采用的比例尺语义。未在 option 中赋值时，解析器会按轴数据是否存在决定
category 或 value 默认值。

## 枚举值

| 名称 | 说明 |
| --- | --- |
| `Category` | 离散分类轴。 |
| `Log` | 仅接受正数域的对数轴。 |
| `Time` | 以 UTC 时间线为内部域的时间轴。 |
| `Value` | 连续线性数值轴。 |
