# ChartBarTooltipOption

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Bar 系列和数据项使用的 CommonTooltip 子配置。实现复用经过 M2 Mark 验证的公共字段级
presence、深复制和 AOT 安全契约。为保持既有实现与二进制入口，本节点的继承链及
`Trigger` 联合值仍保留 Mark 命名；M3.6 再评估抽取中性公共基类。

## 方法

### `Clone`

创建全部 CommonTooltip 字段、委托、样式和 presence 日志均隔离的副本。

**返回：** 内容等价的新 Bar Tooltip 配置。
