# ChartMarkImplicitComponentSnapshot

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Mark`　**Chart 版本**：`0.1.1.25`

## 概述

保存本轮由 Normalize 物化、但不宣称已有 View 的隐式 Mark 组件模型。
每种 Kind 是一个逻辑组件，Owners 列出它服务的全部宿主系列。

## 构造函数

### `ChartMarkImplicitComponentSnapshot(Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Mark.ChartMarkImplicitComponentOwner})`

创建 model-only 隐式组件快照。

| 参数 | 说明 |
| --- | --- |
| `owners` | 全部有效 Mark 数据块的宿主 owner。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Kinds` | 获取本轮实际存在的逻辑 Mark 组件类型。 |
| `Owners` | 获取按稳定顺序排列的全部 owner。 |

## 方法

### `Contains(TCYM.UI.Chart.Components.Mark.ChartMarkKind,TCYM.UI.Chart.Model.ChartSeriesOption)`

判断指定宿主系列是否由某个逻辑 Mark 组件服务。

| 参数 | 说明 |
| --- | --- |
| `kind` | Mark 类型。 |
| `series` | 待查询宿主系列。 |

**返回：** Kind 和 RuntimeUid 同时命中时为 `true`。

### `Contains(TCYM.UI.Chart.Components.Mark.ChartMarkKind)`

判断本轮是否物化了指定逻辑 Mark 组件。

| 参数 | 说明 |
| --- | --- |
| `kind` | 待查询 Mark 类型。 |

**返回：** 至少有一个 owner 时为 `true`。
