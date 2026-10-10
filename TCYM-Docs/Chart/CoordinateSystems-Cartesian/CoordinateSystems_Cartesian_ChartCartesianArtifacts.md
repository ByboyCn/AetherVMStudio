# ChartCartesianArtifacts

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.CoordinateSystems.Cartesian`　**Chart 版本**：`0.1.1.25`

## 概述

集中定义直角坐标布局与只读查询使用的全局强类型制品键。

## 属性

| 名称 | 说明 |
| --- | --- |
| `AxisQuery` | 获取当前候选或最后成功坐标轴查询入口的全局只读制品键。 |
| `CoordinateSystemMap` | 获取当前候选或最后成功布局中由公共工厂输出顺序冻结的轴对到坐标系映射。 |
| `Layout` | 获取当前候选或最后成功直角布局的全局只读制品键。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `AxisQueryArtifactName` | 无分配坐标轴查询入口的稳定制品名称。 |
| `CoordinateSystemMapArtifactName` | 按最终 X/Y 轴对发布坐标系独立快照映射的稳定制品名称。 |
| `LayoutArtifactName` | 全部直角网格和坐标轴聚合布局的稳定制品名称。 |
| `SeriesBindingArtifactName` | 按系列作用域发布最终 Cartesian 轴与坐标系绑定的稳定制品名称。 |

## 方法

### `BindingFor(TCYM.UI.Chart.Model.ChartSeriesOption)`

为一个有效系列取得按规范运行时身份作用域化的最终 Cartesian 绑定键。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效 option 中的系列节点。 |

**返回：** 不会因系列重排而改变作用域的强类型制品键。
