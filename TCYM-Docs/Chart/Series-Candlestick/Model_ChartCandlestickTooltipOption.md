# ChartCandlestickTooltipOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Candlestick 系列和数据项使用的 CommonTooltip 子配置。该类型复用公共 Tooltip 的
presence、深复制和 AOT 安全契约。

## 方法

### `Clone`

创建全部 Tooltip 字段、委托、样式与 presence 日志均隔离的副本。

**返回：** 内容等价的新 Candlestick Tooltip 配置。
