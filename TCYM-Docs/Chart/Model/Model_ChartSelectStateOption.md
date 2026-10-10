# ChartSelectStateOption

> **类型**：class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示所有系列 select 都支持的状态字段。ECharts 6.1 只在 select 公共层增加
disabled，不公开 emphasis 的 blurScope 或系列专属 focus。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Disabled` | 获取或设置是否禁用 select 状态。 |

## 方法

### `Clone`

创建 select 公共字段、视觉块与 presence 日志均独立的副本。

**返回：** 内容等价的新 select 状态。
