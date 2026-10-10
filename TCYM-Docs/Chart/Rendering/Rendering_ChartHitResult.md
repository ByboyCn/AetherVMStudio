# ChartHitResult

> **类型**：struct　**命名空间**：`TCYM.UI.Chart.Rendering`　**Chart 版本**：`0.1.1.25`

## 概述

一次场景命中的稳定身份与元数据。

## 构造函数

### `ChartHitResult(TCYM.UI.Chart.Rendering.ChartElement,Int32,TCYM.UI.Chart.Interaction.ChartElementMetadata)`

一次场景命中的稳定身份与元数据。

| 参数 | 说明 |
| --- | --- |
| `Element` | 命中的场景元素。 |
| `ItemIndex` | 批量元素内部的数据项索引；普通元素为 -1。 |
| `ItemMetadata` | 批量数据项专属元数据；为空时使用元素元数据。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Element` | 命中的场景元素。 |
| `ItemIndex` | 批量元素内部的数据项索引；普通元素为 -1。 |
| `ItemMetadata` | 批量数据项专属元数据；为空时使用元素元数据。 |
| `Metadata` | 获取数据项元数据；未提供时回退到元素级元数据。 |

## 方法

### `HasSameIdentity(TCYM.UI.Chart.Rendering.ChartHitResult@)`

同一批次内不同数据项拥有不同身份，供 hover/out/click 状态机比较。

| 参数 | 说明 |
| --- | --- |
| `other` | 待比较的另一次命中。 |

**返回：** 两个元素属于同一交互绑定，或未绑定时元素引用与批量项索引都相同时为 `true`。

### `SetInteractionState(TCYM.UI.Chart.Rendering.ChartInteractionState,Boolean,String)`

按来源把状态路由到命中的 batch 数据项；内置 batch 会隔离来源，第三方旧式
`IChartItemStateHost` 则保持原有逐项回退语义。

| 参数 | 说明 |
| --- | --- |
| `state` | 要修改的状态位。 |
| `enabled` | 为 `true` 时设置状态，否则仅清除该来源的状态。 |
| `sourceKey` | 区分大小写且非空白的状态来源标识。 |

### `SetInteractionState(TCYM.UI.Chart.Rendering.ChartInteractionState,Boolean)`

把状态路由到命中的 batch 数据项；普通元素则直接更新元素状态。

| 参数 | 说明 |
| --- | --- |
| `state` | 要修改的状态位。 |
| `enabled` | 为 `true` 时设置状态，否则清除状态。 |
