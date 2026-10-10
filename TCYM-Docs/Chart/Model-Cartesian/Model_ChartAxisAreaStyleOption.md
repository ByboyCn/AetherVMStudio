# ChartAxisAreaStyleOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 splitArea 和 shadow axisPointer 使用的区域样式补丁。

## 构造函数

### `ChartAxisAreaStyleOption`

创建尚未提交颜色或透明度的空样式。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Color` | 获取区域颜色序列。任何写操作都会把来源颜色作为整组补丁；Clear 表示恢复默认颜色组。 |
| `Opacity` | 获取或设置区域透明度；解析时会限制到零至一。 |

## 方法

### `Clone`

创建颜色集合、画刷和 presence 日志均隔离的副本。

**返回：** 独立区域样式。

### `Reset`

显式恢复整个区域样式默认值。
