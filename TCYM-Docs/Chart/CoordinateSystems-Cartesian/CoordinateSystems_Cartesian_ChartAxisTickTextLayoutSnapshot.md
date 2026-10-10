# ChartAxisTickTextLayoutSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

保存一个最终入选轴刻度的不可变格式化内容与统一文本布局；锚点仍由最终轴几何按稳定刻度索引取得。

## 构造函数

### `ChartAxisTickTextLayoutSnapshot(Int32,TCYM.UI.Chart.Text.ChartTextContent,TCYM.UI.Chart.Text.ChartTextLayoutResult)`

创建一个无需在 view 中再次 formatter 或测量的轴标签文本快照。

| 参数 | 说明 |
| --- | --- |
| `tickIndex` | 对应主刻度的稳定零基索引。 |
| `content` | formatter 产生的不可变内容。 |
| `layout` | 由同一内容产生的不可变统一文本布局。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Content` | 获取 formatter、outerBounds 与渲染共同消费的不可变内容。 |
| `Layout` | 获取 outerBounds、绘制与命中共同消费的不可变布局。 |
| `TickIndex` | 获取对应主刻度的稳定索引。 |
