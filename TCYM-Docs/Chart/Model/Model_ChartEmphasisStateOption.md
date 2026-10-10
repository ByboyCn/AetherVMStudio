# ChartEmphasisStateOption

> **类型**：class　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示所有系列 emphasis 都支持的状态字段：状态禁用和失焦影响范围。
系列专属 focus、scale 或样式字段由具体 emphasis 类型继续扩展。

## 属性

| 名称 | 说明 |
| --- | --- |
| `BlurScope` | 获取或设置进入 emphasis 后的失焦影响范围，例如<br />`coordinateSystem`、`series` 或 `global`。 |
| `Disabled` | 获取或设置是否禁用 emphasis 状态。 |

## 方法

### `Clone`

创建 emphasis 公共字段、视觉块与 presence 日志均独立的副本。

**返回：** 内容等价的新 emphasis 状态。
