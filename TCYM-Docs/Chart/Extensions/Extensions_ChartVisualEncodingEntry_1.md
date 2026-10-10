# ChartVisualEncodingEntry&lt;T1&gt;

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Extensions`　**Chart 版本**：`0.1.1.25`

## 概述

把一个强类型视觉编码负载绑定到规范系列身份。

## 构造函数

### `ChartVisualEncodingEntry<T1>(TCYM.UI.Chart.Model.ChartSeriesOption,)`

创建系列视觉编码条目。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前 effective option 中的系列节点。 |
| `encoding` | 深度不可变编码负载。 |

## 属性

| 名称 | 说明 |
| --- | --- |
| `Encoding` | 获取强类型不可变编码负载。 |
| `SeriesRuntimeIdentity` | 获取配置合并保留的规范系列运行时身份。 |

## 方法

### `BelongsTo(TCYM.UI.Chart.Model.ChartSeriesOption)`

判断本条目是否属于指定系列节点保留的规范身份。

| 参数 | 说明 |
| --- | --- |
| `series` | 待比较系列节点。 |

**返回：** 运行时身份一致时为 `true`。
