# ChartAxisLineStyleOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 axisLine、axisTick 和 splitLine 共享的线条样式补丁。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Color` | 获取或设置线条画刷；显式赋空可恢复主题默认值。 |
| `ColorSource` | 获取或设置强类型颜色来源。与 `Color` 共享同一 presence，<br />因而两者同时赋值时最后一次赋值生效；空值显式恢复消费方默认颜色。 |
| `Opacity` | 获取或设置线条透明度；解析时会限制到零至一。 |
| `Type` | 获取或设置实线、虚线或点线类型。 |
| `Width` | 获取或设置非负有限描边宽度。 |

## 方法

### `Clone`

创建画刷和 presence 日志均隔离的副本。

**返回：** 独立线条样式。

### `Reset`

显式把整个线条样式恢复到主题默认值。
