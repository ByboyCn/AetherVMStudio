# ChartVisualMapComponentSelector

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Components.VisualMap`　**Chart 版本**：`0.1.1.25`

## 概述

按 VisualMap 组件 ID、名称和同主类型索引的交集选择组件。

## 构造函数

### `ChartVisualMapComponentSelector(String,String,Nullable{Int32})`

创建组件选择器；全部参数为空时匹配全部 VisualMap。

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
| `IsAll` | 获取是否匹配全部 VisualMap。 |
| `Name` | 获取可选组件名称。 |
