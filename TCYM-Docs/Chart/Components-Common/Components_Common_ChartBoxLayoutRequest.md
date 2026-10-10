# ChartBoxLayoutRequest

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Components.Common`　**Chart 版本**：`0.1.1.25`

## 概述

描述一次与系列类型无关的组件矩形布局请求。六个边框约束采用 ECharts 风格的
pixel、percent、auto 和位置关键字，期望尺寸表示未显式给出宽高时的内容尺寸。

## 构造函数

### `ChartBoxLayoutRequest(SkiaSharp.SKRect,Nullable{TCYM.UI.Chart.Model.ChartLength},Nullable{TCYM.UI.Chart.Model.ChartLength},Nullable{TCYM.UI.Chart.Model.ChartLength},Nullable{TCYM.UI.Chart.Model.ChartLength},Nullable{TCYM.UI.Chart.Model.ChartLength},Nullable{TCYM.UI.Chart.Model.ChartLength},Nullable{SkiaSharp.SKSize},TCYM.UI.Chart.Components.Common.ChartBoxStyle)`

创建通用组件矩形布局请求。

| 参数 | 说明 |
| --- | --- |
| `viewport` | 端点有限且已经规范化的可用视口。 |
| `left` | 可选左侧位置、百分比或水平对齐关键字。 |
| `top` | 可选顶部位置、百分比或垂直对齐关键字。 |
| `right` | 可选右侧边距、百分比或水平对齐关键字。 |
| `bottom` | 可选底部边距、百分比或垂直对齐关键字。 |
| `width` | 可选边框盒宽度；auto 与空值含义相同。 |
| `height` | 可选边框盒高度；auto 与空值含义相同。 |
| `desiredContentSize` | 自动宽高采用的有限非负内容期望尺寸；为空时按视口填充。 |
| `style` | 参与自动尺寸与内容区计算的不可变矩形样式。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Bottom` | 获取底部约束。 |
| `DesiredContentSize` | 获取自动宽高使用的内容期望尺寸。 |
| `Height` | 获取边框盒高度约束。 |
| `Left` | 获取左侧约束。 |
| `Right` | 获取右侧约束。 |
| `Style` | 获取参与布局的矩形样式；默认请求返回共享空样式。 |
| `Top` | 获取顶部约束。 |
| `Viewport` | 获取布局可使用的视口。 |
| `Width` | 获取边框盒宽度约束。 |
