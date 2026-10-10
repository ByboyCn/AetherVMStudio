# ChartVisualMapVisualOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

保存 VisualMap 一个状态声明的 color、opacity、symbol 与 symbolSize 映射序列。
每个公开写操作都会验证并深复制输入。

## 构造函数

### `ChartVisualMapVisualOption`

创建不带任何映射通道的视觉块。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Color` | 获取或整体设置按低值到高值排列的颜色 stop。 |
| `Opacity` | 获取或整体设置取值范围为 0～1 的 opacity stop。 |
| `Symbol` | 获取或整体设置按归一化值选择的 symbol 序列。 |
| `SymbolSize` | 获取或整体设置按低值到高值插值的 symbolSize stop。 |

## 方法

### `Clone`

创建通道值与 presence 日志均独立的副本。

### `Reset`

显式清除全部映射通道。
