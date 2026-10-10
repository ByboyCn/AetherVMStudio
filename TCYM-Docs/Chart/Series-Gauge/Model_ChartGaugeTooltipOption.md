# ChartGaugeTooltipOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Gauge 系列使用的原生 CommonTooltip 子配置；复用公共 Tooltip 的字段级
presence、formatter、样式、Rich、深复制与 NativeAOT 安全契约。

## 方法

### `Clone`

创建全部 Tooltip 字段、委托、文本样式、Rich 与 presence 日志均隔离的副本。
