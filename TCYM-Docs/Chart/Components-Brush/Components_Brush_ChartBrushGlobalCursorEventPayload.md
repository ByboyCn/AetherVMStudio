# ChartBrushGlobalCursorEventPayload

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Brush`　**Chart 版本**：`0.1.1.25`

## 概述

保存 globalcursortaken 事件中 Brush 光标的最终激活状态。

## 构造函数

### `ChartBrushGlobalCursorEventPayload(Boolean,Nullable{TCYM.UI.Chart.Model.ChartBrushType},Nullable{TCYM.UI.Chart.Model.ChartBrushMode})`

创建不可变 Brush 全局光标事件负载。

| 参数 | 说明 |
| --- | --- |
| `active` | 是否已激活 Brush 光标。 |
| `brushType` | 激活的几何类型；未激活时必须为空。 |
| `brushMode` | 本次使用的区域模式。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Active` | 获取 Brush 光标是否激活。 |
| `BrushMode` | 获取最终区域模式。 |
| `BrushType` | 获取激活的 Brush 几何类型。 |
| `Key` | 获取固定 Brush mutex key。 |
