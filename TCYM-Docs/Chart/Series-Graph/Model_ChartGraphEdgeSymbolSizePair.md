# ChartGraphEdgeSymbolSizePair

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

Graph 两端符号的名义屏幕逻辑像素尺寸；不随漫游缩放放大，零表示隐藏。

## 构造函数

### `ChartGraphEdgeSymbolSizePair(Single,Single)`

创建有限、范围为 0 到 1024 的起终点尺寸。

| 参数 | 说明 |
| --- | --- |
| `start` | 源节点一端的名义正方形边长。 |
| `end` | 目标节点一端的名义正方形边长。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `End` | 获取目标节点一端的名义尺寸。 |
| `Start` | 获取源节点一端的名义尺寸。 |
