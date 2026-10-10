# ChartVisualMapSelectDataRangeAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.VisualMap`　**Chart 版本**：`0.1.1.25`

## 概述

修改 continuous 范围或 piecewise 选择映射的 ECharts 兼容 action。

## 构造函数

### `ChartVisualMapSelectDataRangeAction(Collections.Generic.IEnumerable{Collections.Generic.KeyValuePair{String,Boolean}},String,String,Nullable{Int32})`

使用 ECharts 风格组件字段创建 piecewise 选择补丁 action。

| 参数 | 说明 |
| --- | --- |
| `selected` | 以稳定逻辑 piece key 为键的选择补丁。 |
| `visualMapId` | 组件 ID；可传空以仅使用名称或索引。 |
| `visualMapName` | 可选组件名称。 |
| `visualMapIndex` | 可选同主类型索引。 |

### `ChartVisualMapSelectDataRangeAction(Collections.Generic.IEnumerable{Collections.Generic.KeyValuePair{String,Boolean}},TCYM.UI.Chart.Components.VisualMap.ChartVisualMapComponentSelector)`

创建 piecewise 选择补丁 action；输入会立即深复制。

| 参数 | 说明 |
| --- | --- |
| `selected` | 以稳定逻辑 piece key 为键的选择补丁。 |
| `selector` | 目标组件选择器。 |

### `ChartVisualMapSelectDataRangeAction(Double,Double,String,String,Nullable{Int32})`

创建 continuous 范围 action。

| 参数 | 说明 |
| --- | --- |
| `start` | 候选范围第一个有限端点。 |
| `end` | 候选范围第二个有限端点。 |
| `visualMapId` | 可选组件 ID。 |
| `visualMapName` | 可选组件名称。 |
| `visualMapIndex` | 可选同主类型索引。 |

### `ChartVisualMapSelectDataRangeAction(TCYM.UI.Chart.Model.ChartVisualMapRange,TCYM.UI.Chart.Components.VisualMap.ChartVisualMapComponentSelector)`

创建 continuous 范围 action。

| 参数 | 说明 |
| --- | --- |
| `range` | 两个端点均有限的候选范围。 |
| `selector` | 目标组件选择器。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Range` | 获取 continuous 候选范围；piecewise action 返回空。 |
| `Selected` | 获取 piecewise 只读选择补丁；continuous action 返回空。 |
| `Selector` | 获取目标组件选择器。 |
| `VisualMapId` | 获取可选组件 ID。 |
| `VisualMapIndex` | 获取可选组件索引。 |
| `VisualMapName` | 获取可选组件名称。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | 获取 action 类型。 |
| `EventType` | 获取成功提交后发布的事件类型。 |
