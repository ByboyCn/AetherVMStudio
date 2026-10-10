# ChartBrushTakeGlobalCursorAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Brush`　**Chart 版本**：`0.1.1.25`

## 概述

激活或释放 Brush 全局绘制光标的强类型 takeGlobalCursor action。

## 构造函数

### `ChartBrushTakeGlobalCursorAction(Nullable{TCYM.UI.Chart.Model.ChartBrushType},Nullable{TCYM.UI.Chart.Model.ChartBrushMode},TCYM.UI.Chart.Components.Brush.ChartBrushComponentSelector)`

创建光标 action；BrushType 为空时释放 Brush 光标。

| 参数 | 说明 |
| --- | --- |
| `brushType` | 要激活的几何类型；空值表示释放。 |
| `brushMode` | 可选的新建区域模式。 |
| `selector` | 目标 Brush 组件选择器。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Active` | 获取本 action 是否激活而不是释放 Brush 光标。 |
| `BrushMode` | 获取可选的新建区域模式。 |
| `BrushType` | 获取要激活的几何类型；空值表示释放 Brush 光标。 |
| `Key` | 获取固定的 Brush mutex key。 |
| `Selector` | 获取目标 Brush 组件选择器。 |

## 字段

| 名称 | 说明 |
| --- | --- |
| `ActionType` | 获取 ECharts 兼容 action 类型。 |
| `CursorKey` | 获取固定的 Brush mutex key。 |
| `EventType` | 获取成功提交后发布的事件类型。 |
