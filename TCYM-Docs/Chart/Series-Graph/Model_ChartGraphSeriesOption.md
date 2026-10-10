# ChartGraphSeriesOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

有稳定节点和边身份的 Graph 系列。坐标单位为图表逻辑像素。

## 构造函数

### `ChartGraphSeriesOption`

创建空 Graph presence 补丁。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Blur` | Graph Blur 节点和边状态配置。 |
| `Categories` | 分类声明及分类视觉样式。列表按整体替换，赋空清空。 |
| `Curveness` | 边的曲率，默认零；自环始终使用可见的环形路径。 |
| `DefaultCoordinateSystemType` | 获取当前具体系列在 `CoordinateSystem` 未指定时采用的坐标系类型；<br />默认返回空，具体 line、bar、scatter 等系列应覆盖为自身真实默认值。 |
| `Draggable` | 允许拖动节点；默认关闭。 |
| `EdgeLabel` | 边标签样式；默认隐藏。 |
| `EdgeSymbol` | 边起终点原生符号，默认两端 None；显式 null 恢复默认。 |
| `EdgeSymbolSize` | 边起终点符号屏幕逻辑像素尺寸，默认两端 10；显式 null 恢复默认。 |
| `Emphasis` | Graph Emphasis 节点和边状态配置。 |
| `FocusNodeAdjacency` | 悬停时聚焦节点、相邻节点及其连接边。 |
| `Force` | 有界后台力导向参数；空块恢复默认。 |
| `Layout` | 布局算法；默认 None，显式赋空恢复默认。 |
| `LegendHoverLink` | 图例悬停联动开关，默认开启。 |
| `LineStyle` | 边的公共描边样式；显式空块恢复默认。 |
| `Links` | 用于普通节点 Data 的边列表；与 GraphData 内部 Links 互斥。赋空清空。 |
| `NodeScaleRatio` | 节点尺寸参与漫游缩放的比例，范围 0 到 1。0 保持节点及节点标签尺寸不变；默认 1 保留完整缩放行为。 |
| `Roam` | 允许鼠标平移和滚轮缩放；默认关闭。 |
| `Select` | Graph Select 节点和边状态配置。 |
| `SeriesType` | 获取系列注册表使用的类型名，例如 `line` 或 `bar`。 |
| `Symbol` | 默认节点符号，默认 circle。 |
| `SymbolRotate` | 节点符号旋转角度。 |
| `SymbolSize` | 默认节点符号逻辑像素尺寸，默认 16。 |
| `Tooltip` | 系列 item Tooltip 的 presence 补丁。 |

## 方法

### `Clone`

创建复制公共选项数据的新节点。实现应调用相应 Copy*To helper；返回后合并引擎会重新规范化
canonical identity，因此自定义派生类型也不能意外复制另一个节点的持久 view 身份。
