# ChartBrushComponentSelector

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Components.Brush`　**Chart 版本**：`0.1.1.25`

## 概述

按 Brush 组件 ID、名称和同主类型索引的逻辑交集选择目标组件。

## 构造函数

### `ChartBrushComponentSelector(String,String,Nullable{Int32})`

创建组件选择器；全部参数为空时匹配全部 Brush 组件。

| 参数 | 说明 |
| --- | --- |
| `id` | 可选组件 ID。 |
| `name` | 可选组件名称。 |
| `index` | 可选同主类型索引。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Id` | 获取可选组件 ID。 |
| `Index` | 获取可选同主类型索引。 |
| `IsAll` | 获取当前选择器是否匹配全部 Brush 组件。 |
| `Name` | 获取可选组件名称。 |
