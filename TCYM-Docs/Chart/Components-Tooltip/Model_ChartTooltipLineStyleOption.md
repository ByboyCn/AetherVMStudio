# ChartTooltipLineStyleOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 axisPointer 线条的 presence-aware 样式补丁。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Color` | 获取或设置线条画刷；显式空值恢复继承值。 |
| `Type` | 获取或设置 solid、dashed、dotted 等线型关键字。 |
| `Width` | 获取或设置有限非负线宽。 |

## 方法

### `Clone`

创建画刷、数值和 presence 日志均隔离的副本。

**返回：** 等价新样式。

### `Reset`

显式清除整个线条样式块。
