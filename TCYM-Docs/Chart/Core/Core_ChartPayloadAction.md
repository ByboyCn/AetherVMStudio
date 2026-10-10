# ChartPayloadAction

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Core`　**Chart 版本**：`0.1.1.25`

## 概述

携带任意负载的通用 action。

## 构造函数

### `ChartPayloadAction(String,Object)`

携带任意负载的通用 action。

| 参数 | 说明 |
| --- | --- |
| `type` | 用于查找处理器的 action 类型。 |
| `payload` | 传给处理器的可选负载。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Payload` | 获取 action 负载。 |
