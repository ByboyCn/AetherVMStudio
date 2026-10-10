# ChartVisualEncodingArtifacts

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Extensions`　**Chart 版本**：`0.1.1.25`

## 概述

创建 Visual 编码结果与边界使用的强类型 Artifact 键。

## 方法

### `Boundary(TCYM.UI.Chart.Extensions.ChartVisualEncodingPhase)`

获取指定阶段的空边界标记键。

| 参数 | 说明 |
| --- | --- |
| `phase` | 边界所在阶段。 |

**返回：** 固定边界制品键。

### `ForPhase(TCYM.UI.Chart.Extensions.ChartVisualEncodingPhase)`

为一种视觉编码负载和一个明确阶段创建全局强类型键。
泛型值类型参与 Artifact 槽身份，调用方不提供分派字符串。

| 参数 | 说明 |
| --- | --- |
| `phase` | 编码位于系列视觉处理之前还是之后。 |

**返回：** 可由 producer 和 consumer 独立创建但仍指向同一槽的键。
