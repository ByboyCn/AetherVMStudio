# ChartTooltipContent

> **类型**：sealed class　**命名空间**：`TCYM.UI.Chart.Components.Tooltip`　**Chart 版本**：`0.1.1.25`

## 概述

表示 Tooltip formatter 的不可变原生输出。文本模式承载自定义 rich 字符串；结构化模式承载
axis/item 默认 markup。该契约不接受 HTML 或 DOM 节点。

## 属性

| 名称 | 说明 |
| --- | --- |
| `Empty` | 获取共享空内容。 |
| `IsText` | 获取当前是否为自定义文本模式。 |
| `Sections` | 获取结构化分区；文本模式返回空集合。 |
| `Text` | 获取自定义文本；结构化模式返回 `null`。 |

## 方法

### `FromSections(Collections.Generic.IEnumerable{TCYM.UI.Chart.Components.Tooltip.ChartTooltipContentSection})`

从结构化分区创建内容并复制集合。

| 参数 | 说明 |
| --- | --- |
| `sections` | 不包含空项的分区序列。 |

**返回：** 不可变结构化内容。

### `FromText(String)`

创建不执行 HTML 解释的原生文本内容。

| 参数 | 说明 |
| --- | --- |
| `text` | 可为空的文本；空值规范为空字符串。 |

**返回：** 不可变文本内容。
