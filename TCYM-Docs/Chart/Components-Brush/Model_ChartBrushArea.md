# ChartBrushArea

> **类型**：abstract class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

为四类强类型 Brush area 保存共同的稳定 ID、Cartesian 目标、cover 行为和逐 area 样式补丁。
几何由各密封派生类型在构造时冻结。

## 属性

| 名称 | 说明 |
| --- | --- |
| `BrushStyle` | 获取或设置逐 area cover 样式；省略字段继承组件 BrushStyle。 |
| `BrushType` | 获取当前区域的几何类型。 |
| `Id` | 获取或设置区域稳定 ID；同一 action 批次内必须唯一。 |
| `RemoveOnClick` | 获取或设置 Single 模式下小于拖动阈值的点击是否移除 cover。 |
| `Target` | 获取或设置区域所属的 ID-first Cartesian 目标。 |
| `Transformable` | 获取或设置已提交 cover 是否允许移动或调整有效边。 |
| `Z` | 获取或设置该 cover 在组件根内的绘制层级。 |

## 方法

### `Clone`

创建几何、共同字段、画刷和 presence 均隔离的同类型副本。

### `MergeFrom(TCYM.UI.Chart.Model.ChartBrushArea)`

按 presence 合并同一几何类型的共同区域字段；冻结几何不被改写。

### `Reset`

清除共同覆盖字段；派生类型构造时冻结的几何保持不变。
