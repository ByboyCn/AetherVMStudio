# ChartSymbolScale

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Model`　**Chart 版本**：`0.1.1.25`

## 概述

表示 emphasis symbol 缩放的布尔值或正数联合类型。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Automatic` | 获取使用默认倍率的启用值。 |
| `Disabled` | 获取禁用缩放的值。 |
| `Enabled` | 获取是否启用 emphasis 缩放。 |
| `Factor` | 获取明确倍率；为空表示使用默认倍率。 |

## 方法

### `FromFactor(Single)`

从正有限倍率创建缩放值。

| 参数 | 说明 |
| --- | --- |
| `factor` | 缩放倍率。 |

**返回：** 启用且使用指定倍率的值。
